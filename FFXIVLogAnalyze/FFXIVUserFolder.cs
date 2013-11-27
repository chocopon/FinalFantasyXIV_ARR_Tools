using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FFXIV_Tools
{
    public class FFXIVUserFolder
    {
        #region statics
        //const string FF14UserFolderName = "FINAL FANTASY XIV - A Realm Reborn (Beta Version)";
        const string FF14UserFolderName = "FINAL FANTASY XIV - A Realm Reborn";

        /// <summary>
        /// 規定のFFXIV ユーザフォルダ
        /// </summary>
        public static string DefaultUserFolderPath
        {
            get
            {
                string mydoc = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.None);
                return System.IO.Path.Combine(mydoc, "My Games", FF14UserFolderName);
            }
        }
        #endregion

        /// <summary>
        /// スクリーンショットフォルダ
        /// </summary>
        public string ScreenshotsFolder
        {
            get
            {
                return Path.Combine(UserFolderPath, "screenshots");
            }
        }

        /// <summary>
        /// ユーザーフォルダパス
        /// </summary>
        public string UserFolderPath
        {
            get;
            set;
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="path"></param>
        public FFXIVUserFolder(string path)
        {
            UserFolderPath = path;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FFXIVUserFolder()
            : this(DefaultUserFolderPath)
        {
        }

        /// <summary>
        /// キャラクターフォルダを取得する
        /// </summary>
        /// <returns></returns>
        public CharacterFolder[] GetCharacterFolders()
        {
            List<CharacterFolder> chList = new List<CharacterFolder>();
            if (Directory.Exists(UserFolderPath))
            {
                string[] folders = Directory.GetDirectories(UserFolderPath);
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\\FFXIV_CHR[0-9A-F]{16}$");


                foreach (string folder in folders)
                {
                    if (regex.IsMatch(folder.ToUpper()))
                    {
                        chList.Add(CharacterFolder.Create(folder));
                    }
                }
            }
            return chList.ToArray();
        }
    }

    public class CharacterFolder
    {
        /// <summary>
        /// フォルダ一覧
        /// </summary>
        List<string> Dirs = new List<string>();
        /// <summary>
        /// ファイル一覧
        /// </summary>
        List<string> Files = new List<string>();
        /// <summary>
        /// ログファイル一覧
        /// </summary>
        List<string> LogFiles = new List<string>();

        #region プロパティ

        /// <summary>
        /// フォルダ名
        /// </summary>
        public string FolderName
        {
            get;
            set;
        }
        /// <summary>
        /// フォルダフルパス
        /// </summary>
        public string FolderFullPath
        {
            get;
            set;
        }

        /// <summary>
        /// ログフォルダパス
        /// </summary>
        public string logFolderPath
        {
            get
            {
                if (FolderFullPath!=""&& Directory.Exists(FolderFullPath))
                {
                    return Path.Combine(FolderFullPath, "log");
                }
                return "";
            }
        }
        /// <summary>
        /// キャラ名
        /// </summary>
        public string CharacterName
        {
            get;
            set;
        }
        /// <summary>
        /// サーバー名
        /// </summary>
        public string ServerName
        {
            get;
            set;
        }
        /// <summary>
        /// ログファイルが最後に記入された時間
        /// </summary>
        public DateTime LastLogFileWrite
        {
            get;
            set;
        }

        /// <summary>
        /// 最後にログインした時間をログファイル取得
        /// </summary>
        public DateTime LastLoginTimeFromLogFile
        {
            get;
            set;
        }

        /// <summary>
        /// 最後にプレイした時間をログファイルから取得
        /// </summary>
        public DateTime LastPlayTimeFromLogFile
        {
            get;
            set;
        }
        #endregion

        /// <summary>
        /// ログファイル名を取得する
        /// </summary>
        /// <param name="index">ファイル番号, 0～</param>
        /// <returns></returns>
        public string GetLogFilePath(int index)
        {
            string logfileName = String.Format("{0,0:X8}.log", index);//00000000.log
            return Path.Combine(logFolderPath, logfileName);
        }

        /// <summary>
        /// 最後のログファイルを取得する
        /// </summary>
        /// <returns></returns>
        public string GeLastWriteLogFile()
        {
            string lastfile = "";
            DateTime lastWrite = DateTime.MinValue;
            foreach (string logfile in LogFiles)
            {
                DateTime writeTime = File.GetLastWriteTime(logfile);
                if (writeTime > lastWrite)
                {
                    lastWrite = writeTime;
                    lastfile = logfile;
                }
            }
            return lastfile;
        }

        /// <summary>
        /// 更新する
        /// </summary>
        public void Update()
        {
            Dirs.Clear();
            Files.Clear();
            LogFiles.Clear();

            Dirs.AddRange(Directory.GetDirectories(FolderFullPath));
            Files.AddRange(Directory.GetDirectories(FolderFullPath));
            if (Directory.Exists(logFolderPath) && File.Exists(GetLogFilePath(0)))
            {
                LogFiles.AddRange(Directory.GetFiles(logFolderPath));
                LogFiles.Sort();
                string firstLogFile = GetLogFilePath(0);
                string lastLogFile = GeLastWriteLogFile();

                FFXIVLog[] f_logs =  FFXIVLogFileReader.GetLogsFromFile(firstLogFile);
                FFXIVLog[] l_logs = FFXIVLogFileReader.GetLogsFromFile(lastLogFile);
                //最後にログインした時間をログから設定
                LastLoginTimeFromLogFile = f_logs[0].TimeStampServerTime.Add(new TimeSpan(9, 0, 0));//ログファイルの時間はGMTなので＋９時間
                //最後にプレイした時間をログから設定
                LastPlayTimeFromLogFile = l_logs[l_logs.Length-1].TimeStampServerTime.Add(new TimeSpan(9, 0, 0));
                //サーバー名
                for (int i = 0; i < 999; i++)
                {
                    if (f_logs[i].LogBody.StartsWith(":Welcome to "))
                    {
                        ServerName = f_logs[0].LogBody.Substring(":Welcome to ".Length).Replace(" !", "");
                        break;
                    }
                }
                //キャラ名取得
                FF14LogParser ar = new FF14LogParser();
                foreach (FFXIVLog log in f_logs)
                {
                    ar.Add(log);
                    FFXIVLogDataSet.ActorRow[] arows = (FFXIVLogDataSet.ActorRow[])ar.ds.Actor.Select("IsMe = True");
                    if (arows.Length > 0)
                    {
                        CharacterName = arows[0].Name;
                        break;
                    }
                }
                if (CharacterName == "")
                {
                    foreach (FFXIVLog log in l_logs)
                    {
                        ar.Add(log);
                        FFXIVLogDataSet.ActorRow[] arows = (FFXIVLogDataSet.ActorRow[])ar.ds.Actor.Select("IsMe = True");
                        if (arows.Length > 0)
                        {
                            CharacterName = arows[0].Name;
                            break;
                        }
                    }
                }


            }
        }

        /// <summary>
        /// CharacterFolderを作成する
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static CharacterFolder Create(string folderPath)
        {
            CharacterFolder cf = new CharacterFolder();
            cf.FolderFullPath = folderPath;
            cf.FolderName = Path.GetFileName(folderPath);
            cf.Update();
            return cf;
        }


    }
}
