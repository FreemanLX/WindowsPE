using System;
using System.Net;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareWizard_Name : System.Windows.Forms.UserControl
    {
    
        public ShareWizard_Name() 
        {
            InitializeComponent();
            localPathtoShare.Text = ShareData.pointer.shi2_path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uncPathtoShare.Text = "\\\\" + Dns.GetHostName() + "\\" + nameShare.Text;
            ShareData.pointer.shi2_netname = nameShare.Text;
            ShareData.pointer.shi2_remark = " ";
        }
    }
}
