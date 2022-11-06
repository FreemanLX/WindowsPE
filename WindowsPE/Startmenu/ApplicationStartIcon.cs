using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class ApplicationStartIcon : UserControl
    {
        Action clickHandler;
        public ApplicationStartIcon(string applicationNameText, Action clickHandler, Color color, Icon iconPicture = null)
        {
            InitializeComponent();
            applicationName.Text = applicationNameText;
            this.clickHandler = clickHandler;
            this.iconPicture.BackColor = color;
            if(iconPicture != null)
            {
                this.iconPicture.Image = new Icon(iconPicture, new Size(4, 4)).ToBitmap();
                this.iconPicture.BackColor = Color.Transparent;
            }
        }

        private void ApplicationStartIcon_Load(object sender, EventArgs e)
        {

        }

        private void iconPicture_Click_1(object sender, EventArgs e) => clickHandler();
        private void ApplicationName_Click(object sender, EventArgs e) => clickHandler();
    }
}
