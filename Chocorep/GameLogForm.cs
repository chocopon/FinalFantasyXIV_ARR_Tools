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
    public partial class GameLogForm : Form
    {
        FFXIVLogDataSet _dataset;

        public GameLogForm()
        {
            InitializeComponent();
        }

        private void GameLogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void 閉じるXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameLogForm_FormClosing(this, null);
        }

        private void GameLogForm_Load(object sender, EventArgs e)
        {

        }

        public void SetData(FFXIVLogDataSet ds)
        {
            _dataset = ds;
            bindingSource1.DataSource = _dataset;
            bindingSource1.DataMember = "Anaylzed";
        }

        private void ファイルからインポートToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FF14FastReport.OpenGameLogFolderForm frm = new FF14FastReport.OpenGameLogFolderForm();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                FFXIVLogFileReader fr = new FFXIVLogFileReader(frm.SelectedFolder);
              FF14LogParser actionReport = new FF14LogParser();

                foreach (FFXIVLog log in fr.GetLogs())
                {
                    actionReport.Add(log);
                }
                bindingSource1.DataSource = actionReport.ds;
                bindingSource1.DataMember = "Anaylzed";
            }

        }

        private void 更新UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _dataset;
            bindingSource1.DataMember = "Anaylzed";
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FF14LogParser actionReport = new FF14LogParser();
                    actionReport.Read(openFileDialog1.FileName);
                    bindingSource1.DataSource = actionReport.ds;
                    bindingSource1.DataMember = "Anaylzed";
                }
                catch (Exception _e)
                {
                    MessageBox.Show(_e.Message);
                }
            }
        }

        /// <summary>
        /// CSVファイルを作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cSVファイルを作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog diag = new SaveFileDialog();
                diag.DefaultExt = "*.csv";
                diag.FileName = "ffxivlog.csv";
                if (diag.ShowDialog(this) == DialogResult.OK)
                {
                    CSVWriter.ConvertDataTableToCsv(((FFXIVLogDataSet)bindingSource1.DataSource).Anaylzed, diag.FileName, true);
                }
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }
    }
}
