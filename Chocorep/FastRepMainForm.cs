using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FFXIV_Tools;

namespace FF14FastReport
{
    public partial class FastRepMainForm : Form
    {
        FastReportForm frepForm;
        FF14LogParser actionreport;

        RankingForm rf;

        public FastRepMainForm()
        {
            InitializeComponent();

            actionreport = new FF14LogParser();
            frepForm = new FastReportForm();
            rf = new RankingForm();

            bindingSource2.DataSource = actionreport.ds;
        }

        private void FastRepMainForm_Load(object sender, EventArgs e)
        {
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (frepForm == null || frepForm.IsDisposed)
            {
                frepForm = new FastReportForm();
            }

            frepForm.Show();
            frepForm.Activate();
        }


        /// <summary>
        /// ログが追加された
        /// </summary>
        /// <param name="log"></param>
        private void LogAdded(FFXIVLog log)
        {
            rf.AddLog(log);
            //arf.AddLog(log);
        }

        private void LoadDemoData()
        {
            FFXIVLogFileReader fr = new FFXIVLogFileReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log"));
            demoLogs = fr.GetLogs();
            demoIndex = 0;
            lastSeconds = demoLogs[0].TotalSeconds;

            //foreach (FFXIVLog log in demoLogs)
            //{
            //    actionreport.Add(log);
            //}
            timer1.Start();
        }

        FFXIVLog[] demoLogs;
        int demoIndex;
        int lastSeconds;

        private void DemoButton_Click(object sender, EventArgs e)
        {
            LoadDemoData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           int start = Convert.ToInt32(StartIDTextBox.Text);
           if (demoIndex < start)
           {
               demoIndex = start;
           }
            while (demoIndex < demoLogs.Length && demoLogs[demoIndex].TotalSeconds < lastSeconds)
            {
                
                LogAdded(demoLogs[demoIndex++]);
            }
            if (demoIndex + 1 < demoLogs.Length)
            {
                lastSeconds = Math.Max(demoLogs[demoIndex].TotalSeconds, ++lastSeconds);
            }
            else
            {
                lastSeconds++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            rf.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.FontSizeNumericUpDown.Value = (int)rf.GridViewFontSize;
            AutoSizeHeightBox.Checked = rf.AutoSizeHeight;
            AutoSizeWidthBox.Checked = rf.AutoSizeWidth;
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            rf.GridViewFontSize = (float)FontSizeNumericUpDown.Value;
            rf.AutoSizeHeight = AutoSizeHeightBox.Checked;
            rf.AutoSizeWidth = AutoSizeWidthBox.Checked;
        }

        private void MouseTransButton_Click(object sender, EventArgs e)
        {
            RankingForm rf_m = null;
            if (!rf.IsTransMouse)
            {
                rf_m = new RankingForm_m();
            }
            else
            {
                rf_m = new RankingForm();
            }

            rf_m.report = rf.report;
            rf_m.Size = rf.Size;
            rf_m.GridViewFontSize = rf.GridViewFontSize;
            rf_m.AutoSizeHeight = rf.AutoSizeHeight;
            rf_m.AutoSizeWidth = rf.AutoSizeWidth;
            rf_m.Show();
            rf_m.Location = rf.Location;
            rf.Close();
            rf = rf_m;
        }

        private void ActionReportButton_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// フォントサイズが変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            rf.Reset();
        }

    }
}
