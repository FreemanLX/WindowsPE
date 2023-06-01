using System;
using WindowsPE;
using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall.AddNewRule
{
    public partial class RuleSelectPrograms : SettingsUserControl
    {
        public RuleSelectPrograms()
        {
            InitializeComponent();
        }

        private void radioSpecificProgram_CheckedChanged(object sender, EventArgs e)
        {
            browseBtn.Enabled = programPath.Enabled = radioSpecificProgram.Checked;
        }

        private void programPath_TextChanged(object sender, EventArgs e)
        {
            if(programPath.Text.Length > 0)
               Data.FirewallData.firewallStruct.program = programPath.Text;
        }

        public override bool CheckStatus()
        {
            if ((string.IsNullOrWhiteSpace(programPath.Text) || System.IO.File.Exists(programPath.Text)) && radioSpecificProgram.Checked)
            {
                MessageBox.Show("Please write a valid path for the selected program!"); 
                return false;
            }
            return true;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            //function to write the openfiledialog - microsoft.win32
        }
    }
}
