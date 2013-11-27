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
    public partial class FastReportForm : Form
    {
        /// <summary>
        /// フォームのサイズを変更する
        /// </summary>
        DAndDSizeChanger dAndDSizeChanger;
        Point lastMousePoint;

        FF14LogParser ar;

        string MessageText = "";

        #region public methods

        /// <summary>
        /// 表示ラベルのリスト
        /// </summary>
        List<Label> LabelList;

        /// <summary>
        /// ログを追加する
        /// </summary>
        /// <param name="log"></param>
        public void AddLog(FFXIVLog log)
        {
            FFXIVLogDataSet.AnaylzedRow arow = ar.Add(log);
            //string myname = rep.GetMyName();
            //if (myname == "")
            //    return;
            //int My_TotalDmg = rep.GetTotalDamage(myname, 0);
            //int My_HitCount = rep.GetHitCount(myname, 0);
            //int My_MissCount = rep.GetMissCount(myname, 0);
            //double My_HitRate = (double)My_HitCount / (double)(My_HitCount + My_MissCount) * 100;
            //double My_Dps = rep.GetTotalDamage(myname, log.TotalSeconds - 60) / 60.0;

            //if (ar.ds.Anaylzed.Count > 2)
            //{
            //    TimeSpan span = (log.TimeStampServerTime - ar.ds.Anaylzed[0].ServerTime);
            //    DateTime viewDateTime = new DateTime(1900, 1, 1, span.Hours, span.Minutes, span.Seconds);
            //    LastTimeLabel.Text = viewDateTime.ToString("HH:mm:ss");
            //}
            //TotalDmgLabel.Text = String.Format("total {0:#,0}", My_TotalDmg);
            //if (My_HitCount + My_MissCount > 0)
            //{
            //    HitLabel.Text = String.Format("hit {0:#,0}/{1:#,0} {2:0.0}%", My_HitCount, My_HitCount + My_MissCount, My_HitRate);
            //}
            //DpsLabel.Text = String.Format("dps {0:0.0}/sec", My_Dps);

            ////ログ形式で表示
            //string a = CreateReport(arow);
            //if (a != "")
            //{
            //    fF14FastReportDataSet.Reportlog.AddReportlogRow(a);
            //    //int cnt = listView1.Height / listView1.Items[0].Bounds.Height +1;
            //    //while (listView1.Items.Count > cnt)
            //    //{
            //    //    listView1.Items.RemoveAt(0);
            //    //}
            //    //int index = Math.Max(0, listView1.Items.Count - cnt);
            //    //listView1.EnsureVisible(listView1.Items.Count-1);
            //    if (!OnMouse)
            //    {
            //        //                    dataGridView1.
            //        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            //    }
            //}
            Write();
        }

        /// <summary>
        /// ログからレポートを作成する
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private string CreateReport(FFXIVLogDataSet.AnaylzedRow log)
        {
            //ダメージ
            //if (log.ActionType == 0xA9 || log.ActionType == 0x29)//A9と29があるのはなぜだろう
            //{
            //    if (!log.IsNumericNull())
            //    {

            //        int fromTotal = rep.GetTotalDamage(log.From,0);
            //        int fromtoTotal = rep.GetTotalDamage(log.From,log.To,0);
            //        int toTotal = rep.GetTakenDamage(log.To,0);
            //        double rateFrom = 100.0 *(double)fromtoTotal/(double)fromTotal;
            //        double rateTo = 100.0 *(double)fromtoTotal/(double)toTotal;

            //        return String.Format("{0}[{1}/{3}({2:0.00}%)] ⇒ {4}[{5}/{7}({6:0.00}%)]",
            //            log.From,// 0
            //            fromtoTotal,// 1
            //            rateFrom,// 2
            //            fromTotal,// 3
            //            log.To,// 4
            //            fromtoTotal,//5
            //            rateTo,//6
            //            toTotal);
            //    }
            //}
            return "";
        }

        /// <summary>
        /// リセットする
        /// </summary>
        public void Reset()
        {
        }


        #endregion





        /// <summary>
        /// マウスがフォーム上にあるか
        /// </summary>
        bool OnMouse
        {
            get
            {
                return this.Bounds.Contains(Cursor.Position);
            }
        }

        public FastReportForm()
        {
            InitializeComponent();
            ar = new FF14LogParser();

            dAndDSizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 4);

            foreach(Control ctrl in this.Controls)
            {
                SetDAndDSizeChanger(ctrl);
            }


        }

        private void SetDAndDSizeChanger(Control control)
        {
            new DAndDSizeChanger(control, this, DAndDArea.None, 0);

            control.MouseDown += new MouseEventHandler(LayerdMouseTransForm_MouseDown);
            control.MouseMove += new MouseEventHandler(LayerdMouseTransForm_MouseMove);
            foreach (Control ctrl in control.Controls)
            {
                SetDAndDSizeChanger(ctrl);
            }
        }

        /// <summary>
        /// 描画する
        /// </summary>
        public void Write()
        {
            Bitmap surfaceBitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            Graphics g = Graphics.FromImage(surfaceBitmap);

            g.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.Black)), this.ClientRectangle);
            foreach (Control control in this.Controls)
            {
                if (control.Width <= 0 || control.Height <= 0)
                    continue;
                if (control is Button)
                {
                    if (!OnMouse) continue;
                }

                Bitmap bitmap = new Bitmap(control.Width, control.Height, control.CreateGraphics());
                control.DrawToBitmap(bitmap, control.ClientRectangle);
                bitmap.MakeTransparent(Color.Black);
                g.DrawImage(bitmap, control.Bounds);
                bitmap.Dispose();
            }
            if (OnMouse)
            {
                Pen newPen = new Pen(Color.Green, 3);
                g.DrawRectangle(newPen, newPen.Width / 2, newPen.Width / 2, this.Width - newPen.Width, this.Height - newPen.Width);
            }

            SetLayeredWindow(surfaceBitmap);
        }

        private void LayerdMouseTransForm_Load(object sender, EventArgs e)
        {
            Write();
        }

        private void LayerdMouseTransForm_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == System.Windows.Forms.MouseButtons.Left && dAndDSizeChanger.Status == DAndDArea.None)
            {
                this.Location += (Size)e.Location - (Size)lastMousePoint;
            }
            if (dAndDSizeChanger.Status != DAndDArea.None)
            {
                Write();
            }
        }

        private void LayerdMouseTransForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePoint = e.Location;
        }

        private void LayerdMouseTransForm_Resize(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Width = this.Width - 10;
            //flowLayoutPanel1.Height = this.Height - 10;
            Write();
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
            Write();
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.None;
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
            Write();
        }

        private void listView1_Resize(object sender, EventArgs e)
        {
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Write();
        }
    }
}
