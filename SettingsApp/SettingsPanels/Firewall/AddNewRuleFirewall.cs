using System.Windows.Forms;
using System.Collections.Generic;
using WindowsPE.Settings;
using WindowsPE.Settings.Firewall.AddNewRule;

namespace WindowsPE
{
    public partial class AddNewRuleFirewall : Form
    {
        List<SettingsUserControl> array;
        int currentIndex = 0;
        

        public AddNewRuleFirewall()
        {
            InitializeComponent();
            Data.FirewallData.firewallStruct = new AdaptiveMethods.firewallData()
            {
                 name = "", program = "", remoteAddress = "", remotePort = "", localAddress = "", localPort = ""
            };
            
            array = new List<SettingsUserControl>
            {
                new RuleType(),
                new RuleSelectPrograms(),
                new NewRulePort(),
                new RuleSelectScope(),
                new RuleAction(),
                new RuleProfile()
            };
            SetControl(array[currentIndex]);
        }

        public void SetControl(SettingsUserControl ucp)
        {
           firewallLayout.Controls.Remove(firewallLayout.GetControlFromPosition(0, 1));
           ucp.Dock = DockStyle.Fill;
           ucp.Margin = new Padding(10, ucp.Margin.Top, ucp.Margin.Right, ucp.Margin.Bottom);
           firewallLayout.Controls.Add(ucp, 0, 1); //the 2nd row
        }

        private void Cancel_Click(object sender, System.EventArgs e) => Close();

        private void NextBtn_Click(object sender, System.EventArgs e)
        {
              SettingsUserControl tmp = firewallLayout.GetControlFromPosition(0, 1) as SettingsUserControl;
              if(tmp.CheckStatus()) 
              {
                    if(NextBtn.Text == "Finish")
                    {
                         //this is the case when finishing
                         if (!AdaptiveMethods.addANewRuleFun(Data.FirewallData.firewallStruct))
                         {
                             MessageBox.Show("Unable to add rule. Please wait later!", "Firewall");
                         }
                         Close();
                         return;
                    }
                    try 
                    {
                         SetControl(array[++currentIndex]);
                         if(currentIndex > 0) BackBtn.Visible = true;
                         if(currentIndex == array.Count - 1) NextBtn.Text = "Finish";
                    }
                    catch
                    {
                        return;
                    }
              }
        }

        private void BackBtn_Click(object sender, System.EventArgs e)
        {
            SetControl(array[--currentIndex]);
            if(currentIndex == 0) BackBtn.Visible = false;
            if(NextBtn.Text == "Finish" && currentIndex < array.Count - 1) NextBtn.Text = "Next >";
        }
    }
}
