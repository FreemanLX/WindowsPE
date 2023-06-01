using System;
using System.Windows.Forms;
using WindowsPE.Settings;

namespace WindowsPE
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

        public void Theme()
        {
            //GeneralSettingsPanel.BackColor = Data.color;
       //     TableLayoutControlCollection controlCollection = GeneralSettingsPanel.Controls;
        //    foreach(Control control in controlCollection)
            {
       //         control.BackColor = Data.color;
            }
//SettingsPanel.Refresh();
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
            Theme();
            ChangePanel(new PersonalizationForm());
        }

        private void NetworkClick(object sender, EventArgs e) => ChangePanel(new NetworkForm());
        private void DisplayClick(object sender, EventArgs e) => ChangePanel(new DisplayForm());
        private void PersonalizationBtn_Click(object sender, EventArgs e) => ChangePanel(new PersonalizationForm());
        private void FilesharingSettingBtn_Click(object sender, EventArgs e) => ChangePanel(new FilesharingForm());
        private void FirewallFormBtn_Click(object sender, EventArgs e) => ChangePanel(new FirewallForm());

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void networkLabel_Click(object sender, EventArgs e)
        {
            ChangePanel(new NetworkForm());
        }

        private void securityLabel_Click(object sender, EventArgs e)
        {
            ChangePanel(new FirewallForm());
        }

        private void personalizationLabel_Click(object sender, EventArgs e)
        {
            ChangePanel(new PersonalizationForm());
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
