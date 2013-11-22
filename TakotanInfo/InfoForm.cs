using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infoman
{
    public partial class InfoForm : Form
    {
        public SinTitan titan = new SinTitan();

        public bool IsRunning = false;

        /// <summary>
        /// フォームのサイズを変更する
        /// </summary>
        DAndDSizeChanger dAndDSizeChanger;
        Point lastMousePoint;

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

        public InfoForm()
        {
            InitializeComponent();

            dAndDSizeChanger = new DAndDSizeChanger(this, this, DAndDArea.All, 4);

            foreach (Control ctrl in this.Controls)
            {
                SetDAndDSizeChanger(ctrl);
            }
            UpdateInfos();
        }


        private void SetDAndDSizeChanger(Control control)
        {
            new DAndDSizeChanger(control, this, DAndDArea.None, 0);

            control.MouseDown += new MouseEventHandler(Form_MouseDown);
            control.MouseMove += new MouseEventHandler(Form_MouseMove);
            foreach (Control ctrl in control.Controls)
            {
                SetDAndDSizeChanger(ctrl);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePoint = e.Location;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
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
                if (control.Name == "StatusLabel" && IsRunning)
                {
                    continue;
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

        private void InfoForm_Shown(object sender, EventArgs e)
        {
            Write();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!OnMouse)
            {
                UpdateInfos();
                Write();
            }

        }

        public void UpdateInfos()
        {
            label1.Text = titan.preAction;
            NextActionLabel.Text ="→ " +titan.NextAction;
            NextNextActionLabel.Text ="→→ " +titan.NextNextAction;
            if (titan.NextAction == "大地の怒り")
            {
                NextActionLabel.ForeColor = Color.Red;
            }
            else if (titan.NextAction == "大地の重み")
            {
                NextActionLabel.ForeColor = Color.Orange;
            }
            else if (titan.NextAction == "マウンテンバスター")
            {
                NextActionLabel.ForeColor = Color.OrangeRed;
            }
            else if (titan.NextAction == "激震")
            {
                NextActionLabel.ForeColor = Color.LightPink;
            }
            else
            {
                NextActionLabel.ForeColor = Color.Cyan;
            }

            if (titan.NextNextAction == "大地の怒り")
            {
                NextNextActionLabel.ForeColor = Color.Red;
            }
            else if (titan.NextNextAction == "大地の重み")
            {
                NextNextActionLabel.ForeColor = Color.Orange;
            }
            else if (titan.NextNextAction == "マウンテンバスター")
            {
                NextNextActionLabel.ForeColor = Color.OrangeRed;
            }
            else if (titan.NextNextAction == "激震")
            {
                NextNextActionLabel.ForeColor = Color.LightPink;
            }
            else
            {
                NextNextActionLabel.ForeColor = Color.Cyan;
            }

            PhaseLabel.Text = String.Format("phase {0}", titan.PhaseNumber);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            titan.actionIndex = 0;
            titan.PhaseNumber = 1;
            titan.preAction = "";
            UpdateInfos();
            Write();
        }

        private void InfoForm_MouseEnter(object sender, EventArgs e)
        {
            Write();
        }

        private void InfoForm_MouseLeave(object sender, EventArgs e)
        {
            Write();
        }

    }
}
