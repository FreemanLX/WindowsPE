using System;
using System.Windows.Forms;
using System.Net;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareWizard_Name : UserControl
    {
        public ShareWizard_Name()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            textBox2.Text = ShareData.pointer.shi2_path;
        }

        private void ShareWizard_Name_Load(object sender, EventArgs e)
        {
            //textBox2.Text = ShareData.pointer.shi2_path;
        }

        public void LocationData()
        {
            ShareData.pointer.shi2_netname = textBox1.Text;
            if(richTextBox1.Text.Length > 0)
            {
                ShareData.pointer.shi2_remark = richTextBox1.Text;
            }
            else
            {
                ShareData.pointer.shi2_remark = " ";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "\\\\" + Dns.GetHostName() + "\\" + textBox1.Text;
            ShareData.newShareForm.SetNextBtn(textBox1.Text.Length > 0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
