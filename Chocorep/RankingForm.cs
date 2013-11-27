using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FFXIV_Tools;

using System.Drawing.Imaging;

namespace FF14FastReport
{
    public partial class RankingForm : Form
    {
        DAndDSizeChanger dAndDSizeChanger;
        Point lastMousePoint;//ドラッグでの移動用

        Report _report;
        public bool ViewLog
        {
            get;
            set;
        }

        public bool ViewPTMember
        {
            get;
            set;
            //get
        }

        public bool ViewEnemy
        {
            get;
            set;
        }


        /// <summary>
        /// マウス透過モードが変更された
        /// </summary>
        public event EventHandler MouseTransModeChanged;

        /// <summary>
        /// マウスを透過するか
        /// </summary>
        public virtual bool IsTransMouse
        {
            get { return false; }
        }

        public Report report
        {
            get
            {
                return _report;
            }
            set
            {
                _report = value;
                dPSReportBindingSource.DataSource = report.FF14FastReportDS;
            }
        }

        /// <summary>
        /// Reportをリセットする
        /// </summary>
        public void Reset()
        {
            report.Reset();

            FormUpdate();
        }

        /// <summary>
        /// 幅を自動調整するか
        /// </summary>
        public bool AutoSizeWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 高さを自動調整するか
        /// </summary>
        public bool AutoSizeHeight
        {
            get;
            set;
        }

        /// <summary>
        /// マウスがフォーム上にあるか
        /// </summary>
        bool OnMouse
        {
            get
            {
                if (IsTransMouse)
                    return false;

                return this.Bounds.Contains(Cursor.Position);
            }
        }


        /// <summary>
        /// フォントサイズを取得または設定する
        /// </summary>
        public float GridViewFontSize
        {
            get
            {
                return dPSReportDataGridView.DefaultCellStyle.Font.Size;
            }
            set
            {
                dPSReportDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", value);
                dPSReportDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Verdana", value);
                dPSReportDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 244, 244, 244);
                LogTextLabel.Font = new System.Drawing.Font("Meiryo UI", value);
                Write();
            }
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RankingForm()
        {
            InitializeComponent();
            report = new Report();

            dPSReportDataGridView_DefaultCellStyleChanged(this, null);

            //表示する項目
            ViewLog = false;//ログOFF
            ViewPTMember = false;//PT OFF
            ViewEnemy = false;//敵 OFF
        }

        DateTime lastDateTime;

        /// <summary>
        /// ログを追加する
        /// </summary>
        /// <param name="log"></param>
        public void AddLog(FFXIVLog log)
        {
            report.Add(log);
            lastDateTime = log.TimeStampServerTime.ToLocalTime();
            if (ViewLog)
            {
                LogTextLabel.Text = String.Format("[{0}]{1}", log.TimeStampServerTime.AddHours(9.0).ToString("HH:mm:ss"), log.LogBodyReplaceTabCode);
            }
            else if(LogTextLabel.Text !="")
            {
                LogTextLabel.Text = "";
            }
        }

