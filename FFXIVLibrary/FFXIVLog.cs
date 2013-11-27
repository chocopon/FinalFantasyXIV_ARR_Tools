using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace FFXIV_Tools
{
    public class FFXIVLog
    {
        public static DateTime StartDateTime = new DateTime(1970,1,1);

        //タブコード書式
        static Regex tabcodeRegex = new Regex(@"\{02[0-9A-F]+03\}", RegexOptions.Compiled);

        /// <summary>
        /// ログ分割のための正規表現（index情報が見つかればいらないんだがなー）
        /// </summary>
        static System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[0-9A-F]{12}:");

        public int ID
        {
            get;
            set;
        }

        public int TotalSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// 生データのタイムスタンプ16進数
        /// </summary>
        public string TimstampHexString
        {
            get;
            set;
        }
        /// <summary>
        /// ログのタイプ16進数
        /// </summary>
        public string LogTypeHexString
        {
            get;
            set;
        }

        /// <summary>
        /// アクションタイプ番号 A9(169):ダメージを与えた
        /// </summary>
        public int ActionType
        {
            get
            {
                string hex = LogTypeHexString.Substring(2, 2);
                return Convert.ToInt32(hex, 16);
            }
        }

        /// <summary>
        /// 誰から誰のタイプ:Ex.09(9):PTメンバーからPTメンバー
        /// </summary>
        public int LogType
        {
            get
            {
                string hex = LogTypeHexString.Substring(0, 2);
                return Convert.ToInt32(hex, 16);
            }
        }


        /// <summary>
        /// ログの本文
        /// </summary>
        public string LogBody
        {
            get;
            set;
        }

        /// <summary>
        /// ログ本文からタブコードを空文字でリプレースしたもの
        /// </summary>
        public string LogBodyReplaceTabCode
        {
            get;
            set;
        }

        /// <summary>
        /// サーバータイム
        /// </summary>
        public DateTime TimeStampServerTime
        {
            get;
            set;
        }

        /// <summary>
        /// ログ生データ
        /// </summary>
        public byte[] Raw
        {
            get;
            set;
        }


        /// <summary>
        /// タブコードをエスケープしたデータを取得します。
        /// </summary>
        /// <returns></returns>
        public byte[] EscapeTabcode()
        {
            return FFXIVLog.EscapeTabData(Raw);
        }


        /// <summary>
        /// ログを取得する
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static FFXIVLog[] Parse(byte[] data)
        {
            List<FFXIVLog> loglist = new List<FFXIVLog>();
            foreach (byte[] _dat in ParseLogData(data))
            {
                FFXIVLog log = ParseSingleLog(_dat);
                loglist.Add(log);
            }
            return loglist.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static FFXIVLog ParseSingleLog(byte[] data)
        {
            string str = GetFF14String(data);

            int secs = Convert.ToInt32(str.Substring(0, 8),16);
            DateTime timestamp = StartDateTime.AddSeconds(secs);

            FFXIVLog log = new FFXIVLog();
            log.TotalSeconds = secs;
            log.TimstampHexString = str.Substring(0, 8);
            log.TimeStampServerTime = timestamp;
            log.LogTypeHexString = str.Substring(8, 4);
            log.LogBody = str.Substring(13);
            log.LogBodyReplaceTabCode = tabcodeRegex.Replace(log.LogBody, "");
            log.Raw = data;

            return log;
        }

        /// <summary>
        /// 内容からログを生成する
        /// </summary>
        /// <param name="totalseconds"></param>
        /// <param name="logtype"></param>
        /// <param name="actiontype"></param>
        /// <param name="logbody"></param>
        /// <returns></returns>
        public static FFXIVLog CreateLog(int totalseconds,int logtype, int actiontype,string logbody)
        {
            DateTime timestamp = StartDateTime.AddSeconds(totalseconds);

            FFXIVLog log = new FFXIVLog();
            log.TotalSeconds = totalseconds;
            log.TimstampHexString = totalseconds.ToString("X").PadLeft(8,'0');
            log.TimeStampServerTime = timestamp;
            log.LogTypeHexString = logtype.ToString("X").PadLeft(2, '0') + actiontype.ToString("X").PadLeft(2, '0');
            log.LogBody = logbody;
            log.LogBodyReplaceTabCode = tabcodeRegex.Replace(log.LogBody, "");
            //log.Raw = data;

            return log;
        }

        /// <summary>
        /// 時間からログの経過秒数を取得する
        /// </summary>
        /// <param name="datetime"></param>
        public static int GetTotalSecond(DateTime datetime, bool JST)
        {
            if (JST)
            {
                DateTime time = datetime.AddHours(-9);
                return (int)(time - StartDateTime).TotalSeconds;
            }
            else
            {
                return (int)(datetime - StartDateTime).TotalSeconds;
            }
        }


        /// <summary>
        /// ゲーム画面で表示される形に近いStringを取得する
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string GetFF14String(byte[] data)
        {
            byte[] a = new byte[] { 0xEE, 0x81, 0xAF };//EE81AFは3バイトの特殊文字 リプレースすることで表示可能
            byte[] buff = FFXIVLog.EscapeTabData(data);
            return Encoding.GetEncoding("utf-8").GetString(buff).Replace(Encoding.GetEncoding("utf-8").GetString(a), "⇒");
        }


        /// <summary>
        /// 02 ・・・03のパターンのbyteデータを{02・・・03}に変換
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] EscapeTabData(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            bool flg = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (flg)
                {
                    if (data[i] == 0x03)
                    {
                        byte[] d = Encoding.ASCII.GetBytes("03}");
                        ms.Write(d, 0, d.Length);
                        flg = false;
                    }
                    else
                    {
                        byte[] d = Encoding.ASCII.GetBytes(data[i].ToString("X2"));
                        ms.Write(d, 0, d.Length);
                    }
                }
                else if (data[i] == 0x02)
                {
                    byte[] d = Encoding.ASCII.GetBytes("{02");
                    ms.Write(d, 0, d.Length);
                    flg = true;
                }
                else
                {
                    ms.WriteByte(data[i]);
                }
            }
            return ms.ToArray();
        }


        /// <summary>
        /// 一行ごとのログ(バイナリ）に分割する
        /// </summary>
        /// <param name="LogData"></param>
        /// <returns></returns>
        public static byte[][] ParseLogData(byte[] LogData)
        {

            MemoryStream ms = new MemoryStream(LogData);
            byte[] buffer =new byte[LogData.Length];
            LogData.CopyTo(buffer, 0);



            for (int i = 0; i < LogData.Length; i++)
            {
                if (LogData[i] < 0x20 || LogData[i] > 0x7e)
                {
                    buffer[i] = 0x20;//スペースに返還
                }
            }

            string str = regex.Replace(Encoding.ASCII.GetString(buffer),"\n$0");
            str = str.TrimStart('\r').TrimStart('\n');
            string[] strs = str.Split(new string[] { "\n" }, StringSplitOptions.None);

            List<byte[]> byteList = new List<byte[]>();

            for (int i = 0; i < strs.Length; i++)
            {
                byte[] newbyte = new byte[strs[i].Length];
                ms.Read(newbyte, 0, newbyte.Length);
                byteList.Add(newbyte);
            }

            return byteList.ToArray();
        }

        #region フラグ

        public LOG_CATEGORY_WHO WHO
        {
            get
            {
                return GetCATEGORY_WHO(LogType);
            }
        }

        public LOG_CATEGORY_TO TO
        {
            get
            {
                return GetCATEGORY_TO(LogType);
            }
        }

        public LOG_CATEGORY_TARGET_STATUS TARGET_STATUS
        {
            get
            {
                return GetTARGET_STATUS(ActionType);
            }
        }

        public LOG_CATEGORY_TYPE LOG_TYPE
        {
            get
            {
                return GetLOG_TYPE(ActionType);
            }
        }

        public LOG_CATEGORY_UNKNOWN_FLG UNKNOWN_FLG
        {
            get
            {
                return GetUNKNOWN_FLG(ActionType);
            }

        }

        public LOG_BATTLE_TYPE BATTLE_TYPE
        {
            get
            {
                return GetBATTLE_TYPE(ActionType);
            }
        }

        public LOG_GAME_EVENT_TYPE GAME_EVENT_TYPE
        {
            get
            {
                return GetGAME_EVENT_TYPE(ActionType);
            }
        }

        public LOG_SYSTEM_EVENT_TYPE SYSTEM_EVENT_TYPE
        {
            get
            {
                return GetSYSTEM_EVENT_TYPE(ActionType);
            }
        }

        public static LOG_CATEGORY_WHO GetCATEGORY_WHO(int LogType)
        {
            return (LOG_CATEGORY_WHO)(LogType >> 2);
        }

        public static LOG_CATEGORY_TO GetCATEGORY_TO(int LogType)
        {
            return (LOG_CATEGORY_TO)(LogType & 3);
        }

        public static LOG_CATEGORY_TARGET_STATUS GetTARGET_STATUS(int ActionType)
        {
            return (LOG_CATEGORY_TARGET_STATUS)((ActionType>>7)& 0x1);
        }

        public static LOG_CATEGORY_TYPE GetLOG_TYPE(int ActionType)
        {
            int a = (ActionType >> 4);
            a = a & 0x7;
                return (LOG_CATEGORY_TYPE)((ActionType >> 4) & 0x7);
        }

        public static LOG_CATEGORY_UNKNOWN_FLG GetUNKNOWN_FLG(int ActionType)
        {
            return (LOG_CATEGORY_UNKNOWN_FLG)((ActionType >> 3) & 1);
        }

        public static LOG_BATTLE_TYPE GetBATTLE_TYPE(int ActionType)
        {
            return (LOG_BATTLE_TYPE)(ActionType & 0x7);
        }

        public static LOG_GAME_EVENT_TYPE GetGAME_EVENT_TYPE(int ActionType)
        {
            return (LOG_GAME_EVENT_TYPE)(ActionType  & 0x7);
        }

        public static LOG_SYSTEM_EVENT_TYPE GetSYSTEM_EVENT_TYPE(int ActionType)
        {
            return (LOG_SYSTEM_EVENT_TYPE)(ActionType & 0x7);
        }

        #endregion



        public override string ToString()
        {
            return String.Format("{0}[{1}]{2}",ID,TimeStampServerTime.ToLocalTime().ToString("HH:mm:ss"),LogBodyReplaceTabCode);
        }
    }

    #region フラグ


    //[who 6][to 2] [stat1][info3][?1][num 3]
    /// <summary>
    /// ログカテゴリWHO
    /// </summary>
    public enum LOG_CATEGORY_WHO
    {
        SYSTEM,
        MYSELF,
        PTMEMBER,
        ALLY,
        OTHER,
        ENEMY,
        NPC
    }

    /// <summary>
    /// ログカテゴリTO
    /// </summary>
    public enum LOG_CATEGORY_TO
    {
        EMPTY_OR_ME,
        PTMEMBER,
        ENEMY,
        OTHER
    }
    /// <summary>
    /// ログカテゴリTargetStatus
    /// </summary>
    public enum LOG_CATEGORY_TARGET_STATUS
    {
        NORMAL,
        FIGHTING
    }

    /// <summary>
    /// ログのカテゴリ
    /// </summary>
    public enum LOG_CATEGORY_TYPE
    {
        UNKNOWN1,
        UNKNOWN2,
        BATTLE,
        GAME_EVENT,
        SYSTEM_EVENT
    }

    /// <summary>
    /// 戦闘ログのタイプ
    /// </summary>
    public enum LOG_BATTLE_TYPE
    {
        UNKNOWN,
        HIT,
        MISS,
        DONE,
        ITEM,
        HEAL,
        EFFECT1,
        EFFECT2
    }

    public enum LOG_GAME_EVENT_TYPE
    {
        UNKNOWN,//38
        EVENT,//39
        DOWN_KO,//3A
        UNKNOWN2,//3B
        ATTENTION,//3C
        UNKOWN3,//3D
        GETITEM,//3E
        UNKNOWN4//3F

    }

    public enum LOG_SYSTEM_EVENT_TYPE
    {
        EXP,//40
        DICE,//41
        UNKNOWN1,//42
        UNKNOWN2,//43
        UNKNOWN3,//44
        LOGIN_LOGOUT,//45
    }

public enum LOG_CATEGORY_UNKNOWN_FLG
{
    ZERO,
    ONE
}

    #endregion
}
