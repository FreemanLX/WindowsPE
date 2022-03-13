using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace Browser
{
    public partial class Main : Form
    {
        int hResult = 0;
        public Main(int result) 
        {
            InitializeComponent();
            hResult = result;
        }


        public void ThreadedMovingForm(Form form, bool dialog = false)
        {
            if (dialog == false) form.Show();
            else form.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ResolutionThread.Abort();
            EthernetThread.Abort();
            ThemeThread.Abort();
            base.OnFormClosed(e);
        }

        public void CheckInternet()
        {
            while (true)
            {
                bool AvailableConnection = false;
                try
                {
                     AvailableConnection = new Ping().Send("google.com", 1000, new byte[32], new PingOptions()).Status == 0;
                }
                catch{}
                if (AvailableConnection != Data.Connected)
                {
                    Data.Connected = AvailableConnection;
                    EthernetPictureBox.Invoke(new Action(() => EthernetPictureBox.Visible = AvailableConnection));
                }
                System.Threading.Thread.Sleep(100);
            }
        }
        


        public void SetResolution()
        {
            while(true){
                
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                if(Data.screenHeight != screenHeight || Data.screenWidth != screenWidth ){
                    Invoke(new Action((() =>
                    {
                         EthernetPictureBox.Location = new Point(EthernetPictureBox.Location.X, screenHeight - 60);
                         StartButton.Location = new Point(StartButton.Location.X, screenHeight / 2 - 20);
                         ActivityList.Location = new Point(screenWidth - ActivityList.Size.Width, 0);
                         ActivityList.Size = new Size(ActivityList.Size.Width, screenHeight);
                         MetroObject.Size = new Size(screenWidth - 50, screenHeight - 200);
                         Data.screenHeight = screenHeight;
                         Data.screenWidth = screenWidth;
                    })));
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            
        }


        System.Threading.Thread EthernetThread, ThemeThread, ResolutionThread;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(hResult != 0)
            MessageBox.Show("Unable to enable firewall adapter. HResult code: " + hResult);
            this.Name = "Explorer";
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ResolutionThread = new System.Threading.Thread(() => SetResolution());
            ResolutionThread.Start();
            EthernetThread = new System.Threading.Thread(() => CheckInternet());
            EthernetThread.Start();
            StartButton.FlatAppearance.BorderSize = 0;
            MetroObject.Scroll += new ScrollEventHandler(OnScroll);
            try
            {
                BackgroundImageLayout = ImageLayout.Stretch;
                string path = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\Web\Screen\img106.jpg";
                Data.image = new Bitmap(path);
                BackgroundImage = Data.image;
                Refresh();
            }
            catch (Exception exc){
                MessageBox.Show(exc.Message);
            }
            ThemeThread = new System.Threading.Thread(() => SetTheme());
            ThemeThread.Start();
            Data.form = this;
        }

        private void SetPanelColors()
        {
            foreach(Control panelcontrol in this.MetroObject.Controls){
                if(panelcontrol is Panel){
                    panelcontrol.BackColor = Data.color;
                    panelcontrol.BackColor = Color.FromArgb(Data.opaque, Data.color);
                    foreach(Control control in panelcontrol.Controls)
                    {
                        control.BackColor = Color.Transparent;
                    }
                }
            }
        }

        public void SetBackgroundImage()
        {

            BackgroundImage = Data.image;
            BackgroundImageLayout = (ImageLayout)Data.fit;
            Refresh();
        }
        private void SetTheme()
        {
            while (true)
            {
                if(Data.fit != (int)BackgroundImageLayout || Data.image != BackgroundImage)
                {
                    Invoke(new Action(() =>
                    {
                        SetBackgroundImage();
                    }));
                }
                if(this.MetroObject.Status.BackColor != Color.FromArgb(Data.opaque, Data.color))
                {
                    Invoke(new Action(() =>
                    {
                        SetPanelColors();
                    }));
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void metro1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Location.X == Screen.PrimaryScreen.Bounds.Width - 10)
            {
                ActivityList.Visible = true;
            }
            if(e.Location.X < ActivityList.Location.X){
                 ActivityList.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to restart?", "Restart request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    WindowsPE.AdaptiveMethods.WPEInitialization("RebootW", "");
                }
                catch 
                {

                }
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {

        }
        
  
    }  
     


}
