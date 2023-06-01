using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleSelectScope : SettingsUserControl
    {

        RuleSelectScopeSplitted remoteIP, localIP;
        public RuleSelectScope()
        {
            InitializeComponent();
            remoteIP = new RuleSelectScopeSplitted(true);
            localIP = new RuleSelectScopeSplitted();
            ruleSelectScopeTableLayout.Controls.Add(localIP, 0, 0);
            ruleSelectScopeTableLayout.Controls.Add(remoteIP, 0, 1);
        }


        public override bool CheckStatus()
        {
            if(!remoteIP.CheckStatus())
            {
                 MessageBox.Show("Insert the remote ip correctly!");
                 return false; 
            }
            if (!localIP.CheckStatus())
            {
                MessageBox.Show("Insert the local ip correctly!");
                return false;
            }
            return true;
        } 
    }
}
