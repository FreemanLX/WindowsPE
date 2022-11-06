using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using WindowsPE.Settings;

namespace WindowsPE
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void Theme(Control control)
        {
            Invoke(new Action(() => {
                control.BackColor = Data.color;
                foreach(Control subcontrol in control.Controls)
                {
                    if(!(subcontrol is UserControl)) Theme(subcontrol);
                }
            }));
        }
        
        public void ChangePanel(Control control)
        {
            try
            {
                SettingsPanel.Controls.Remove(SettingsPanel.GetControlFromPosition(1, 0));
            }
            catch(Exception) {}
            if(control is UserControl)
            {
                control.Dock = DockStyle.Fill;
                control.Show();
                SettingsPanel.Controls.Add(control, 1, 0);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
           themethread.Abort();
           base.OnClosing(e);
        }

        Thread themethread;
        private void Settings_Load(object sender, EventArgs e) 
        {
            FormBorderStyle = FormBorderStyle.None;
            Focus();
            Show();
            ChangePanel(new PersonalizationForm());
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            themethread.Abort();   
            base.OnFormClosed(e);
        }

        private void NetworkClick(object sender, EventArgs e) => ChangePanel(new NetworkForm());
        private void DisplayClick(object sender, EventArgs e) => ChangePanel(new DisplayForm());

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) => ChangePanel(new AboutForm());
        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            themethread = new Thread(() => {  
               while(true){
                    Theme(SettingsPanel);
                    Invoke(new Action(() => SettingsPanel.Refresh()));
                    Thread.Sleep(200);
               }
            });
            themethread.Start();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Data.FormContainers.mainContainer.CloseForm(this);
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void personalizationBtn_Click(object sender, EventArgs e) => ChangePanel(new PersonalizationForm());

        private void button2_Click(object sender, EventArgs e) => ChangePanel(new FilesharingForm());

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePanel(new FirewallForm());
        }
    }
}
