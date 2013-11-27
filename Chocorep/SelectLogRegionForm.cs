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
    public partial class SelectLogRegionForm : Form
    {
        public event EventHandler OKButtonPushed;

        public int StartID
        {
            get;
            private set;
        }

        public int EndID
        {
            get;
            private set;
        }


        public SelectLogRegionForm()
        {
            InitializeComponent();
        }

        public void SetData(FFXIVLogDataSet dataset)
        {
            this.ffxivLogDataSet1 = dataset;
            string member = bindingSource1.DataMember;
            bindingSource1.DataSource = dataset;
            bindingSource1.DataMember = member;
            bindingSource2.DataSource = dataset;
            bindingSource2.DataMember = member;

            if (ffxivLogDataSet1.Anaylzed.Count > 0)
            {
                label1.Text = String.Format("{0} - {1}", ffxivLogDataSet1.Anaylzed[0].LocalTime,
                    ffxivLogDataSet1.Anaylzed[ffxivLogDataSet1.Anaylzed.Count - 1].LocalTime.ToString("MM/dd HH:mm:ss"));
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;
            }


            UpdateFilter1();
            UpdateFilter2();
        }

        private void SelectLogRegionForm_Load(object sender, EventArgs e)
        {
            UpdateFilter1();
            UpdateFilter2();

        }

        private void UpdateFilter1()
        {
            string filter = GetFilter();
            bindingSource1.Filter = filter;
        }


        private void UpdateFilter2()
        {
            string filter = GetFilter2();
            bindingSource2.Filter = filter;
        }


        private string GetFilter()
        {
            List<string>filterList = new List<string>();
            if(AllLogBox.Checked)
            {
                return "";
            }
            if(IDStartEndBox.Checked)
            {
                filterList.Add("IsContentStart = True or IsContentEnd = true");
            }
            if (SystemEventBox.Checked)
            {
                filterList.Add(String.Format("FLAG_INFO = {0}", (int)LOG_CATEGORY_TYPE.SYSTEM_EVENT));
            }
            if (GameEventBox.Checked)
            {
                filterList.Add(String.Format("(FLAG_INFO = {0} and FLAG_NUM = {1})", (int)LOG_CATEGORY_TYPE.GAME_EVENT, (int)LOG_GAME_EVENT_TYPE.EVENT));
            }
            if (BattleLogBox.Checked)
            {
                filterList.Add(String.Format("FLAG_INFO = {0}", (int)LOG_CATEGORY_TYPE.BATTLE));
            }
            return string.Join(" OR ", filterList.ToArray());
        }

        private string GetFilter2()
        {
            List<string> filterList = new List<string>();
            if (AllLogBox2.Checked)
            {
                return "";
            }
            if (IDStartEndBox2.Checked)
            {
                filterList.Add("IsContentStart = True or IsContentEnd = true");
            }
            if (SystemEventBox2.Checked)
            {
                filterList.Add(String.Format("FLAG_INFO = {0}", (int)LOG_CATEGORY_TYPE.SYSTEM_EVENT));
            }
            if (GameEventBox2.Checked)
            {
                filterList.Add(String.Format("(FLAG_INFO = {0} and FLAG_NUM = {1})", (int)LOG_CATEGORY_TYPE.GAME_EVENT, (int)LOG_GAME_EVENT_TYPE.EVENT));
            }
            if (BattleLogBox2.Checked)
            {
                filterList.Add(String.Format("FLAG_INFO = {0}", (int)LOG_CATEGORY_TYPE.BATTLE));
            }
            return string.Join(" OR ", filterList.ToArray());
        }

        private void IDStartEndBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilter1();
        }
        private void IDStartEndBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilter2();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int index = (int)dataGridView2.SelectedCells[0].OwningRow.Cells["iDDataGridViewTextBoxColumn2"].Value;
                textBox2.Text = index.ToString();
                EndID = index;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)//iDDataGridViewTextBoxColumn1
            {
                int index = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["iDDataGridViewTextBoxColumn1"].Value;
                textBox1.Text = index.ToString();
                StartID = index;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (OKButtonPushed != null)
            {
                OKButtonPushed(this, null);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            OKButton_Click(this, null);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OKButton_Click(this, null);
        }

        private void SelectLogRegionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}
