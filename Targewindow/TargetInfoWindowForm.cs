using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using ffxivlib;

namespace Targewindow
{
    public partial class TargetInfoWindowForm : Form
    {
        DAndDSizeChanger dAndDSizeChanger;
        Point lastMousePoint;//ドラッグでの移動用

        public TargetInfoWindowForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// マウスを透過するか
        /// </summary>
        public virtual bool IsTransMouse
        {
            get { return false; }
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

        #region 描画関係

        /// <summary>
        /// 描画する
        /// </summary>
        public void Write()
        {
            Bitmap surfaceBitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            Graphics g = Graphics.FromImage(surfaceBitmap);
            //背景は常に描画しましょうか
            if (true || OnMouse)
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


                control.DrawToBitmap(bitmap, control.ClientRectangle);
                


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
                    ((DataGridView)control).GridColor = Color.FromArgb(255, 64, 64, 64);
                }


                Bitmap bitmap = new Bitmap(control.Width, control.Height, control.CreateGraphics());
                control.DrawToBitmap(bitmap, control.ClientRectangle);

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
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            return canvas;
        }

        #endregion
        #region マウスイベント
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
        #endregion
        #region 透過用
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DeleteObject(IntPtr hobject);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DeleteDC(IntPtr hdc);

        public const byte AC_SRC_OVER = 0;
        public const byte AC_SRC_ALPHA = 1;
        public const int ULW_ALPHA = 2;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct BLENDFUNCTION
        {
            public byte BlendOp;
            public byte BlendFlags;
            public byte SourceConstantAlpha;
            public byte AlphaFormat;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int UpdateLayeredWindow(
            IntPtr hwnd,
            IntPtr hdcDst,
            [System.Runtime.InteropServices.In()]
            ref Point pptDst,
            [System.Runtime.InteropServices.In()]
            ref Size psize,
            IntPtr hdcSrc,
            [System.Runtime.InteropServices.In()]
            ref Point pptSrc,
            int crKey,
            [System.Runtime.InteropServices.In()]
            ref BLENDFUNCTION pblend,
            int dwFlags);

        /// <summary>
        /// レイヤード ウィンドウを設定します。
        /// </summary>
        /// <param name="srcBitmap">表示する画像</param>
        public void SetLayeredWindow(Bitmap srcBitmap)
        {
            MethodInvoker proc = (MethodInvoker)delegate
            {

                // デバイスコンテキストを取得
                IntPtr screenDc = IntPtr.Zero;
                IntPtr memDc = IntPtr.Zero;
                IntPtr hBitmap = IntPtr.Zero;
                IntPtr hOldBitmap = IntPtr.Zero;
                try
                {
                    screenDc = GetDC(IntPtr.Zero);
                    memDc = CreateCompatibleDC(screenDc);
                    hBitmap = srcBitmap.GetHbitmap(Color.FromArgb(0));
                    hOldBitmap = SelectObject(memDc, hBitmap);

                    // BLENDFUNCTION を初期化
                    BLENDFUNCTION blend = new BLENDFUNCTION();
                    blend.BlendOp = AC_SRC_OVER;
                    blend.BlendFlags = 0;
                    blend.SourceConstantAlpha = 255;
                    blend.AlphaFormat = AC_SRC_ALPHA;

                    // レイヤードウィンドウを更新
                    this.Size = new Size(srcBitmap.Width, srcBitmap.Height);
                    Point pptDst = new Point(this.Left, this.Top);
                    Size psize = new Size(this.Width, this.Height);
                    Point pptSrc = new Point(0, 0);
                    UpdateLayeredWindow(
                        this.Handle, screenDc, ref pptDst, ref psize,
                        memDc, ref pptSrc, 0, ref blend, ULW_ALPHA);

                }
                finally
                {
                    if (screenDc != IntPtr.Zero)
                    {
                        ReleaseDC(IntPtr.Zero, screenDc);
                    }
                    if (hBitmap != IntPtr.Zero)
                    {
                        SelectObject(memDc, hOldBitmap);
                        DeleteObject(hBitmap);
                    }
                    if (memDc != IntPtr.Zero)
                    {
                        DeleteDC(memDc);
                    }
                }
            };

            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(proc);
                }
                else
                {
                    proc.Invoke();
                }
            }
            catch
            {
            }
        }

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                const int WS_EX_LAYERED = 0x00080000;
                const int WS_EX_TRANSPARENT = 0x00000020;
                const int WS_BORDER = 0x00800000;
                const int WS_DLGFRAME = 0x00400000;
                const int WS_THICKFRAME = 0x00040000;

                System.Windows.Forms.CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_LAYERED;
                //cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT; // マウス操作を透過する場合はコメントを解除する
                if (this.FormBorderStyle != FormBorderStyle.None)
                {
                    cp.Style = cp.Style & (~WS_BORDER);
                    cp.Style = cp.Style & (~WS_DLGFRAME);
                    cp.Style = cp.Style & (~WS_THICKFRAME);
                }

                return cp;
            }
        }
        #endregion

        private void TargetInfoWindowForm_Load(object sender, EventArgs e)
        {
            dAndDSizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 4);

            Write();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                FFXIVLIB ffxiv = new ffxivlib.FFXIVLIB();
                Entity currentTarget = ffxiv.getCurrentTarget();
                if (currentTarget != null)
                {
                    TargetNameLabel.Text = Encoding.UTF8.GetString(Encoding.Unicode.GetBytes(currentTarget.structure.name));
                    TargetHPLabel.Text = String.Format("{0}/{1} {2:0.00}%", currentTarget.structure.cHP, currentTarget.structure.mHP, 100 * (float)currentTarget.structure.cHP / (float)currentTarget.structure.mHP);
                    PartyMember me = ffxiv.getPartyMemberInfo(0);
                    float dist = (float)Math.Sqrt(Math.Pow(me.structure.X - currentTarget.structure.X, 2) + Math.Pow(me.structure.Y - currentTarget.structure.Y, 2) + Math.Pow(me.structure.Z - currentTarget.structure.Z, 2));
                    DistanceLabel.Text = String.Format("dist.{0:0.00}", dist);
                }
                else
                {
                    TargetNameLabel.Text = "";
                    TargetHPLabel.Text = "";
                    DistanceLabel.Text = "";
                }
            }
            catch(Exception _e)
            {
                TargetNameLabel.Text = _e.Message;
                TargetHPLabel.Text = "";
                DistanceLabel.Text = "";
            }
        }
    }
}
