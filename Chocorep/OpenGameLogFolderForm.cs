using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.IO;
using FFXIV_Tools;
namespace FF14FastReport
{
    public partial class OpenGameLogFolderForm : Form
    {
        FFXIVUserFolder Userfolder;

        public OpenGameLogFolderForm()
        {
            InitializeComponent();
        }

        private void OpenGameLogFolderForm_Load(object sender, EventArgs e)
        {
            UpdateLogFoldersInfo();

            CancelButton.Select();
        }

        private void UpdateLogFoldersInfo()
        {
            Userfolder = new FFXIVUserFolder(FFXIVUserFolder.DefaultUserFolderPath);
            CharacterFolder[] chFolders = Userfolder.GetCharacterFolders();
            fF14FastReportDataSet.CharactorFolder.Clear();
            foreach (CharacterFolder cf in chFolders)
            {
                fF14FastReportDataSet.CharactorFolder.AddCharactorFolderRow(cf.FolderName, cf.FolderFullPath, cf.CharacterName, cf.ServerName, cf.LastLoginTimeFromLogFile, cf.LastPlayTimeFromLogFile);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SelectedFolder = dataGridView1.SelectedRows[0].Cells["fullPathDataGridViewTextBoxColumn"].Value.ToString() + "\\log";
                this.textBox1.Text = SelectedFolder;
                this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
            }
        }
        string _selectedFolder;
        public string SelectedFolder
        {
            get
            {
                return _selectedFolder;
            }
            private set
            {
                _selectedFolder = value;
                if (Directory.Exists(_selectedFolder))
                {
                    OKButton.Enabled = true;
                }
                else
                {
                    OKButton.Enabled = false;
                }
            }
        }


        private void OtherFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if (dig.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SelectedFolder = dig.SelectedPath;
                this.textBox1.Text = SelectedFolder;
                this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(!Directory.Exists(textBox1.Text))
            {
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            SelectedFolder = textBox1.Text;
        }

    }
}
