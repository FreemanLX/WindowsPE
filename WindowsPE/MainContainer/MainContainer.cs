using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsPE.MainContainer
{
    public partial class MainContainer : Form
    {
        public MainContainer() => InitializeComponent();

        public void SetResolution()
        {
            int screenHeight = 0;
            int screenWidth = 0;
            while(true)
            {
                if(Data.screenResolution.Height != screenHeight || Data.screenResolution.Width != screenWidth ){
                        Invoke(new Action(() => {
                            Size = Data.screenResolution;
                            FormBorderStyle = FormBorderStyle.None;
                            WindowState = FormWindowState.Maximized;
                         }));
                        screenWidth = Data.screenResolution.Width;
                        screenHeight = Data.screenResolution.Height;
                }
                Thread.Sleep(500);
            }
        }

        public void CheckInternet()
        {
            while (true)
            {
                if (ExternalMethods.InternetGetConnectedState(out int desc, 0) != Data.Network.Connected)
                {
                    Data.Network.Connected = !Data.Network.Connected;
                    EthernetPictureBox.Invoke(new Action(() => EthernetPictureBox.Visible = Data.Network.Connected));
                }
                Thread.Sleep(500);
            }
        }

        public void SetBackgroundImage()
        {   
            while (true)
            {
                if(Data.fit != BackgroundImageLayout || Data.image != BackgroundImage){
                    Invoke(new Action(() => {
                        BackgroundImage = Data.image;
                        BackgroundImageLayout = Data.fit;
                    }));
                }
                Thread.Sleep(500);
            }
        }


        Thread ResolutionThread, EthernetThread, BackgroundTheme;
        private async void MainContainer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            await Task.Run(() => 
            {
                AdaptiveMethods.GetFileSharing();
                AdaptiveMethods.GetScreenResolutions();
                if(Data.FormContainers.OSLoaded == false)
                {
                    if(AdaptiveMethods.WPEInitialization("WaitForNetworkW", "") != 0)
                         new Exception("Error in initializing the network card.");
            
                    if(AdaptiveMethods.WPEInitialization("InitializeNetworkW", "") != 0)
                          new Exception("Error in initializing the network adapter.");

                    if(AdaptiveMethods.WPEInitialization("EnableFirewallW", "") != 0)
                          new Exception("Error in enabling Firewall");

                    Data.FormContainers.OSLoaded = true;
                    using (UpdateXML updateXML = new UpdateXML("settings.xml"))
                    {
                        updateXML.Set("Loaded", Data.FormContainers.OSLoaded.ToString());
                    }
                }
                if(System.IO.File.Exists(Data.WallpaperPath)) Data.image = new Bitmap(Data.WallpaperPath);
                
            });
            //Design
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ActivityList.Margin = new Padding(0, 0, 0, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            if(Data.image != null) BackgroundImage = Data.image;
            ContainerLayout.Margin = new Padding(0, 0, 0, 0);
            Data.FormContainers.searchMenu = new Search
            {
                Visible = false,
                ShowInTaskbar = false,
            };

            //Saving the data
            Data.FormContainers.mainContainer = this;
            
            //Enabling The Threads...
            ResolutionThread = new Thread(() => SetResolution());
            ResolutionThread.Start();
            EthernetThread = new Thread(() => CheckInternet());
            EthernetThread.Start();
            BackgroundTheme = new Thread(() => SetBackgroundImage());
            BackgroundTheme.Start();
        }

        public bool isStartButtonClicked = false;
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ResolutionThread.Abort();
            EthernetThread.Abort();
            BackgroundTheme.Abort();
            base.OnFormClosed(e);
        }

        private void startPictureBox_Click(object sender, EventArgs e)
        {
            if(isStartButtonClicked == true)
            {
                Data.FormContainers.startMenu.Close();
                isStartButtonClicked = false;
                return;
            }
            isStartButtonClicked = true;
            Data.FormContainers.startMenu = new Startmenu
            {
                   Visible = false,
                   ShowInTaskbar = false,
                   FormBorderStyle = FormBorderStyle.None
            };
            Data.FormContainers.startMenu.Location = new Point(0, Data.screenResolution.Height - Data.FormContainers.startMenu.Height - ActivityList.Height);
            Data.FormContainers.startMenu.Refresh();
            Data.FormContainers.startMenu.Show();
            Data.FormContainers.startMenu.BringToFront(); 
        }

        private void startPictureBox_MouseHover(object sender, EventArgs e) => startPictureBox.BackColor = Data.color;
        private void startPictureBox_MouseLeave(object sender, EventArgs e) => startPictureBox.BackColor = Color.Transparent;
        private void EthernetPictureBox_MouseHover(object sender, EventArgs e) => EthernetPictureBox.BackColor = Data.color;
        private void EthernetPictureBox_MouseLeave(object sender, EventArgs e) => EthernetPictureBox.BackColor = Color.Transparent;

        public void CloseForm(Control form)
        {
            foreach(Control control in TaskbarContainer.Controls)
            {
                if((control as ApplicationStartIcon).Tag == (uint)form.Handle.ToInt32())
                {
                     int columnID = TaskbarContainer.GetColumn(control);
                     TaskbarContainer.ColumnStyles.RemoveAt(columnID);
                     TaskbarContainer.Controls.Remove(control); // cleaning control    
                     TaskbarContainer.ColumnCount--;
                }
            }
        }

        public void LoadForm(Control form)
        {
            try
            {
               FormContainer.Controls.Clear();
               Thread.Sleep(1000);
               if(form is Form || form is UserControl)
               {
                    Invoke(new Action(() => 
                    {
                        TaskbarContainer.ColumnStyles.Insert(TaskbarContainer.ColumnCount - 1, new ColumnStyle(SizeType.Absolute, 150));
                        ApplicationStartIcon icons = new ApplicationStartIcon(form.Text, new Action(() => form.Show()), Data.color){Dock = DockStyle.Fill };
                        TaskbarContainer.Controls.Add(icons, TaskbarContainer.ColumnCount - 1, 0);
                        icons.Tag = (form is UserControl) ? (uint) (form as UserControl).Handle.ToInt32() : (uint) (form as Form).Handle.ToInt32();
                        TaskbarContainer.ColumnCount++;
                    }));
                    form.Show();
                    FormContainer.Controls.Add(form);
               }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
            
    }
}
