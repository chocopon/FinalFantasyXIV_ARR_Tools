using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using FFXIV_Tools;
namespace FF14FastReport
{
    public partial class CompactForm : Form
    {
        /// <summary>
        /// DPSをリアルタイムで表示するフォーム
        /// </summary>
        RankingForm rankingForm = new RankingForm();

        /// <summary>
        /// Repを表示するフォーム
        /// </summary>
        AnalyzeForm analyzeForm = new AnalyzeForm();

        /// <summary>
        /// ログを表示するフォーム
        /// </summary>
        GameLogForm gameLogForm = new GameLogForm();

        /// <summary>
        /// ログフォルダ
        /// </summary>
        public string LogFolder
        {
            get
            {
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
            }
        }

        /// <summary>
        /// ログカウント
        /// </summary>
        int LogCount = 0;


        /// <summary>
        /// ログメモリインフォ
        /// </summary>
        FFXIVLogMemoryInfo logmemoryInfo;

        /// <summary>
        /// アクションレポート
        /// </summary>
        FF14LogParser actionReport;

        public CompactForm()
        {
            InitializeComponent();
            rankingForm.AutoSizeChanged += new EventHandler(rankingForm_AutoSizeChanged);
            rankingForm.MouseTransModeChanged += new EventHandler(rankingForm_MouseTransModeChanged);
            actionReport = new FF14LogParser();
            SetFormActionReport();
        }

        /// <summary>
        /// フォームにデータをDatSetを設定する
        /// </summary>
        private void SetFormActionReport()
        {
 
            if (this.InvokeRequired)
            {
                Invoke((Action)(() =>
                {
                    analyzeForm.SetActionReport(actionReport);
                    gameLogForm.SetData(actionReport.ds);
                }));
            }
            else
            {
                analyzeForm.SetActionReport(actionReport);
                gameLogForm.SetData(actionReport.ds);
            }

        }

        /// <summary>
        /// マウス透過モードが変更された（透過になった）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rankingForm_MouseTransModeChanged(object sender, EventArgs e)
        {
            rankingForm.MouseTransModeChanged -= new EventHandler(rankingForm_MouseTransModeChanged);
            TransMouseBox.Checked = true;
        }

        /// <summary>
        /// 自動調整がフォームで変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void rankingForm_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// StatusLabelにテキスト設定します
        /// </summary>
        /// <param name="text"></param>
        private void SetStatus(string text)
        {
            if (this.InvokeRequired)
            {
                if (this.Disposing || this.IsDisposed)
                {
                    return;
                }
                Invoke((Action)(() => toolStripStatusLabel2.Text = text));
            }
            else
            {
                toolStripStatusLabel2.Text = text;
            }
        }

