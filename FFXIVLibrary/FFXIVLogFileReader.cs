using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace FFXIV_Tools
{
    /// <summary>
    /// 新生FF14 ログファイルリーダー
    /// </summary>
    public class FFXIVLogFileReader
    {
        /// <summary>
        /// ログフォルダのパス　/log
        /// </summary>
        public string FolderPath;

        /// <summary>
        /// ログファイルリーダー
        /// </summary>
        /// <param name="path">ログフォルダのパス .../log</param>
        public FFXIVLogFileReader(string path)
        {
            FolderPath = path;
        }

        /// <summary>
        /// ログを読みこむ
        /// </summary>
        /// <returns></returns>
        public FFXIVLog[] GetLogs()
        {
            List<FFXIVLog> loglist = new List<FFXIVLog>();

            int i = 0;
            //00000015
            string logfile = Path.Combine(FolderPath, i.ToString("X8") + ".log");
            while (File.Exists(logfile))
            {
                FFXIVLog[] logs = FFXIVLogFileReader.GetLogsFromFile(logfile);
                if (loglist.Count > 0 && logs[0].TimeStampServerTime < loglist[loglist.Count - 1].TimeStampServerTime)
                {
                    break;
                }
                loglist.AddRange(logs);
                i++;
                logfile = Path.Combine(FolderPath, i.ToString("X8") + ".log");

            }
            return loglist.ToArray();
        }


        /// <summary>
        /// ログファイルからログを取得する
        /// </summary>
        /// <param name="logfile"></param>
        /// <returns></returns>
        public static FFXIVLog[] GetLogsFromFile(string logfile)
        {

            byte[] buffer = File.ReadAllBytes(logfile);
            MemoryStream ms = new MemoryStream(buffer);

            BinaryReader br = new BinaryReader(ms);

            int lastCount = br.ReadInt32();
            int currentCount = br.ReadInt32();
            int length = currentCount - lastCount;

            FFXIVLog[] logs = new FFXIVLog[length];

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = br.ReadInt32();
            }

            int lastptr =0;

            int j =0;
            foreach (int ptr in array)
            {
                byte[] data = br.ReadBytes(ptr - lastptr);
                logs[j++] = FFXIVLog.ParseSingleLog(data);
                lastptr = ptr;
            }

            return logs;
        }
    }
}
