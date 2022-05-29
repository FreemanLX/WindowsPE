using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Browser
{
    public partial class Metro : UserControl
    {
        public Metro() => InitializeComponent();
        public Panel Status => BrowserPanel;

        private void BrowserButton_Click(object sender, EventArgs e) => 
            System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + 
                "\\Browser\\browser.exe");
        private void CMDButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("cmd.exe");
        private void TaskmgrButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("taskmgr.exe");

        private void PowershellButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd.exe")
            {
                Arguments = "/k powershell.exe",
                CreateNoWindow = true
            });
        }
        private void SettingsButton_Click(object sender, EventArgs e) => new SettingsForm().Show();
        private void FileExplorerButton_Click(object sender, EventArgs e) => new File_explorer().Show();
        private void NotepadButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("notepad.exe");

        private void panel7_Click(object sender, EventArgs e)
        {

        }

        private void Metro_Load(object sender, EventArgs e)
        {
           
        }

    }
}
