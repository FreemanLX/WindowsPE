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

        public void LoadData()
        {
            pathNameData.Text = ShareData.pointer.shi2_path;
            shareNameData.Text = ShareData.pointer.shi2_netname;
        }
    }
}
