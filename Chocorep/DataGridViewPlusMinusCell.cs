using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FFXIV_Tools
{
    public class DataGridViewPlusMinusColumn : DataGridViewColumn
    {
        public DataGridViewPlusMinusColumn()
        {
            this.CellTemplate = new DataGridViewPlusMinusCell();
            this.ReadOnly = true;
        }
    }


    public class DataGridViewPlusMinusCell : DataGridViewTextBoxCell
    {
        public bool IsPlus;
        const int SPACE = 5;
        const int IndentWidth = 10;
        const int HORIZONTALOFFSET = 5;
        public int ButtonSize = 10;
        public bool ViewPlusMinusButton;

        private int _indent;

        public int Indent
        {
            get
            {
                return _indent;
            }
            set
            {
                _indent = value;
                Style.Padding = new Padding(HORIZONTALOFFSET + ButtonSize + SPACE + _indent * IndentWidth, 0, 0, 0);

            }
        }

        
        
        /// <summary>
        /// プラスにする
        /// </summary>
        public void ChangePlus()
        {

        }

        /// <summary>
        /// マイナスにする
        /// </summary>
        public void ChangeMinus()
        {
        }

        public DataGridViewPlusMinusCell()
            : base()
        {
            Style.Padding = new Padding(HORIZONTALOFFSET + ButtonSize + SPACE+Indent * IndentWidth, 0, 0, 0);
            ViewPlusMinusButton = true;
        }

        public void SetIndent(int _indent)
        {
            this.Indent = _indent;
            Style.Padding = new Padding(HORIZONTALOFFSET + ButtonSize + SPACE+Indent*IndentWidth, 0, 0, 0);
            
        }

        

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, "", errorText, cellStyle, advancedBorderStyle, paintParts);

            DataGridViewColumn parent = this.OwningColumn;

            //文字
            string cellText = formattedValue.ToString();
            if (cellText == "")
                return;




            Rectangle PulsMinusRec = new Rectangle(cellBounds.X + HORIZONTALOFFSET + Indent*IndentWidth ,cellBounds.Y + (cellBounds.Height - ButtonSize) / 2, ButtonSize, ButtonSize);
            graphics.DrawRectangle(Pens.Gray, PulsMinusRec);
            if (ViewPlusMinusButton)
            {
                //横
                graphics.DrawLine(Pens.Black, PulsMinusRec.X + 0.2F * ButtonSize, PulsMinusRec.Y + 0.5F * ButtonSize, PulsMinusRec.X + 0.8F * ButtonSize, PulsMinusRec.Y + 0.5F * ButtonSize);
                //縦
                if (IsPlus)
                {
                    graphics.DrawLine(Pens.Black, PulsMinusRec.X + 0.5F * ButtonSize, PulsMinusRec.Y + 0.2F * ButtonSize, PulsMinusRec.X + 0.5F * ButtonSize, PulsMinusRec.Y + 0.8F * ButtonSize);
                }
            }
            Color textColor = parent.InheritedStyle.ForeColor;
            if ((cellState &
               DataGridViewElementStates.Selected) ==
               DataGridViewElementStates.Selected)
            {
                textColor = parent.InheritedStyle.SelectionForeColor;
            } 
            Font fnt = InheritedStyle.Font;
            SizeF textSize = graphics.MeasureString(cellText,fnt);
            PointF textStart = new PointF(Convert.ToSingle(HORIZONTALOFFSET+ButtonSize+SPACE+Indent * IndentWidth),(cellBounds.Height-textSize.Height)/2);
            using (SolidBrush brush = new SolidBrush(parent.InheritedStyle.ForeColor))
            {
                graphics.DrawString(cellText, fnt, brush,cellBounds.X + textStart.X,cellBounds.Y + textStart.Y);
            }


        }
    }
}
