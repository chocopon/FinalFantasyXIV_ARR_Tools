using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

using ProcessMemoryTool;

namespace FFXIV_Tools
{
    public class FFXIVLogMemoryInfo
    {
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[0-9A-F]{12}::Welcome to");

        int LogEntPtr;
        int LogCurrentPtr;
        int LogIndexPtr;
        int LogCountPtr;

        public int Progress
        {
            get;
            private set;
        }

        public bool IsCancelPending
        {
            get;
            private set;
        }

        public void CancelSearching()
        {
            IsCancelPending = true;
        }

        /// <summary>
        /// FF14のプロセス
        /// </summary>
        ProcessMemory ffxiv;

        /// <summary>
        /// FFXIVLogMemoryInfo
        /// </summary>
        /// <param name="proc"></param>
        public FFXIVLogMemoryInfo(System.Diagnostics.Process proc)
        {
            ffxiv = new ProcessMemory(proc);
        }

        /// <summary>
        /// ログ情報を探索する
        /// </summary>
        /// <returns></returns>
        public bool SearchLogMemoryInfo()
        {
            //プログレス
            Progress = 0;
            //debug
            DateTime st = DateTime.Now;

            List<Memory.MEMORY_BASIC_INFORMATION> WRMemoryInfoList = new List<Memory.MEMORY_BASIC_INFORMATION>();
            Memory memory = new Memory();

            foreach (Memory.MEMORY_BASIC_INFORMATION m in ffxiv.GetMemoryBasicInfos())
            {
                if (m.Type != (uint)Memory.MEMORY_TYPE.MEM_PRIVATE || m.Protect != Memory.MEMORY_ALLOCATION_PROTECT.PAGE_READWRITE)
                    continue;
                                //Write Read属性のメモリinfoをリスト化
                WRMemoryInfoList.Add(m);
            }
            WRMemoryInfoList.Sort((a, b) => (int)a.BaseAddress - (int)b.BaseAddress);

            Regex logRegex = new Regex("[0-9A-F]{12}:[^\x00]{0,36}:[^\x00]*?[0-9A-F]{12}:[^\x00]{0,36}");

            int prog = 0;

            foreach (Memory.MEMORY_BASIC_INFORMATION m in WRMemoryInfoList)
            {
                //プログレス
                Progress = 100 * prog++ / WRMemoryInfoList.Count;

                //キャンセル可能
                if (IsCancelPending)
                {
                    IsCancelPending = false;
                    return false;
                }
              
                // 1 "::Welcome to Masamune ! 「等」を探す

                byte[] buffer = ffxiv.ReadBytes((int)m.BaseAddress, (int)m.RegionSize);
                string str = ASCIIEncoding.ASCII.GetString(buffer);
                if (!str.Contains(":"))
                {
                    continue;
                }
                //Welcome to を取得
                //if (Encoding.ASCII.GetString(buffer).Contains("::Welcome to"))
                MatchCollection matches = logRegex.Matches(str);
                foreach(Match match in matches)
                {
                    //キャンセル可能
                    if (IsCancelPending)
                    {
                        IsCancelPending = false;
                        return false;
                    }

                    string TimstampHexString = match.Value.Substring(0, 8);
                    DateTime datetime = FFXIVLog.StartDateTime.AddSeconds(Convert.ToInt32(TimstampHexString,16));
                    if (datetime < new DateTime(2013, 8, 29) || datetime > DateTime.Now.ToUniversalTime())
                    {
                        continue;
                    }

                    //"::Welcome to"のアドレス
                    int offset = match.Index;
                    if (offset < 12) continue;
                    //ログの開始アドレス
                    int ptr_logStart = (int)m.BaseAddress + offset;//
                    //ログを取得して正規表現でチェック
                    byte[] data = ffxiv.ReadBytes(ptr_logStart, 100);
                    //ptr_LogStartRegexが格納されているアドレスをサーチする
                    foreach (Memory.MEMORY_BASIC_INFORMATION _m in WRMemoryInfoList)
                    {
                        byte[] _buffer = ffxiv.ReadBytes((int)_m.BaseAddress, (int)_m.RegionSize);
                        MemoryStream ms = new MemoryStream(_buffer);
                        BinaryReader br = new BinaryReader(ms);
                        while (ms.Position < _buffer.Length - 4)
                        {
                            if (ptr_logStart == br.ReadInt32())//アドレス格納先？
                            {
                                int c_ptr_LogEnd = br.ReadInt32();
                                if (c_ptr_LogEnd >= ptr_logStart &&
                                    c_ptr_LogEnd <= (int)m.BaseAddress + (int)m.RegionSize)
                                {
                                    //見つけた！
                                    LogEntPtr = (int)_m.BaseAddress + (int)ms.Position - 8;
                                    LogCurrentPtr = LogEntPtr + 4;
                                    LogIndexPtr = LogEntPtr - 0x10;
                                    LogCountPtr = LogEntPtr - 0x30;

                                    try
                                    {
                                        GetLogsData();
                                        DateTime fini = DateTime.Now;
                                        System.Diagnostics.Debug.WriteLine((fini - st).TotalSeconds);
                                        return true;
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //みつからなかった
            return false;
        }

        private bool TryGetMemoryInfo(List<Memory.MEMORY_BASIC_INFORMATION> sortedList, int address, out Memory.MEMORY_BASIC_INFORMATION m_info)
        {
            foreach (Memory.MEMORY_BASIC_INFORMATION m in sortedList)
            {
                if (address > (int)m.BaseAddress && address < (int)m.BaseAddress + (int)m.RegionSize)
                {
                    m_info = m;
                    return true;
                }
            }
            m_info = new Memory.MEMORY_BASIC_INFORMATION();
            return false;
        }


        /// <summary>
        /// ログのデータを取得します
        /// </summary>
        /// <returns></returns>
        public byte[] GetLogData()
        {
            int log_ent = ffxiv.ReadInt32( LogEntPtr);
            int log_current = ffxiv.ReadInt32(LogCurrentPtr);

            return ffxiv.ReadBytes(log_ent, log_current - log_ent);

        }
        /// <summary>
        /// ログカウントを取得します
        /// </summary>
        /// <returns></returns>
        public int GetLogCount()
        {
            return ffxiv.ReadInt32(LogCountPtr); 
        }

        public int LastLogCount
        {
            get;
            private set;
        }

        /// <summary>
        /// 新しいログデータを取得する
        /// </summary>
        /// <returns></returns>
        public byte[][] GetNewLogsData()
        {
            int log_count = ffxiv.ReadInt32(LogCountPtr); 
            int log_index = ffxiv.ReadInt32(LogIndexPtr);
            int log_ent = ffxiv.ReadInt32(LogEntPtr);
            int log_current = ffxiv.ReadInt32(LogCurrentPtr);
            if (LastLogCount == 0)
            {
                LastLogCount = log_count;
                return GetLogsData();
            }

            List<byte[]> res = new List<byte[]>();
            int[] indexies = GetIndexies();

            for (int i = LastLogCount + 1; i <= log_count; i++)
            {
                int log_countr = i % 1000;
                if (log_countr == 0) log_countr = 1000;


                int last = 0;
                if (log_countr > 1)
                    last = indexies[log_countr - 2];

                res.Add(ffxiv.ReadBytes(log_ent + last, indexies[log_countr-1] - last));
            }
            //foreach (byte[] a in res)
            //{
            //    System.Diagnostics.Debug.WriteLine(Encoding.GetEncoding("utf-8").GetString(a));
            //}
            LastLogCount = log_count;
            return res.ToArray();
        }

        /// <summary>
        /// インデックス
        /// </summary>
        /// <returns></returns>
        public int[] GetIndexies()
        {
            int[] res = new int[1000];
            int log_index = ffxiv.ReadInt32(LogIndexPtr);
            byte[] indexdata = ffxiv.ReadBytes(log_index, 1000 * 0x04);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(indexdata);
            System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = br.ReadInt32();
            }
            return res;
        }


        public byte[][] GetLogsData()
        {
            int log_count = ffxiv.ReadInt32(LogCountPtr);// System.Diagnostics.Debug.WriteLine("cnt:"+ log_count.ToString("D4"));
            int log_countr = log_count%1000;
            if (log_countr == 0) log_countr = 1000;

            int log_index = ffxiv.ReadInt32(LogIndexPtr);
            int log_ent = ffxiv.ReadInt32( LogEntPtr);
            int log_current = ffxiv.ReadInt32(LogCurrentPtr);

            byte[] indexdata = ffxiv.ReadBytes(log_index, 1000 * 0x04);

            System.IO.MemoryStream ms = new System.IO.MemoryStream(indexdata);
            System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
            ms.Position = (log_countr - 1 ) * 0x04;
            int logdata_size = br.ReadInt32();
            ms.Position = 0;

            byte[] logdata = ffxiv.ReadBytes(log_ent, logdata_size);
            System.IO.MemoryStream ms2 = new System.IO.MemoryStream(logdata);

            int last = 0;
            List<byte[]> res = new List<byte[]>();
            for (int i = 0; i < log_countr; i++)
            {
                int index = br.ReadInt32();
                byte[] dat = new byte[index-last];
                ms2.Read(dat, 0, index - last);
                res.Add(dat);
                last = index;
            }
            return res.ToArray();
        }

        /// <summary>
        /// FFXIVLogMemoryInfoを作成します。
        /// </summary>
        /// <returns></returns>
        public static FFXIVLogMemoryInfo Create()
        {
            try
            {
                System.Diagnostics.Process proc = System.Diagnostics.Process.GetProcessesByName("ffxiv")[0];
                return new FFXIVLogMemoryInfo(proc);
            }
            catch
            {
                return null;
            }
        }
    }
}
