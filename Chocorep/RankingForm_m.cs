using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FF14FastReport
{
    public class RankingForm_m:RankingForm
    {
        /// <summary>
        /// マウスを透過するか
        /// </summary>
        public override bool IsTransMouse
        {
            get { return true; }
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
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT; // マウス操作を透過する場合はコメントを解除する
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
