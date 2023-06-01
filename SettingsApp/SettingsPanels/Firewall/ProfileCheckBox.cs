using System;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class ProfileCheckBox : UserControl
    {
        public bool enable;
        public ProfileCheckBox(string headText)
        {
            InitializeComponent();
            this.InfoText.Text = headText;
            enable = enableRadioBtn.Checked; //he is already checked
        }

        private void enableRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            enable = enableRadioBtn.Checked;
        }
    }
}
