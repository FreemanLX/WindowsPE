using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsPE.Settings
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();
            Data.Init();
            Data.ExtractDataFromRegistry();
            AdaptiveMethods.GetScreenResolutions();
        }
        
        public void ChangePanel(Control control)
        {
            SettingsPanel.SuspendLayout();
            try
            {
                UserControl controlTmp = SettingsPanel.GetControlFromPosition(1, 0) as UserControl;
                SettingsPanel.Controls.Remove(controlTmp);
                controlTmp.Dispose();
            }
            catch(Exception) {}
            if(control is UserControl)
            {
                control.Dock = DockStyle.Fill;
                control.Margin = new Padding(0, 0, 0, 0);
                control.Show();
                SettingsPanel.Controls.Add(control, 1, 0);
                SettingsPanel.ResumeLayout();
            }
        }
       
        private void Settings_Load(object sender, EventArgs e) 
        {
            executeTextBar.Add(@"Control Panel\System and Security", () => Data.settingsForm.ChangePanel(new FirewallForm()));
            executeTextBar.Add(@"Control Panel\Network and Internet", () => Data.settingsForm.ChangePanel(new NetworkForm()));
            executeTextBar.Add(@"Control Panel\Appearence and Personalization", () => Data.settingsForm.ChangePanel(new PersonalizationForm()));
            executeTextBar.Add(@"Control Panel\Display", () => Data.settingsForm.ChangePanel(new DisplayForm()));
            executeTextBar.Add(@"Control Panel", () => Data.settingsForm.ChangePanel(new Default_form()));
            ChangePanel(new Default_form());
        }

        private void entryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(executeTextBar.ContainsKey(entryTextBox.Text))
                {
                    executeTextBar[entryTextBox.Text].Invoke();
                }
                else
                {
                    Process.Start(entryTextBox.Text);
                    entryTextBox.Text = "Control Panel";
                }
            }
        }

        private void headerFwdBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void headerBackBtn_Click(object sender, EventArgs e)
        {

        }

        IDictionary<string, Action> executeTextBar = new Dictionary<string, Action>();

    }
}
