using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
namespace Infoman
{
    public partial class InfoForm : Form
    {
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
    }
}
