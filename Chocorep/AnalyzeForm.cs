using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FFXIV_Tools
{
    public partial class AnalyzeForm : Form
    {
        FF14FastReport.SelectLogRegionForm slrf = new FF14FastReport.SelectLogRegionForm();

        public TreeElementA Tree
        {
            get;
            private set;
        }

        FF14LogParser InnerActionReport;

        public FF14LogParser actionReport
        {
            get
            {
                return InnerActionReport;
            }
            private set
            {
                InnerActionReport = value;
                slrf.SetData(actionReport.ds);
            }
        }

        FF14LogParser _processActionReport;

        PivotA pivot;


        public AnalyzeForm()
        {
            InitializeComponent();

            slrf.OKButtonPushed += new EventHandler(slrf_OKButtonPushed);
        }

        void slrf_OKButtonPushed(object sender, EventArgs e)
        {
            string filter = String.Format("ID >= {0} and ID <= {1}", slrf.StartID, slrf.EndID);
            PivotA pivot = new PivotA((FFXIVLogDataSet.AnaylzedRow[])actionReport.ds.Anaylzed.Select(filter));
            SetStatus("データを分類しています。");
            System.Threading.ThreadStart ts = () =>
            {
                pivot.UpdateTree();
                pivot.Calc();

                pivot.Tree.SortByTotal(false);
                SortNames(pivot.Tree);
            };
            System.Threading.Thread th = new System.Threading.Thread(ts);
            th.Start();
            while (th.IsAlive)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
            SetStatus("完了");
            this.dataGridView1.Rows.Clear();
            this.LoadTree(pivot.Tree);
        }

        private void SetStatus(string text)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => toolStripStatusLabel1.Text = text));
            }
            else
            {
                toolStripStatusLabel1.Text = text;
            }
        }

        private void SetProgress(int val, bool visible)
        {
            if (InvokeRequired)
            {
                Invoke((Action)(() => { toolStripProgressBar1.Visible = visible; toolStripProgressBar1.Value = val; }));
            }
            else
            {
                toolStripProgressBar1.Visible = visible; toolStripProgressBar1.Value = val; 
            }
        }

        private void AnalyzeForm_Load(object sender, EventArgs e)
        {
            string logfolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"log");
            if (Directory.Exists(logfolder))
            {
                folderBrowserDialog1.SelectedPath = logfolder;
            }
            else
            {
                folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory;
            }
        }

        public void SetActionReport(FF14LogParser ar)
        {
            actionReport = ar;
            _processActionReport = actionReport;
            pivot = new PivotA((FFXIVLogDataSet.AnaylzedRow[]) ar.ds.Anaylzed.Select());
        }

        public void UpdateData()
        {
            pivot.UpdateTree();
            pivot.Calc();

            pivot.Tree.SortByTotal(false);
            SortNames(pivot.Tree);
            dataGridView1.Rows.Clear();
            LoadTree(pivot.Tree);
        }


        /// <summary>
        /// 表示順
        /// </summary>
        /// <param name="tree"></param>
        private void SortNames(TreeElementA tree)
        {
            List<string> res = new List<string>();
            List<string> me = new List<string>();
            List<string> pet_me = new List<string>();
            List<string> pt = new List<string>();
            List<string> pet_pt = new List<string>();
            List<string> other = new List<string>();
            List<string> unknown = new List<string>();
            List<string> npc = new List<string>();

            foreach (TreeElementA a in tree.ChildElements)
            {
                FFXIVLogDataSet.ActorRow arow = actionReport.ds.Actor.FindByName(a.Text);
                if (arow == null)
                {
                    unknown.Add(a.Text);
                }
                else if (arow.IsMe)
                {
                    me.Add(a.Text);
                }
                else if (arow.IsMyPet)
                {
                    pet_me.Add(a.Text);
                }
                else if (arow.IsPTMember)
                {
                    pt.Add(a.Text);
                }
                else if (arow.IsPTPet)
                {
                    pet_pt.Add(a.Text);
                }
                else if (arow.IsNPC)
                {
                    npc.Add(a.Text);
                }
                else
                {
                    other.Add(a.Text);
                }
            }
            res.AddRange(me);
            res.AddRange(pet_me);
            res.AddRange(pt);
            res.AddRange(pet_pt);
            res.AddRange(npc);
            res.AddRange(other);
            res.AddRange(unknown);

            tree.SortByName(res.ToArray());

        }



        /// <summary>
        /// ツリーを読み込む
        /// </summary>
        /// <param name="tree"></param>
        public void LoadTree(TreeElementA tree)
        {
            this.Tree = tree;

            foreach (TreeElementA element in Tree.ChildElements)
            {
                string text = element.Text;
                int depth = element.Depth;

                int a = dataGridView1.Rows.Add(CreateNewRow(element));//order  open 行ラベル
                DataGridViewPlusMinusCell pmc = (DataGridViewPlusMinusCell)dataGridView1.Rows[a].Cells[2];
                pmc.IsPlus = true;
            }
            UpdateDataGridView();
        }

        private DataGridViewRow CreateNewRow(TreeElementA element)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1,new object[] { 0, false, element, element.report.TotalDamage,element.report.Hit,element.report.Count, element.report.HitRate,element.report.Average,element.report.Dps,element.report.TotalCure ,element.report.DotValue,element.report.CritHit,element.report.CritHitRate});
            return row;                
        }

        private void UpdateDataGridView()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewPlusMinusCell pmc = (DataGridViewPlusMinusCell)row.Cells[2];
                pmc.Indent = Math.Max(0, ((TreeElementA)pmc.Value).Depth - 1);
                pmc.ViewPlusMinusButton = ((TreeElementA)pmc.Value).ChildElements.Count > 0;
            }
        }


        /// <summary>
        /// セルクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row != null)
            {
                DataGridViewPlusMinusCell pmc = (DataGridViewPlusMinusCell)row.Cells[2];
                TreeElementA tree = ((TreeElementA)pmc.Value);
                if (pmc.IsPlus)
                {//展開
                    pmc.IsPlus = false;

                    for (int i = tree.ChildElements.Count - 1; i >= 0; i--)
                    {
                        TreeElementA element = tree.ChildElements[i];

                        string text = element.Text;
                        int depth = element.Depth;

                        dataGridView1.Rows.Insert(e.RowIndex + 1,CreateNewRow(element));//order  open 行ラベル
                        DataGridViewPlusMinusCell _pmc = (DataGridViewPlusMinusCell)dataGridView1.Rows[e.RowIndex + 1].Cells[2];
                        _pmc.IsPlus = true;

                    }
                    UpdateDataGridView();
                }
                else//閉じる
                {
                    pmc.IsPlus = true;
                    DataGridViewPlusMinusCell _pmc = (DataGridViewPlusMinusCell)dataGridView1.Rows[e.RowIndex + 1].Cells[2];
                    TreeElementA element = (TreeElementA)_pmc.Value;

                    while (element.Depth > tree.Depth)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex + 1);
                        if (e.RowIndex + 1 < dataGridView1.Rows.Count)
                        {
                            _pmc = (DataGridViewPlusMinusCell)dataGridView1.Rows[e.RowIndex + 1].Cells[2];
                            element = (TreeElementA)_pmc.Value;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void AnalyzeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e != null)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void 閉じるXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyzeForm_FormClosing(this, null);
        }

        private void 更新するUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionReport = _processActionReport;
            UpdateData();
        }

        private void データ範囲指定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            slrf.Show();
            slrf.Activate();
        }

        private void ログのインポートToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FF14FastReport.OpenGameLogFolderForm frm = new FF14FastReport.OpenGameLogFolderForm();
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    if (Directory.Exists(frm.SelectedFolder))
                    {
                        FFXIVLogFileReader fr = new FFXIVLogFileReader(frm.SelectedFolder);
                        FF14LogParser _ar = new FF14LogParser();

                        FFXIVLog[] logs = fr.GetLogs();
                        SetStatus(logs.Length + "行のログを解析しています。");
                        Application.DoEvents();
                        System.Threading.ThreadStart ts = () =>
                        {
                            foreach (FFXIVLog log in logs)
                            {
                                _ar.Add(log);
                            }
                        };
                        System.Threading.Thread th = new System.Threading.Thread(ts);
                        th.Start();

                        while (th.IsAlive)
                        {
                            SetProgress(100 * _ar.ds.Anaylzed.Count / logs.Length, true);
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(100);
                        }
                        SetProgress(0, false);
                        SetStatus("読み込みが完了しました");
                        Application.DoEvents();

                        actionReport = _ar;
                        データ範囲指定ToolStripMenuItem_Click(this, null);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ログファイルの読み込みに失敗しました。");
            }
        }

        private void 保存するAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FF14LogParser _ar = new FF14LogParser();

                    System.Threading.ThreadStart ts = () =>
                    {
                        _ar.Read(openFileDialog1.FileName);
                    };
                    System.Threading.Thread th = new System.Threading.Thread(ts);
                    th.Start();

                    int p = 0;
                    SetStatus(String.Format("ファイルを読み込んでいます・・・{0} ", Path.GetFileName(openFileDialog1.FileName)));
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(100);

                    while (th.IsAlive)
                    {
                        SetProgress(Math.Min(100, 10 * p++), true);
                        System.Diagnostics.Debug.WriteLine(actionReport.Progress);
                        System.Threading.Thread.Sleep(100);
                        Application.DoEvents();
                    }
                    SetProgress(0, false);
                    SetStatus(String.Format("ファイルを読み込んでいます・・・ {0} 完了", Path.GetFileName(openFileDialog1.FileName)));

                    if (MessageBox.Show("読み込んだデータの解析を行いますか?", "再解析", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        FF14LogParser ar = new FF14LogParser();
                        ts = () =>
                        {
                            foreach (FFXIVLogDataSet.AnaylzedRow arow in _ar.ds.Anaylzed)
                            {
                                FFXIVLog log = FFXIVLog.CreateLog(arow.TotalSeconds, arow.LogType, arow.ActionType, arow.Body);
                                ar.Add(log);
                            }
                        };

                        th = new System.Threading.Thread(ts);
                        th.Start();

                        while (th.IsAlive)
                        {
                            SetProgress(Math.Min(100, 100 * ar.ds.Anaylzed.Count / _ar.ds.Anaylzed.Count), true);
                            SetStatus(String.Format("解析しています・・・{0}/{1}", ar.ds.Anaylzed.Count, _ar.ds.Anaylzed.Count));
                            Application.DoEvents();
                            System.Threading.Thread.Sleep(500);
                        }
                        SetStatus(String.Format("解析しています・・・{0}/{1}", ar.ds.Anaylzed.Count, _ar.ds.Anaylzed.Count));
                        SetProgress(0, false);
                        Application.DoEvents();

                        actionReport = ar;
                    }
                    else
                    {
                        actionReport = _ar;
                    }
                    SetStatus("表示範囲指定ウィンドウを開いています・・・");
                    Application.DoEvents();
                    データ範囲指定ToolStripMenuItem_Click(this, null);

                }
                catch (Exception _e)
                {
                    MessageBox.Show(_e.Message);
                    actionReport = _processActionReport;
                }
            }
        }

        private void 名前をつけて保存AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    actionReport.Write(saveFileDialog1.FileName);
                }
                catch (Exception _e)
                {
                    MessageBox.Show(_e.Message);
                }
            }
        }

        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            名前をつけて保存AToolStripMenuItem.Enabled = dataGridView1.Rows.Count > 0;
        }

        private void ジョブクラス表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                TreeElementA element = ((TreeElementA)row.Cells[2].Value);
                FFXIVLogDataSet.ActorRow actor = actionReport.ds.Actor.FindByName(element.Text);
               if (actor != null && (actor.IsMe || actor.IsPTMember || actor.IsOther))
               {
                   if (actor.IsClassJobNull())
                   {
                       element.ViewText = "PLAYER";
                       row.Cells[2].Value = element.ViewText;
                       row.Cells[2].Value = element;
                   }
                   else
                   {
                       element.ViewText = actor.ClassJob;
                       row.Cells[2].Value = actor.ClassJob;
                       row.Cells[2].Value = element;
                   }
               }
            }
        }

        private void 名前表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TreeElementA element = ((TreeElementA)row.Cells[2].Value);
                FFXIVLogDataSet.ActorRow actor = actionReport.ds.Actor.FindByName(element.Text);
                if (actor != null && (actor.IsMe || actor.IsPTMember || actor.IsOther))
                {
                    row.Cells[2].Value = "";
                    element.ViewText = element.Text;
                    row.Cells[2].Value = element;
                    
                }
            }
        }
    }
}