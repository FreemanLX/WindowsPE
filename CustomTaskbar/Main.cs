using System.Windows.Forms;
using System;
using Microsoft.Win32;

namespace WindowsPE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Focus();
        }

        public const int WS_EX_TOPMOST = 0x00000008;  
        public const int WS_EX_TOOLWINDOW = 0x00000080;  

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams pm = base.CreateParams;
                pm.ExStyle |= (WS_EX_TOOLWINDOW | WS_EX_TOPMOST);  
                return pm;
            }
        }

        public static string[] MainPrograms = new string[]
         {
             @"C:\Windows\system32\cmd.exe",
             @"fileexplorer.exe",
             @"settingsapp.exe",
             @"C:\Windows\system32\taskmgr.exe"
         };

        PictureBox[] pictureBoxes;
        int i = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
            SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;
            pictureBoxes = new PictureBox[MainPrograms.Length];
            foreach(string program in MainPrograms)
            {
                pictureBoxes[i] = new PictureBox
                {
                    BackgroundImage = ExternalMethods.GetLargeIcon(program).ToBitmap(),
                    BackgroundImageLayout = ImageLayout.Center,
                };
                pictureBoxes[i].Click += (sTmp, eTmp) =>
                {
                    System.Diagnostics.Process.Start(program);
                };
                taskLayoutContainer.Controls.Add(pictureBoxes[i], i + 1, 0);
                i++;
            }

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing) return;
            base.OnFormClosing(e);
        }


        private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
             System.Threading.Thread.Sleep(500);
             ExternalMethods.RegisterAccessBar(this.Handle, this.Height);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            ExternalMethods.RegisterAccessBar(this.Handle, this.Height);
        }
    }
}
