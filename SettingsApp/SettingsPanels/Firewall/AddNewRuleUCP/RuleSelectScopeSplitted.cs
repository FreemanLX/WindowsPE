using System;
using WindowsPE;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleSelectScopeSplitted : UserControl
    {
        bool remote;
        public RuleSelectScopeSplitted(bool remote = false)
        {
            InitializeComponent();

            this.remote = remote;
            if(remote)
                this.InfoText.Text = "Which remote IP addresses does this rules apply to?";

            radioIPAddress.Checked = true;
        }

        private void radioSpecifiedIPAddress_CheckedChanged(object sender, EventArgs e)
        {
            ipAddressTextBox.Enabled = radioSpecifiedIPAddress.Checked;
        }

        private void ipAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if(ipAddressTextBox.Text.Length > 0)
            {
                 if(!remote)
                    Data.FirewallData.firewallStruct.localAddress = ipAddressTextBox.Text;
                 else 
                    Data.FirewallData.firewallStruct.remoteAddress = ipAddressTextBox.Text;
            }
        }

        public bool CheckStatus()
        {
            string ipRegex = @"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$";
            if (ipAddressTextBox.Enabled)
            {
                if(ipAddressTextBox.Text.Length == 0 || !(Regex.Match(ipAddressTextBox.Text, ipRegex).Success))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
