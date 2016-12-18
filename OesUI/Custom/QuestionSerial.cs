using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace OesUI.Custom
{
    public class QuestionSerial : Control
    {
        public Color BorderColor { get; set; }
        public Color FontColor { get; set; }

        public QuestionSerial()
        {
            this.Width = 30;
            this.Height = 25;
            this.BorderColor = Color.FromArgb(254, 153, 1);
            this.FontColor = Color.FromArgb(10, 10, 10);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(new Pen(this.BorderColor), 0, 0, this.Width - 1, this.Height - 1);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.FontColor), new Rectangle(0, 0, this.Width, this.Height), sf);
        }
    }
}
