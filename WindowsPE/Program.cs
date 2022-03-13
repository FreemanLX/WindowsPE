using System;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace Browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string output = "";
            if(args.Length > 0)
            {
                ExternalMethods.ChangeScreenResolutionW(int.Parse(args[1]), int.Parse(args[0]), out output);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new System.Threading.
                              ThreadExceptionEventHandler(new WindowsPE.ThreadException().
                                OnThreadException);
            ///bool exists = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1;
            if (false)
            {
                Application.Run(new File_explorer());
            }
            else
            {
                Application.Run(new WindowsPE.LoadingScreen());
            }
        }
    }
} 
