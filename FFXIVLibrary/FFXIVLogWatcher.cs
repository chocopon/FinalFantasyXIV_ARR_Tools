using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFXIV_Tools
{
    public class FFXIVLogWatcher
    {
        System.Threading.ThreadStart ts;
        System.Threading.Thread th;
        FFXIVLogMemoryInfo ffxivLogMemoryInfo;

        public event LogEventHandler LogEvent;

        /// ログが取得できなかったときの再トライまでのインターバル秒
        /// </summary>
        public double RetryIntervalSec
        {
            get;
            set;
        }
        /// <summary>
        /// ログ取得のインターバル秒　最小0.5秒
        /// </summary>
        public double LogReadIntervalSec
        {
            get;
            set;
        }
        /// <summary>
        /// 実行中か
        /// </summary>
        public bool Enable
        {
            get;
            set;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FFXIVLogWatcher()
        {
            ts = new System.Threading.ThreadStart(ReadThread);

            Enable = false;
            LogReadIntervalSec = 1.0;
            RetryIntervalSec = 5.0;
        }

        /// <summary>
        /// ログ読み取りを開始します。
        /// </summary>
        public void Start()
        {
            Enable = true;
            th = new System.Threading.Thread(ts);
            th.Start();
        }

        /// <summary>
        /// ログ読み取りを停止します。
        /// </summary>
        public void Stop()
        {
            Enable = false;
            while (th != null && th.IsAlive)
            {
                System.Threading.Thread.Sleep(1);
            }
        }


        /// <summary>
        /// ログを反復して読み込みます
        /// </summary>
        private void ReadThread()
        {
            while (Enable)
            {
                try
                {
                    if (ffxivLogMemoryInfo == null)
                    {//ログ位置のサーチから
                        ffxivLogMemoryInfo = FFXIVLogMemoryInfo.Create();
                        continue;
                    }
                    byte[][] newlogsdata = ffxivLogMemoryInfo.GetNewLogsData();
                    FFXIVLog[] newLogs = new FFXIVLog[newlogsdata.Length];
                    for (int i = 0; i < newLogs.Length; i++)
                    {
                        newLogs[i] = FFXIVLog.ParseSingleLog(newlogsdata[i]);
                    }

                    LogEventArgs e = new LogEventArgs();
                    e.IsSuccess = true;
                    e.LogCount = newLogs.Length;
                    e.NewLogsData = newlogsdata;
                    e.NewLogs = newLogs;
                    if (LogEvent != null)
                    {
                        LogEvent(this, e);
                    }
                    System.Threading.Thread.Sleep((int)(LogReadIntervalSec * 1000));
                }
                catch
                {
                    LogEventArgs e = new LogEventArgs();
                    e.IsSuccess = false;
                    if (LogEvent != null)
                    {
                        LogEvent(this, e);
                    }
                    System.Threading.Thread.Sleep((int)(RetryIntervalSec * 1000));
                }
            }
        }
    }

    public delegate void LogEventHandler(object sender, LogEventArgs e);

    /// <summary>
    /// ログイベントArgs
    /// </summary>
    public class LogEventArgs:EventArgs
    {
        public bool IsSuccess{
            get;
            set;
        }

        public int LogCount{
            get;
            set;
        }
        public FFXIVLog[] NewLogs{
            get;
            set;
        }
        public byte[][] NewLogsData
        {
            get;
            set;
        }
    }

}
