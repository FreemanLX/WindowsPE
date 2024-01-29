using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE.Settings
{
    public partial class ControlItem : UserControl
    {
        Action changePanel;
        public ControlItem(Icon image, string option, Action changePanel)
        {
            InitializeComponent();
            if(image != null)
            {
                iconBox.Image = new Icon(image, 48, 48).ToBitmap();
            }
            label2.Text = option;
            label2.Click += Label2_Click;
            this.changePanel = changePanel;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            changePanel();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
