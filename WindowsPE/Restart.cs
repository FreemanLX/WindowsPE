using System;
using System.Diagnostics;

namespace WindowsPE
{
    public static class Restart
    {
        public static void Application(string[] argv)
        {
            string arguments = "";
            for(int i = 0; i<argv.Length; i++)
            {
                arguments += argv[i] + " ";
            }
            Application(arguments);
        }

        public static void Application(string arguments)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(System.Windows.Forms.Application.ExecutablePath)
            {
                Arguments = arguments
            };
            Process.Start(processStartInfo);
        }
    }
}

