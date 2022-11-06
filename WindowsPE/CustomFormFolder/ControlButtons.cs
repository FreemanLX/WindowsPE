using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE
{
    public class ControlButtons : Button
    {
        string text;
        public ControlButtons(Action EventFunction, string Text, Font font)
        {
            this.Size = new Size(35, 25);
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = Color.Black;
            this.FlatAppearance.BorderSize = 0;
            this.Font = font;
            text = Text;
      //      this.Text = Text;
            //TextAlign = ContentAlignment.MiddleCenter;
            this.Click += new EventHandler((e, s) => EventFunction());
            this.MouseHover += new EventHandler((e, s) => ChangeColors(false));
            this.MouseLeave += new EventHandler((e, s) => ChangeColors(true));
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            string text = this.text;
            Point p =  (text == "X") ? new Point(10, 4) : new Point(8, -14);
            pevent.Graphics.FillRectangle(new SolidBrush(Color.Transparent), ClientRectangle);
            pevent.Graphics.DrawString(text, this.Font, new SolidBrush(Color.Black), p);
        }

        private void ChangeColors(bool reversable)
        {
            if (!reversable)
            {
                this.BackColor = Data.color;
                this.ForeColor = Color.White;
                return;
            }
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }

    }
}