        /// <summary>
        /// フォームを更新する
        /// </summary>
        private void FormUpdate()
        {
            if (AutoSizeHeight)
            {
                FitHeight();
            }
            if (AutoSizeWidth)
            {
                FitWidth();
            }

            string filter = "Category <= 0";
            if (ViewPTMember)
            {
                filter = filter + " or Category <= 1";
            }
            if (ViewEnemy)
            {
                filter = filter + " or Category <= 2";
            }
            dPSReportBindingSource.Filter = filter;
            


            foreach (DataGridViewRow row in dPSReportDataGridView.Rows)
            {
                if (row.Cells.Count > 0)
                {
                    if ((int)row.Cells[0].Value == -1)
                    {//pt
                        row.DefaultCellStyle.ForeColor = Color.LightCyan;
                        row.DefaultCellStyle.SelectionForeColor = Color.LightCyan;
                    }
                    else if ((int)row.Cells[0].Value == 0)
                    {//me
                        row.DefaultCellStyle.ForeColor = Color.GreenYellow;
                        row.DefaultCellStyle.SelectionForeColor = Color.GreenYellow;
                    }
                    else if ((int)row.Cells[0].Value == 1)
                    {//pt
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 192, 255, 255);
                        row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 192, 255, 255);
                    }
                    else
                    {//Enemy
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 244, 244, 244);
                        row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 244, 244, 244);
                    }
                }
            }

            Write();
        }

        /// <summary>
        /// フォームがロードされた
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_Load(object sender, EventArgs e)
        {
            dAndDSizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 4);

            foreach (DataGridViewColumn col in dPSReportDataGridView.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewRow row in dPSReportDataGridView.Rows)
            {
                row.DefaultCellStyle = dPSReportDataGridView.DefaultCellStyle;
            }
            dPSReportBindingSource.DataSource = report.FF14FastReportDS;
            dPSReportBindingSource.Sort = "Category, Name";
            Write();

            //自動調整
            幅自動調整ToolStripMenuItem.Checked = AutoSizeWidth;
            高さ自動調整ToolStripMenuItem.Checked = AutoSizeHeight;

            toolStripMenuItem1.Checked = ViewLog;
            pT表示ToolStripMenuItem.Checked = ViewPTMember;
            enemy表示ToolStripMenuItem.Checked = ViewEnemy;

            FitHeight();
            FitWidth();

            timer1.Start();
        }

        #region 描画関係

        /// <summary>
        /// 描画する
        /// </summary>
        public void Write()
        {
            Bitmap surfaceBitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            Graphics g = Graphics.FromImage(surfaceBitmap);
            //背景は常に描画しましょうか
            if (true ||OnMouse)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(128, Color.Black)), this.ClientRectangle);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(1, Color.Black)), this.ClientRectangle);
            }

                //周り
                foreach (Control control in this.Controls)
                {
                    if (control.Width <= 0 || control.Height <= 0)
                        continue;
                    if (control is Button && !OnMouse)//マウスがないときはボタンは描画しない
                        continue;
                    if (!control.Visible)
                        continue;
                    if (control is DataGridView)
                    {
                        ((DataGridView)control).GridColor = Color.Black;
                    }

                    Bitmap bitmap = new Bitmap(control.Width, control.Height, control.CreateGraphics());

                    if (control is Label)
                    {
                        if (ViewLog)
                        {
                            Graphics _g = Graphics.FromImage(bitmap);
                            _g.DrawString(control.Text, control.Font, new SolidBrush(Color.White), 0, 0);
                        }
                    }
                    else
                    {
                        control.DrawToBitmap(bitmap, control.ClientRectangle);
                    }


                    bitmap = ChangeColor(bitmap);
                    bitmap.MakeTransparent(Color.Black);
                    bitmap = ChangeColor(bitmap, Color.White, Color.Black);
                    bitmap = ChangeAlpha(bitmap, 0.5F);

                    for (int dx = -1; dx < 2; dx++)
                    {
                        for (int dy = -1; dy < 2; dy++)
                        {
                            Rectangle rec = control.Bounds;
                            rec.X = rec.X + dx;
                            rec.Y = rec.Y + dy;
                            g.DrawImage(bitmap, rec);
                        }
                    }
                    bitmap.Dispose();
                }
            

            //中心
            foreach (Control control in this.Controls)
            {
                if (control is Button && !OnMouse)//マウスがないときはボタンは描画しない
                    continue;

                if (control.Width <= 0 || control.Height <= 0)
                    continue;
                if (control is DataGridView)
                {
                    ((DataGridView)control).GridColor = Color.FromArgb(255,64, 64, 64);
                }


                Bitmap bitmap = new Bitmap(control.Width, control.Height, control.CreateGraphics());
                if (control is Label)
                {
                    if (ViewLog)
                    {
                        Graphics _g = Graphics.FromImage(bitmap);
                        _g.DrawString(control.Text, control.Font, new SolidBrush(Color.White), 0, 0);
                    }
                }
                else
                {
                    control.DrawToBitmap(bitmap, control.ClientRectangle);
                }

                bitmap.MakeTransparent(Color.Black);
                g.DrawImage(bitmap, control.Bounds);
                bitmap.Dispose();
            }

            //マウスがフォーム上にあるとき
            if (OnMouse)
            {
                Pen newPen = new Pen(Color.Blue, 3);
                g.DrawRectangle(newPen, newPen.Width / 2, newPen.Width / 2, this.Width - newPen.Width, this.Height - newPen.Width);
            }


            SetLayeredWindow(surfaceBitmap);
        }

        private Bitmap ChangeAlpha(Bitmap sourceImage, float alpha)
        {
            Bitmap bitmap = new Bitmap(sourceImage.Width, sourceImage.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(bitmap);

            //画像を読み込む
            Image img = sourceImage;

            //ColorMatrixオブジェクトの作成
            System.Drawing.Imaging.ColorMatrix cm =
                new System.Drawing.Imaging.ColorMatrix();
            //ColorMatrixの行列の値を変更して、アルファ値が0.5に変更されるようにする
            cm.Matrix00 = 1;
            cm.Matrix11 = 1;
            cm.Matrix22 = 1;
            cm.Matrix33 = alpha;
            cm.Matrix44 = 1;

            //ImageAttributesオブジェクトの作成
            System.Drawing.Imaging.ImageAttributes ia =
                new System.Drawing.Imaging.ImageAttributes();
            //ColorMatrixを設定する
            ia.SetColorMatrix(cm);

            //ImageAttributesを使用して画像を描画
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            //リソースを解放する
            img.Dispose();
            g.Dispose();
            return bitmap;
        }

        /// <summary>
        /// イメージを2値化する
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <returns></returns>
        private Bitmap ChangeColor(Bitmap sourceImage)
        {
            //RGBの比率(YIQカラーモデル)
            const float r = 1.0F;
            const float g = 1.0F;
            const float b = 1.0F;

            //ColorMatrixにセットする行列を 5 * 5 の配列で用意
            //入力のRGBの各チャンネルを重み付けをした上で、
            //出力するRGBがR = G = B となるような行列をセット
            float[][] matrixElement =
                      {new float[]{r, r, r, 0, 0},
                       new float[]{g, g, g, 0, 0},
                       new float[]{b, b, b, 0, 0},
                       new float[]{0, 0, 0, 1, 0},
                       new float[]{0, 0, 0, 0, 1}};

            //ColorMatrixオブジェクトの作成
            ColorMatrix matrix = new ColorMatrix(matrixElement);

            //ImageAttributesにセット
            ImageAttributes attr = new ImageAttributes();
            attr.SetColorMatrix(matrix);

            //閾値の設定
            attr.SetThreshold(0.5F);    //50%を指定

            int imageWidth = sourceImage.Width;
            int imageHeight = sourceImage.Height;

            //新しいビットマップを用意
            Bitmap changedImage = new Bitmap(imageWidth, imageHeight);

            //新しいビットマップにImageAttributesを指定して
            //元のビットマップを描画
            Graphics graph = Graphics.FromImage(changedImage);

            graph.DrawImage(sourceImage,
                            new Rectangle(0, 0, imageWidth, imageHeight),
                            0, 0, imageWidth, imageHeight,
                            GraphicsUnit.Pixel,
                            attr);

            graph.Dispose();

            return changedImage;
        }


        /// <summary>
        /// 色を変える fromからtoに
        /// </summary>
        /// <param name="img"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private Bitmap ChangeColor(Bitmap img, Color from, Color to)
        {
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(img.Width, img.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            //ColorMapオブジェクトの配列（カラーリマップテーブル）を作成
            System.Drawing.Imaging.ColorMap[] cms =
                new System.Drawing.Imaging.ColorMap[] { new System.Drawing.Imaging.ColorMap(), new System.Drawing.Imaging.ColorMap() };

            //fromをtoに変換する
            cms[0].OldColor = from;
            cms[0].NewColor = to;
            ////黒を白に変換する
            cms[1].OldColor = to;
            cms[1].NewColor = from;

            //ImageAttributesオブジェクトの作成
            System.Drawing.Imaging.ImageAttributes ia =
                new System.Drawing.Imaging.ImageAttributes();
            //ColorMapを設定
            ia.SetRemapTable(cms);

            //画像を普通に描画
            g.DrawImage(img, 0, 0);

            //色を変換して画像を描画
            g.DrawImage(img,new Rectangle(0,0,img.Width,img.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            return canvas;
        }

        #endregion

        /// <summary>
        /// フォームのサイズが変更されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_Resize(object sender, EventArgs e)
        {
            Write();
        }

        /// <summary>
        /// マウスが動いたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_MouseMove(object sender, MouseEventArgs e)
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

        /// <summary>
        /// マウスのボタンがおされたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePoint = e.Location;
        }

        /// <summary>
        /// マウスが離れたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_MouseLeave(object sender, EventArgs e)
        {
            Write();
        }
        /// <summary>
        /// マウスが上に乗ったとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_MouseEnter(object sender, EventArgs e)
        {
            Write();
        }

        /// <summary>
        /// セルのスタイルが変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dPSReportDataGridView_DefaultCellStyleChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dPSReportDataGridView.Rows)
            {
                row.Height = (int)Math.Ceiling(dPSReportDataGridView.DefaultCellStyle.Font.GetHeight()*1.05) + 4;
            }
            dPSReportDataGridView.RowTemplate.Height = (int)Math.Ceiling(dPSReportDataGridView.DefaultCellStyle.Font.GetHeight()) + 2;
            //先頭CELｌ
            dPSReportDataGridView_RowsAdded(this, null);
            FormUpdate();
        }

        /// <summary>
        /// 閉じるボタンの描画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.DarkGray), 0, 0, 23, 23);
            g.DrawLine(Pens.Blue, 0, 0, 23, 23);
            g.DrawLine(Pens.Blue, 0, 23, 23, 0);
        }

        /// <summary>
        /// 閉じる[x]ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// 追加されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dPSReportDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //フォントを設定
            foreach (DataGridViewRow row in dPSReportDataGridView.Rows)
            {
                if (Encoding.GetEncoding("shift-jis").GetBytes(row.Cells[0].Value.ToString()).Length == row.Cells[0].Value.ToString().Length)
                {//半角　⇒　Verdana
                    row.Cells[0].Style.Font = new Font("Verdana", GridViewFontSize);
                }
                else
                {//全角 Meiryo UI
                    row.Cells[0].Style.Font = new Font("Meiryo UI", GridViewFontSize);
                }
            }
        }

        /// <summary>
        /// ダブルクリックされた
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingForm_DoubleClick(object sender, EventArgs e)
        {//サイズを自動調整しようかな
            FitHeight();
            FitWidth();
        }

        /// <summary>
        /// フォームの高さを調整する
        /// </summary>
        private void FitHeight()
        {
            //高さ
            int height = dPSReportDataGridView.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dPSReportDataGridView.Rows)
            {
                height += row.Height;
            }
            if (ViewLog)
            {
                Graphics g = LogTextLabel.CreateGraphics();
                SizeF labelSize = g.MeasureString(LogTextLabel.Text, LogTextLabel.Font);
                LogTextLabel.Height =(int) labelSize.Height+1;
                LogTextLabel.Top = this.Height - (int)Math.Ceiling(labelSize.Height) -5;
                this.Height = height + dPSReportDataGridView.ColumnHeadersHeight + 3 + (int)Math.Ceiling(labelSize.Height);
            }
            else
            {
                this.Height = height + dPSReportDataGridView.ColumnHeadersHeight + 3 ;
            }
        }

        /// <summary>
        /// フォームの幅を調整する
        /// </summary>
        private void FitWidth()
        {
            int width = 0;
            //幅
            foreach (DataGridViewColumn col in dPSReportDataGridView.Columns)
            {
                if (col.Visible) width += col.Width;
            }

            this.Width = width + 14;
        }


        /// <summary>
        /// マウス透過が押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void マウス透過ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MouseTransModeChanged != null)
            {
                MouseTransModeChanged(this, null);
            }
        }

        /// <summary>
        /// フィットするが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void フィットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RankingForm_DoubleClick(this, null);
        }

        /// <summary>
        /// 閉じるが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(this, null);
        }

        /// <summary>
        /// DataGridViewのサイズが変更された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dPSReportDataGridView_Resize(object sender, EventArgs e)
        {
            
        }

        private void LogTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (OnMouse)
            {//マウスがあるときはデータ更新しない
                return;
            }

            //データ更新
            if (lastDateTime > FFXIVLog.StartDateTime)
            {
                //DEBUG
                //report.UpdateDamage(lastDateTime);
                report.UpdateDamage(DateTime.Now);
            }
            //表示更新
            FormUpdate();
        }

        private void データリセットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void 幅自動調整ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoSizeWidth = !AutoSizeWidth;
            幅自動調整ToolStripMenuItem.Checked = AutoSizeWidth;
        }

        private void 高さ自動調整ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoSizeHeight = !AutoSizeHeight;
            高さ自動調整ToolStripMenuItem.Checked = AutoSizeHeight;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewLog = !ViewLog;
            toolStripMenuItem1.Checked = ViewLog;
        }

        private void pT表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPTMember = !ViewPTMember;
            pT表示ToolStripMenuItem.Checked = ViewPTMember;
        }

        private void enemy表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEnemy = !ViewEnemy;
            enemy表示ToolStripMenuItem.Checked = ViewEnemy;
        }

        private void RankingForm_Shown(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.RankingFormPosition;
        }

        private void RankingForm_LocationChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                Properties.Settings.Default.RankingFormPosition = this.Location;
            }
        }
    }
}
