using WindowsPE;
using WindowsPE.Algorithms;
using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleProfile : SettingsUserControl
    {
        public RuleProfile()
        {
            InitializeComponent();
        }

        public override bool CheckStatus()
        {
            if(privateCheckBox.Checked == false && publicCheckBox.Checked == false)
            {
                MessageBox.Show("Please check at least one checkbox!");
                return false;
            }

            if(privateCheckBox.Checked && publicCheckBox.Checked) Data.FirewallData.firewallStruct.profile = (0x2 | 0x4);
            else 
            {
                if(privateCheckBox.Checked)
                    Data.FirewallData.firewallStruct.profile = 0x2;
                if(publicCheckBox.Checked)
                    Data.FirewallData.firewallStruct.profile = 0x4;
            }
            return true;
        }
    }
}
