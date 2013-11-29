using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FFXIV_Tools;

namespace FFXIVLogWindow
{
    public partial class FFXIVLogWindowForm : Form
    {
        string soundfolderpath
        {
            get
            {
                return System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sounds");
            }
        }

        public FFXIVLogWindowForm()
        {
            InitializeComponent();
        }

        private void FFXIVLogWindowForm_Load(object sender, EventArgs e)
        {
            InitializeAlarm();
        }


        /// <summary>
        /// アラーム設定を初期化する
        /// </summary>
        private void InitializeAlarm()
        {
            if (Properties.Settings.Default.Alarm1Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm1Setting);
                AlarmBox1.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm2Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm2Setting);
                AlarmBox2.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm3Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm3Setting);
                AlarmBox3.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm4Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm4Setting);
                AlarmBox4.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm5Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm5Setting);
                AlarmBox5.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm6Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm6Setting);
                AlarmBox6.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm7Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm7Setting);
                AlarmBox7.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm8Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm8Setting);
                AlarmBox8.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm9Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm9Setting);
                AlarmBox9.Text = settings.Name;
            }
            if (Properties.Settings.Default.Alarm10Setting != "")
            {
                AlarmSetting settings = AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm10Setting);
                AlarmBox10.Text = settings.Name;
            }
        }

        /// <summary>
        /// ログを1行追加する
        /// </summary>
        /// <param name="log"></param>
        private void AddLog(FFXIVLog log)
        {
            LogBodyBox.SelectionColor = GetColorFromLog(log);
            Font baseFont = LogBodyBox.SelectionFont;
            Font fnt = new Font(baseFont.FontFamily,
                baseFont.Size,
                baseFont.Style | FontStyle.Bold);

            //Fontを変更する
            LogBodyBox.SelectionFont = fnt;
            //文字列を挿入する
            LogBodyBox.SelectedText = String.Format("[{0}]{1}:{2}\r\n", log.TimeStampServerTime.ToString("MM/dd HH:mm:ss"), log.LogTypeHexString, log.LogBodyReplaceTabCode);

            baseFont.Dispose();
            fnt.Dispose();

        }

        /// <summary>
        /// ゲームクライアントが保存したログファイルの読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fFXIVで保存されたログからインポートIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenLogFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FFXIVLogFileReader filereader = new FFXIVLogFileReader(OpenLogFolderBrowserDialog.SelectedPath);
                int count = 0;
                foreach (FFXIVLog log in filereader.GetLogs())
                {
                    if(IsVisibleLog(log))
                    {
                        AddLog(log);
                    }

                    count++;
                    if (count > 1000)
                        break;
                }
            }
        }

        /// <summary>
        /// 表示するログか
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private bool IsVisibleLog(FFXIVLog log)
        {
            if (log.LogTypeHexString == "0018" && FCBox.Checked)//fc
            {
                return true;
            }
            else if (log.LogTypeHexString == "000B" && ShoutBox.Checked)//shout
            {
                return true;
            }
            else if (log.LogTypeHexString == "000C" && YellBox.Checked)//yell
            {
                return true;
            }
            else if (log.LogTypeHexString == "000E" && PartyBox.Checked)//Party
            {
                return true;
            }
            else if (log.LogTypeHexString == "000B" && ShoutBox.Checked)//shout
            {
                return true;
            }
            else if (log.LogTypeHexString == "0010" && LS1Box.Checked) //LS1
            {
                return true;
            }
            else if (log.LogTypeHexString == "0011" && LS2Box.Checked) //LS2
            {
                return true;
            }
            else if (log.LogTypeHexString == "0012" && LS3Box.Checked) //LS3
            {
                return true;
            }
            else if (log.LogTypeHexString == "0013" && LS4Box.Checked) //LS4
            {
                return true;
            }
            else if (log.LogTypeHexString == "0014" && LS5Box.Checked) //LS5
            {
                return true;
            }
            else if (log.LogTypeHexString == "0015" && LS6Box.Checked) //LS6
            {
                return true;
            }
            else if (log.LogTypeHexString == "0016" && LS7Box.Checked) //LS7
            {
                return true;
            }
            else if (log.LogTypeHexString == "0017" && LS8Box.Checked) //LS8
            {
                return true;
            }
            return false;

        }



        /// <summary>
        /// ログの種類からログカラーを取得します
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private Color GetColorFromLog(FFXIVLog log)
        {
            if (log.LogTypeHexString == "0018")//fc
            {
                return Color.LightGreen;
            }
            else if (log.LogTypeHexString =="000B")//shout
            {
                return Color.DarkOrange;
            }
            else if (log.LogTypeHexString == "000C")//yell
            {
                return Color.Orange;
            }
            else if (log.LogTypeHexString == "000E")//Party
            {
                return Color.LightSeaGreen;
            }
            else if (log.LogTypeHexString == "0010" || //LS
                log.LogTypeHexString == "0011" ||
                log.LogTypeHexString == "0012" ||
                log.LogTypeHexString == "0013" ||
                log.LogTypeHexString == "0014" ||
                log.LogTypeHexString == "0015" ||
                log.LogTypeHexString == "0016" ||
                log.LogTypeHexString == "0017")
            {
                return Color.Green;
            }
            //デフォルトはホワイトスモーク
            return Color.WhiteSmoke;

        }

        private void AlarmBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AlarmBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AlarmBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditAlarm1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if(Properties.Settings.Default.Alarm1Setting !="")
            {               
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm1Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm1Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }
        }

        private void EditAlarm2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm2Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm2Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm2Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm3Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm3Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm3Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm4Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm4Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm4Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm5Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm5Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm5Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm6Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm6Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm6Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm7Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm7Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm7Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm8Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm8Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm8Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }

        }

        private void EditAlarm9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm9Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm9Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm9Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }
        }

        private void EditAlarm10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlarmSettingForm asform = new AlarmSettingForm();
            if (Properties.Settings.Default.Alarm10Setting != "")
            {
                asform.LoadAlarmSettings(AlarmSetting.LoadSettingXml(Properties.Settings.Default.Alarm10Setting));
            }
            if (asform.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Alarm10Setting = asform.GetAlarmSettings().GetSettingXml();
                InitializeAlarm();
            }
        }

        private void FFXIVLogWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void 実行中のゲームからインポートLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
