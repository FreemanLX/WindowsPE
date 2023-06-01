using System;
using System.Windows.Forms;
using WindowsPE.Algorithms;

namespace WindowsPE
{
    public partial class ChangeFirewallStatus : Form
    {        
        ProfileCheckBox publicCheckBox, privateCheckBox;
        public ChangeFirewallStatus()
        {
            InitializeComponent();
            publicCheckBox = new ProfileCheckBox("Public");
            privateCheckBox = new ProfileCheckBox("Private");
        }

        private void Cancel_Click(object sender, EventArgs e) => this.Close();

        private void ChangeFirewallStatus_Load(object sender, EventArgs e)
        {
            profileLayout.Controls.Add(publicCheckBox, 0, 0);
            profileLayout.Controls.Add(privateCheckBox, 0, 1);
        }

        private void SetFirewallStatus(ExternalStructures.NET_FW_PROFILE_TYPE2 firewallType, bool enable)
        {
            if(enable) 
            {
                ExternalMethods.FirewallApi.EnableFirewall(firewallType);
                return;
            }
            ExternalMethods.FirewallApi.DisableFirewall(firewallType);
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            SetFirewallStatus((ExternalStructures.NET_FW_PROFILE_TYPE2)0x4, publicCheckBox.enable);
            SetFirewallStatus((ExternalStructures.NET_FW_PROFILE_TYPE2)0x2, privateCheckBox.enable);
            this.Close();
        }
    }
}
