using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FFXIV_Tools;

using System.IO;

namespace Infoman
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer mp = new WMPLib.WindowsMediaPlayer(); /* WMP */

        SinTitan titan;

        InfoForm infoform = new InfoForm();

        string soundFile = "";
       
        public string SoundFolderPath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "sounds");
            }
        }

        /// <summary>
        /// ランドスライドの音源
        /// </summary>
        public string SoundFile_Landslide
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.LandslideSoundFile);
            }
        }
        /// <summary>
        /// 激震の音源
        /// </summary>
        public string SoundFile_Gekishin
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.GekishinSoundFile);
            }
        }

        /// <summary>
        /// 大地の重みの音源
        /// </summary>
        public string SoundFile_Omomi
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.OmomiSoundFile);
            }
        }

        /// <summary>
        /// ボムボルダーの音源
        /// </summary>
        public string SoundFile_Bomb
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.BombSoundFile);
            }
        }

        /// <summary>
        /// グラナイトジェイルの音源
        /// </summary>
        public string SoundFile_Jail
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.JailSoundFile);
            }
        }

        /// <summary>
        /// マウンテンバスターの音源
        /// </summary>
        public string SoundFile_Mountain
        {
            get
            {
                return Path.Combine(SoundFolderPath, Properties.Settings.Default.MountainSoundFile);
            }
        }





        public Form1()
        {
            InitializeComponent();
            titan = infoform.titan;

            mp.settings.autoStart = false; /* 音源パスを設定したときに自動再生するか */
            mp.StatusChange +=new WMPLib._WMPOCXEvents_StatusChangeEventHandler(mp_StatusChange);

            if (!Directory.Exists(SoundFolderPath))
            {
                Directory.CreateDirectory(SoundFolderPath);
            }

        }


        void  mp_StatusChange()
        {
            if (mp.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                mp.close();
            }
        }   

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                StartButton.Enabled = false;
                backgroundWorker1.CancelAsync();
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                StartButton.Text = "停止";
            }

        }

        private void SetText(string text)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() => { label1.Text = text; }));
            }
            else
            {
                label1.Text = text;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                FFXIVLogMemoryInfo memoryinfo = FFXIVLogMemoryInfo.Create();
                if (memoryinfo == null)
                {
                    SetText("FF14が起動されていません");

                }
                else
                {
                    SetText("ログの確認中");

                    bool success = false;
                    System.Threading.ThreadStart action = () =>
                    {
                        success = memoryinfo.SearchLogMemoryInfo();
                    };
                    System.Threading.Thread th = new System.Threading.Thread(action);
                    th.Start();
                    for (int i = 0; th.IsAlive && i < 3000; i++)
                    {
                        if (backgroundWorker1.CancellationPending)
                        {//キャンセルされた
                            SetText("停止中");
                            memoryinfo.CancelSearching();
                            th.Join();
                            memoryinfo = null;
                            return;
                        }
                        SetText("ログの確認中_" + memoryinfo.Progress);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                    if (success)
                    {
                        SetText("ログを確認しました。");
                        memoryinfo.GetNewLogsData();//既存のログを捨てる
                        infoform.IsRunning = true;
                        while (memoryinfo != null && !backgroundWorker1.CancellationPending)
                        {
                            try
                            {
                                foreach (byte[] data in memoryinfo.GetNewLogsData())
                                {
                                    FFXIVLog log = FFXIVLog.ParseSingleLog(data);

                                    string preaction = titan.NextAction;
                                    titan.PhaseUpdate(log.LogBody, log.TotalSeconds);
                                    if (titan.NextAction != preaction)
                                    {//アクションが更新された
                                       PlaySound(titan.NextAction);
                                    }
                                }
                                System.Threading.Thread.Sleep(500);
                            }
                            catch
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        SetText("ログを確認できません。");
                        memoryinfo = null;
                    }
                }
                infoform.IsRunning = false;
                System.Threading.Thread.Sleep(5000);
            }
        }


        private void PlaySound(string action)
        {
            //return;//debug
            switch (action)
            {
                case "ランドスライド":
                    PlayLandslide();
                    break;
                case "激震":
                    PlayGekishin();
                    break;
                case "大地の重み":
                    PlayOmomi();
                    break;
                case "ボムボルダー":
                    PlayBomb();
                    break;
                case "グラナイト・ジェイル":
                    PlayJail();
                    break;
                case "マウンテンバスター":
                    PlayMountain();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add(":タイタンは「ジオクラッシュ」の構え。");
            comboBox1.Items.Add(":タイタンは「ランドスライド」の構え。");
            comboBox1.Items.Add(":タイタンの「激震」");
            comboBox1.Items.Add(":タイタンは「大地の重み」の構え。");
            comboBox1.Items.Add(":タイタンは大地を叩き、ボムボルダーを落とした！");
            comboBox1.Items.Add(":タイタンの「グラナイト・ジェイル」");
            comboBox1.Items.Add(":タイタンの「岩神の心石」が切れた。");
            comboBox1.Items.Add(":タイタンの「マウンテンバスター」");



            SoundLandslideBox.Items.Add("");
            SoundGekishinBox.Items.Add("");
            SoundOmomiBox.Items.Add("");
            SoundBombBox.Items.Add("");
            SoundJailBox.Items.Add("");
            SoundMountain.Items.Add("");

            foreach (string file in Directory.GetFiles(SoundFolderPath))
            {
                SoundLandslideBox.Items.Add(Path.GetFileName(file));
                SoundGekishinBox.Items.Add(Path.GetFileName(file));
                SoundOmomiBox.Items.Add(Path.GetFileName(file));
                SoundBombBox.Items.Add(Path.GetFileName(file));
                SoundJailBox.Items.Add(Path.GetFileName(file));
                SoundMountain.Items.Add(Path.GetFileName(file));

            }


            label2.Text = titan.NextAction;
            label3.Text = titan.NextNextAction;
            label4.Text = titan.PhaseNumber.ToString();

            infoform.Show();

            StartButton_Click(this, null);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            titan.actionIndex = 0;
            titan.PhaseNumber = 1;

            label2.Text = titan.NextAction;
            label3.Text = titan.NextNextAction;
            label4.Text = titan.PhaseNumber.ToString();

            infoform.UpdateInfos();
            infoform.Write();

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            string pre = titan.NextAction;
            titan.PhaseUpdate(comboBox1.Text, 0);
            if (titan.NextAction != pre)
            {
                PlaySound(titan.NextAction);
            }
            label2.Text = titan.NextAction;
            label3.Text = titan.NextNextAction;
            label4.Text = titan.PhaseNumber.ToString();
            infoform.UpdateInfos();
            infoform.Write();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartButton.Text = "開始";
            StartButton.Enabled = true;
        }

        private void PlayButton1_Click(object sender, EventArgs e)
        {
            PlayLandslide();
        }

        private void StopSound()
        {
            mp.controls.stop();
        }

        private void PlayLandslide()
        {
            if (File.Exists(SoundFile_Landslide))
            {
                soundFile = SoundFile_Landslide;
                Play();
            }
        }

        private void PlayGekishin()
        {
            if (File.Exists(SoundFile_Gekishin))
            {
                soundFile = SoundFile_Gekishin;
                Play();
            }
        }
        private void PlayOmomi()
        {
            if (File.Exists(SoundFile_Omomi))
            {
                soundFile = SoundFile_Omomi;
                Play();
            }
        }
        private void PlayBomb()
        {
            if (File.Exists(SoundFile_Bomb))
            {
                soundFile = SoundFile_Bomb;
                Play();
            }
        }

        private void PlayJail()
        {
            if (File.Exists(SoundFile_Jail))
            {
                soundFile = SoundFile_Jail;
                Play();
            }
        }

        private void PlayMountain()
        {
            if (File.Exists(SoundFile_Mountain))
            {
                soundFile = SoundFile_Mountain;
                Play();
            }
        }

        private void PlayButton2_Click(object sender, EventArgs e)
        {
            PlayGekishin();
        }

        private void PlayButton3_Click(object sender, EventArgs e)
        {
            PlayOmomi();
        }

        private void PlayButton4_Click(object sender, EventArgs e)
        {
            PlayBomb();
        }

        private void PlayButton5_Click(object sender, EventArgs e)
        {
            PlayJail();
        }

        private void PlayButton6_Click(object sender, EventArgs e)
        {
            PlayMountain();
        }

        private void SoundStopButton_Click(object sender, EventArgs e)
        {
            mp.controls.stop();
        }

        private void SoundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void SounbVolumeBar_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void Play()
        {
            if (File.Exists(soundFile))
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)(() =>
                    {
                        mp.settings.volume = 10 * SounbVolumeBar.Value;
                        mp.URL = soundFile;
                        mp.controls.play();
                    }));
                }
                else
                {
                    mp.settings.volume = 10 * SounbVolumeBar.Value;
                    mp.URL = soundFile;
                    mp.controls.play();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
