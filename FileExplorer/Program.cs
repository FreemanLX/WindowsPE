﻿using System;
using System.Windows.Forms;

namespace FileExplorer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowsPE.File_explorer());
        }
    }
}