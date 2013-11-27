using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LogManipulate;

namespace FFXIVLogWindow
{
    public partial class FFXIVLogWindowForm : Form
    {
        public FFXIVLogWindowForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fFXIVで保存されたログからインポートIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenLogFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FFXIVLogFileReader filereader = new FFXIVLogFileReader(OpenLogFolderBrowserDialog.SelectedPath);
                int count = 0;
                foreach (FFXIVLog log in filereader.GetLogs())
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

                    count++;
                    if (count > 1000)
                        break;
                }
            }
        }

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
            return Color.WhiteSmoke;

        }
    }
}
