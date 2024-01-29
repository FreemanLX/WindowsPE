using System;
using System.Windows.Forms;

namespace WindowsPE
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.settingsForm = new Settings.SettingsForm();
            Application.Run(Data.settingsForm);
        }   
    }
}