        /// <summary>
        /// StatusLabelにテキスト設定します
        /// </summary>
        /// <param name="text"></param>
        private void SetLogCount()
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)(() => LogCountLabel.Text = "[log]" + actionReport.ds.Anaylzed.Count.ToString()));
            }
            else
            {
                LogCountLabel.Text = "[log]"+ actionReport.ds.Anaylzed.Count.ToString();
            }
        }

        private void SetText(Control ctrl, string text)
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)(() => ctrl.Text = text));
            }
            else
            {
                ctrl.Text = text;
            }
        }

        /// <summary>
        /// プログレスを設定
        /// </summary>
        /// <param name="val"></param>
        /// <param name="visible"></param>
        private void SetProgress(int val, bool visible)
        {
            if (this.InvokeRequired)
            {
                Invoke((Action)(() => { toolStripProgressBar1.Visible = visible; toolStripProgressBar1.Value = val; }));
            }
            else
            {
                toolStripProgressBar1.Visible = visible; toolStripProgressBar1.Value = val; 
            }
        }

        private void CompactForm_Load(object sender, EventArgs e)
        {
            //バージョン情報
            SetVersionInfo();

            //ログフォルダ
            if (!System.IO.Directory.Exists(LogFolder))
            {
                System.IO.Directory.CreateDirectory(LogFolder);
            }

            LoadSettings();

            //
            SetStatus("ログの探索を開始します。１０秒～２０秒掛かります。");

            SearchLogInfoBGWorker.RunWorkerAsync();
            rankingForm.Show();
        }

        /// <summary>
        /// 設定情報を読み込む
        /// </summary>
        private void LoadSettings()
        {
            rankingForm.AutoSizeHeight = Properties.Settings.Default.AutoSizeHeight;
            rankingForm.AutoSizeWidth = Properties.Settings.Default.AutoSizeWidth;
            rankingForm.ViewLog = Properties.Settings.Default.ViewLog;
            rankingForm.ViewPTMember = Properties.Settings.Default.ViewPTMember;
            rankingForm.ViewEnemy = Properties.Settings.Default.ViewEnemy;
            rankingForm.Location = Properties.Settings.Default.RankingFormPosition;
            rankingForm.GridViewFontSize = (float)numericUpDown1.Value;
        }

        /// <summary>
        /// 設定情報の保存
        /// </summary>
        private void SaveSettings()
        {
            Properties.Settings.Default.AutoSizeHeight = rankingForm.AutoSizeHeight;
            Properties.Settings.Default.AutoSizeWidth = rankingForm.AutoSizeWidth;
            Properties.Settings.Default.ViewLog = rankingForm.ViewLog;
            Properties.Settings.Default.ViewPTMember = rankingForm.ViewPTMember;
            Properties.Settings.Default.ViewEnemy = rankingForm.ViewEnemy;
            Properties.Settings.Default.RankingFormPosition = rankingForm.Location;

            Properties.Settings.Default.Save();
        }


        private void SaveLog()
        {
            if (actionReport.ds.Anaylzed.Count > 0)
            {
                string logfile = System.IO.Path.Combine(LogFolder, actionReport.ds.Anaylzed[0].LocalTime.ToString("yyyyMMddHHmmss") + ".gzip");
                actionReport.Write(logfile);
            }
        }

        private void InitializeData()
        {
            LogCount = 0;//カウントを0にする

            int logcount = logmemoryInfo.GetLogCount();

            FF14LogParser _actionReport = new FF14LogParser();


            if (logcount > 1000)
            {//ファイルからよまないとね

                SetStatus("ログファイルからデータを読み込んでいます。0/"+logcount +"行");

                FFXIVUserFolder userfolder = new FFXIVUserFolder();
                CharacterFolder playnow = null;
                foreach(CharacterFolder cf in userfolder.GetCharacterFolders())
                {
                    if(playnow==null)playnow =cf;
                    if (cf.LastPlayTimeFromLogFile > playnow.LastPlayTimeFromLogFile)
                    {
                        playnow = cf;
                    }
                }
                List<FFXIVLog> LogsFromFile = new List<FFXIVLog>();
                logcount = logmemoryInfo.GetLogCount();
                if (playnow.LastPlayTimeFromLogFile > FFXIVLog.StartDateTime)
                {
                    int filenum = 0;
                    while(filenum < logmemoryInfo.GetLogCount()/1000)
                    {
                        foreach (FFXIVLog log in FFXIVLogFileReader.GetLogsFromFile(playnow.GetLogFilePath(filenum)))
                        {
                            _actionReport.Add(log);
                        }
                        filenum++;
                        SetStatus("ログファイルからデータを読み込んでいます。"+filenum+"000/" + logcount + "行");
                    }
                }
                SetStatus("メモリからログを読み込んでいます。");
                foreach (byte[] data in logmemoryInfo.GetNewLogsData())
                {
                    _actionReport.Add(FFXIVLog.ParseSingleLog(data));
                }
            }
            actionReport = _actionReport;
            SetFormActionReport();
            SetLogCount();
            //rankingForm.report.SetActionReport(actionReport);
        }

        /// <summary>
        /// ProgramFiles(x86)
        /// </summary>
        /// <returns></returns>
        private string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            }

            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

        #region VersionInfo
        private void SetVersionInfo()
        {
            // C#
            // バージョン名（AssemblyInformationalVersion属性）を取得
            string appVersion = Application.ProductVersion;
            // 製品名（AssemblyProduct属性）を取得
            string appProductName = Application.ProductName;
            // 会社名（AssemblyCompany属性）を取得
            string appCompanyName = Application.CompanyName;

            // C#
            Assembly mainAssembly = Assembly.GetEntryAssembly();

            // コピーライト情報を取得
            string appCopyright = "-";
            object[] CopyrightArray =
              mainAssembly.GetCustomAttributes(
                typeof(AssemblyCopyrightAttribute), false);
            if ((CopyrightArray != null) && (CopyrightArray.Length > 0))
            {
                appCopyright =
                  ((AssemblyCopyrightAttribute)CopyrightArray[0]).Copyright;
            }

            // 詳細情報を取得
            string appDescription = "-";
            object[] DescriptionArray =
              mainAssembly.GetCustomAttributes(
                typeof(AssemblyDescriptionAttribute), false);
            if ((DescriptionArray != null) && (DescriptionArray.Length > 0))
            {
                appDescription =
                  ((AssemblyDescriptionAttribute)DescriptionArray[0]).Description;
            }

            // C#
            // アプリケーション・アイコンを取得
            Icon appIcon;
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hSuccess = SHGetFileInfo(
              mainAssembly.Location, 0,
              ref shinfo, (uint)Marshal.SizeOf(shinfo),
              SHGFI_ICON | SHGFI_LARGEICON);
            if (hSuccess != IntPtr.Zero)
            {
                appIcon = Icon.FromHandle(shinfo.hIcon);
            }
            else
            {
                appIcon = SystemIcons.Application;
            }



            //セット
            pictureBox1.Image = appIcon.ToBitmap();
            Text = appProductName;
            ProductNameVersionLabel.Text = appProductName + " " + appVersion;
            CopyrightLabel.Text = appCopyright;

        }
        // SHGetFileInfo関数
        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        // SHGetFileInfo関数で使用するフラグ
        private const uint SHGFI_ICON = 0x100; // アイコン・リソースの取得
        private const uint SHGFI_LARGEICON = 0x0; // 大きいアイコン
        private const uint SHGFI_SMALLICON = 0x1; // 小さいアイコン

        // SHGetFileInfo関数で使用する構造体
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        #endregion

        /// <summary>
        /// DPSウィンドウ表示ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewDPSWindowButton_Click(object sender, EventArgs e)
        {
            rankingForm.Show();
        }

        /// <summary>
        /// マウス透過BOXが変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransMouseBox_CheckedChanged(object sender, EventArgs e)
        {
            RankingForm rf_m = null;
            if (TransMouseBox.Checked)
            {//透過する
                rf_m = new RankingForm_m();
            }
            else
            {//透過しない
                rf_m = new RankingForm();
            }
            //コピー
            rf_m.report = rankingForm.report;
            rf_m.Size = rankingForm.Size;
            rf_m.GridViewFontSize = rankingForm.GridViewFontSize;
            rf_m.AutoSizeHeight = rankingForm.AutoSizeHeight;
            rf_m.AutoSizeWidth = rankingForm.AutoSizeWidth;
            //PT、ログ、エネミー 2013.09.05
            rf_m.ViewPTMember = rankingForm.ViewPTMember;
            rf_m.ViewEnemy = rankingForm.ViewEnemy;
            rf_m.ViewLog = rankingForm.ViewLog;
            //end modified

            rf_m.AutoSizeChanged += new EventHandler(rankingForm_AutoSizeChanged);
            rf_m.MouseTransModeChanged += new EventHandler(rankingForm_MouseTransModeChanged);


            rf_m.Show();
            rf_m.Location = rankingForm.Location;
            rankingForm.Close();
            rankingForm = rf_m;
        }

        /// <summary>
        /// フォントサイズが変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rankingForm.GridViewFontSize = (float)numericUpDown1.Value;
        }

        /// <summary>
        /// 左上に移動させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ESCButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"DPSウィンドウを画面左上に移動します。","ウィンドウの移動", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
            {
            rankingForm.Location = new Point(0, 0);
            }
        }


        private void LogReadIntervalTimer_Tick(object sender, EventArgs e)
        {
            LogReadIntervalTimer.Stop();
            try
            {
                foreach (byte[] logdata in logmemoryInfo.GetNewLogsData())
                {
                    FFXIVLog log = FFXIVLog.ParseSingleLog(logdata);
                    rankingForm.AddLog(log);
                    //actionreport
                    FFXIVLogDataSet.AnaylzedRow arow = actionReport.Add(log);
                    CheckReset(arow);
                }
                if (LogCount < actionReport.ds.Anaylzed.Count - 100)
                {
                    LogCount = actionReport.ds.Anaylzed.Count;
                    if (AutoSaveCheckBox.Checked)
                    {
                        SaveLog();
                    }
                }
                SetLogCount();
                LogReadIntervalTimer.Start();
            }
            catch(Exception _e)
            {              
                logmemoryInfo = null;
                SearchLogInfoBGWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// データをリセットするか
        /// </summary>
        /// <param name="arow"></param>
        private void CheckReset(FFXIVLogDataSet.AnaylzedRow arow)
        {
            if (ResetID_Box.Checked)
            {
                //インスタンスダンジョン
                if (arow.IsContentStart)
                {
                    button1_Click(this, null);
                    SetStatus(String.Format("「{0}」が開始されました。DPSをリセットしました。", arow.ContentName));
                }
            }
            if (FFXIVLog.GetLOG_TYPE(arow.ActionType) == LOG_CATEGORY_TYPE.GAME_EVENT)
            {
                if (arow.Body.Contains("封鎖まで") && ResetClose_Box.Checked)
                {
                    button1_Click(this, null);
                    SetStatus(String.Format("「{0}」 DPSをリセットしました。", arow.Body));
                }
                if (arow.IsLevelSyncStart && ResetLevelSync_Box.Checked)
                    button1_Click(this, null);
                if (arow.Body.Contains("チェンジした") && ResetClose_Box.Checked)
                {
                    SetStatus(String.Format("「{0}」 DPSをリセットしました。", arow.Body));
                    button1_Click(this, null);
                }
            }
        }


        /// <summary>
        /// 解析フォーム
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAnalyzeWindowButton_Click(object sender, EventArgs e)
        {
            analyzeForm.UpdateData();
            analyzeForm.Show();
            analyzeForm.Activate();
        }

        private void GameLogButton_Click(object sender, EventArgs e)
        {
            gameLogForm.Show();
            gameLogForm.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rankingForm.Reset();
        }

        private void CompactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (SearchLogInfoBGWorker.IsBusy)
                {
                    SearchLogInfoBGWorker.CancelAsync();
                }
                LogReadIntervalTimer.Stop();
                
                SaveSettings();
                if (AutoSaveCheckBox.Checked)
                {
                    SaveLog();
                }
            }
            catch(Exception _e)
            {
                MessageBox.Show("ログファイルの保存に失敗しました。" + _e.Message);
            }
        }

        private void StopStartButton_Click(object sender, EventArgs e)
        {
            if (SearchLogInfoBGWorker.IsBusy)
            {
                SearchLogInfoBGWorker.CancelAsync();
            }
            else
            {
                SearchLogInfoBGWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// サーチする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchLogInfoBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (logmemoryInfo == null && !SearchLogInfoBGWorker.CancellationPending)
            {
                logmemoryInfo = FFXIVLogMemoryInfo.Create();
                if (logmemoryInfo == null)
                {
                    SetStatus(String.Format("ffxiv.exeの起動を確認します。"));
                    SetProgress(0, false);
                    for (int i = 10; i >= 0 && !SearchLogInfoBGWorker.CancellationPending; i--)
                    {
                        System.Threading.Thread.Sleep(1000);//10秒停止
                        SetStatus(String.Format("ffxiv.exe 起動再確認まで...{0}", i));
                    }
                    continue;
                }
                SetStatus("キャラクターのログインを確認しています･･･");
                SetProgress(0, false);
                bool success = false;
                System.Threading.ThreadStart action = () =>
                {
                    success = logmemoryInfo.SearchLogMemoryInfo();
                };
                System.Threading.Thread th = new System.Threading.Thread(action);
                th.Start();
                while (th.IsAlive)
                {
                    if (SearchLogInfoBGWorker.CancellationPending)
                    {//キャンセルされた
                        SetStatus("停止中");
                        logmemoryInfo.CancelSearching();
                        th.Join();
                        logmemoryInfo = null;
                        SetProgress(0, false);
                        return;
                    }
                    SetProgress(logmemoryInfo.Progress, true);
                    System.Threading.Thread.Sleep(100);
                }

                SetProgress(0, false);
                //ログのサーチに成功したか
                if (!success)
                {
                    logmemoryInfo = null;
                    for (int i = 10; i >= 0 && !SearchLogInfoBGWorker.CancellationPending; i--)
                    {
                        System.Threading.Thread.Sleep(1000);//10秒停止
                        SetStatus(String.Format("キャラクターのログイン再確認まで...{0}", i));
                    }
                }
                else
                {
                    InitializeData();
                }
            }
        }

        /// <summary>
        /// プログレス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchLogInfoBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        /// <summary>
        /// 完了もしくはキャンセル
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchLogInfoBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (logmemoryInfo == null)
            {
                SetStatus("キャンセルしました。");
                SetText(StopStartButton, "開始");
            }
            else
            {
                SetStatus("DPSを表示します。");
                LogReadIntervalTimer.Start();
            }
        }


    }
}
