using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class AboutForm : UserControl
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        private void about_Load(object sender, EventArgs e)
        {

        }
    }
}
