using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleType : SettingsUserControl
    {

        /// <summary>
        /// Here it sets up if the rule is on outbound or inbound and sets the rule name;
        /// </summary>
        public RuleType()
        {
            InitializeComponent();
            Data.FirewallData.firewallStruct.enabled = 1;
        }

        private void InboundRadioBtn_CheckedChanged(object sender, System.EventArgs e) => Data.FirewallData.firewallStruct.outbound = (inboundRadioBtn.Checked) ? 0 : 1;

        private void outboundRadioBtn_CheckedChanged(object sender, System.EventArgs e) => Data.FirewallData.firewallStruct.outbound = (outboundRadioBtn.Checked) ? 1 : 0;

        private void FirewallName_TextChanged(object sender, System.EventArgs e) => Data.FirewallData.firewallStruct.name = firewallName.Text;

        public override bool CheckStatus()
        {
            if (string.IsNullOrWhiteSpace(firewallName.Text))
            {
                MessageBox.Show("Please write the rule name"); 
                return false;
            }
            if(inboundRadioBtn.Checked == false && outboundRadioBtn.Checked == false)
            {
                MessageBox.Show("Please select the rule direction.");
                return false;
            }
            return true;
        }

    }
}
