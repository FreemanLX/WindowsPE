using System;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class ProfileCheckBox : UserControl
    {
        public bool enable;
        public ProfileCheckBox(string headText, bool enabled)
        {
            InitializeComponent();
            this.InfoText.Text = headText;
            enable = enableRadioBtn.Checked = enabled;
            disableRadioBtn.Checked = !enabled;
        }

        private void enableRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            enable = enableRadioBtn.Checked;
        }
    }
}
