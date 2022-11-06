using System;
using System.Windows.Forms;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareWizard_Confirmation : UserControl
    {
        public ShareWizard_Confirmation()
        {
            InitializeComponent();
        }

        private void ShareWizard_Confirmation_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            label9.Text = ShareData.pointer.shi2_path;
            label10.Text = ShareData.pointer.shi2_netname;
        }
    }
}
