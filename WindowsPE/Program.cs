using System;
using System.Windows.Forms;

namespace WindowsPE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Data.Init();
            Data.color = Data.WinPEColors["Blue"];
            using(XMLSettings xMLSettings = new XMLSettings("settings.xml")){
                        xMLSettings.Read();
            }
            using(XMLSettings xMLSettings = new XMLSettings("settings.xml")){
                        xMLSettings.OSLoaded();
            }
            LoadingScreen.ShowScreen();
            Data.FormContainers.mainContainer = new MainContainer.MainContainer();
            System.Threading.Thread.Sleep(2000);
            LoadingScreen.CloseForm();
            Application.Run(Data.FormContainers.mainContainer);
        }
    }
} 
