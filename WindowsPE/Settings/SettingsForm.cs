using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Browser
{

    public partial class SettingsForm : Form
    {
       
        public SettingsForm()
        {
            InitializeComponent();
        }

        public void UserControlTheme(Control control)
        {
            foreach(Control subcontrol in control.Controls)
            {
                if(subcontrol is Button) subcontrol.BackColor = Data.color;
            }
        }

        public void Theme(Control control)
        {
            Invoke(new Action(() => {
                control.BackColor = Data.color;
                foreach(Control subcontrol in control.Controls)
                {
                    if(!(subcontrol is UserControl)) Theme(subcontrol);
                    else UserControlTheme(subcontrol);
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

        System.Threading.Thread themethread;
        private void Settings_Load(object sender, EventArgs e) {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ChangePanel(new DisplayForm());
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            themethread.Abort();   
            base.OnFormClosed(e);
        }

        private void NetworkClick(object sender, EventArgs e) => ChangePanel(new NetworkForm());

        private void AboutClick(object sender, EventArgs e) => ChangePanel(new ColorsForm());

        private void DisplayClick(object sender, EventArgs e) => ChangePanel(new DisplayForm());

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DefaultButtons()
        {
            foreach(Control control in GeneralSettingsPanel.Controls){
                if(control is Button){
                    control.TabStop = false;
                    //  control.FlatStyle = FlatStyle.Flat;
                    //control.FlatAppearance.BorderSize = 0;
                }
            }
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
            this.Close();
        }
    }
}
