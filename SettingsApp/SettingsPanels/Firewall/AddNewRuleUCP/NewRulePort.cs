using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class NewRulePort : SettingsUserControl
    {
        public NewRulePort()
        {
            InitializeComponent();
            protocolComboBox.Items.AddRange(new string[] {
                 "TCP", "UDP", "ICMPv4", "ICMPv6", "IGMP"
            });
        }

        private void NewRulePort_Load(object sender, EventArgs e)
        {
            protocolComboBox.SelectedIndex = 1;
        }

        private void localPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            localPortTextBox.Enabled = (localPortComboBox.SelectedIndex == 1);
        }

        private void remotePortTextBox_TextChanged(object sender, EventArgs e)
        {
            if(remotePortTextBox.Text.Length > 0)
              Data.FirewallData.firewallStruct.remotePort = remotePortTextBox.Text;
        }

        private void remotePortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            remotePortTextBox.Enabled = (remotePortComboBox.SelectedIndex == 1);
        }

        private void localPortTextBox_TextChanged(object sender, EventArgs e)
        {
            if(localPortTextBox.Text.Length > 0)
              Data.FirewallData.firewallStruct.remotePort = localPortTextBox.Text;
        }

        private void protocolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            remotePortComboBox.Enabled = localPortComboBox.Enabled = !(protocolComboBox.SelectedIndex >= 2);
            string selectedItem = protocolComboBox.Items[protocolComboBox.SelectedIndex] as string;
            switch (selectedItem)
            {
                case "TCP": 
                       Data.FirewallData.firewallStruct.protocol = 6;
                       break;

                case "UDP":
                       Data.FirewallData.firewallStruct.protocol = 17;
                       break;
                
                case "ICMPv4":
                       Data.FirewallData.firewallStruct.protocol = 1;
                       break;
                
                case "ICMPv6":
                      Data.FirewallData.firewallStruct.protocol = 58;
                       break; 
 
                case "IGMP":
                      Data.FirewallData.firewallStruct.protocol = 2;
                      break; 
            }
        }

        public override bool CheckStatus()
        {
            if (protocolComboBox.SelectedIndex < 2)
            {
                //range 1 - 65535
                string range = @"^()((0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])+\b-(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5]))$";
                
                //7445, 5545, 4556, 5656, 65535
                string comma = @"^(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])(,(0|[1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5]))*$";
                if(localPortComboBox.SelectedIndex == 1)
                {
                    if(localPortTextBox.Text.Length == 0 || 
                         !(Regex.Match(localPortTextBox.Text, range).Success || Regex.Match(localPortTextBox.Text, comma).Success))
                    {
                        MessageBox.Show("Please write valid local ports. Ex: 2050 - 4540 or 45545,54565,2430");
                        return false;
                    }
                }
                if(remotePortComboBox.SelectedIndex == 1)
                {
                    if(remotePortTextBox.Text.Length == 0 || 
                         !(Regex.Match(remotePortTextBox.Text, range).Success || Regex.Match(remotePortTextBox.Text, comma).Success))
                    {
                        MessageBox.Show("Please write valid remote ports. Ex: 2050 - 4540 or 45545, 54565, 2430");
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
