using System.Windows.Forms;
using WindowsPE;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleAction : SettingsUserControl
    {
        public RuleAction()
        {
            InitializeComponent();
            radioAllowConnection.Checked = true;
        }
        private void radioAllowConnection_CheckedChanged(object sender, System.EventArgs e)
        {
            Data.FirewallData.firewallStruct.action = (radioAllowConnection.Checked) ? 1 : 0;
        }
    }
}
