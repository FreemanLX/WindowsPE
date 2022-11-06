using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsPE
{
    public partial class Startmenu : Form
    {

        private bool SearchOccurring = false;
        private bool DefaultText = true;
        private bool SearchFinished = false;
        private int searchTextLen = 0;
        private Thread textWritingThread = null;
        private Thread searchThread = null;
        PictureBox loadingDots = null;
        
        public Startmenu()
        {
            InitializeComponent();
        }

        private static void ButtonBehaviour()
        {
            Data.FormContainers.startMenu.Hide();
            Data.FormContainers.mainContainer.isStartButtonClicked = false;
        }

        private void OnTextWriting()
        {
           while(true)
           {    
                if(SearchOccurring == true)
                {
                    if(searchTextLen != searchText.Text.Length)
                    {
                        searchTextLen = searchText.Text.Length;
                        if(searchThread.IsAlive)
                            searchThread.Abort();
                        SearchOccurring = false;
                    }
                    if(searchTextLen == 0) {
                        Invoke(new Action(() => 
                        {
                            searchText.Text = "What do you want to search?";
                            ApplicationsContext.Controls.Clear();
                            loadingDots.Dispose();
                            locationY = 0;
                            StartMenuLoading();
                            
                        }));
                        DefaultText = true;
                        return;
                    }
                }
               
                if(searchText.Text.Length > 0 && !DefaultText && !SearchOccurring)
                {
                    locationY = 0;
                    this.MouseWheel -= new MouseEventHandler(ScrollMouseEvent);
                    Invoke(new Action(() => {
                        ApplicationsContext.Controls.Clear();
                        loadingDots = new PictureBox
                        {
                            BackgroundImageLayout = ImageLayout.Center,
                            Image = Properties.Resources._294__7_,
                            Location = new Point(3, 0),
                            Size = new Size(325, 19),
                            TabIndex = 0,
                            TabStop = false,
                            Visible = true
                        };
                        ApplicationsContext.Controls.Add(loadingDots);
                    }));
                    
                    searchTextLen = searchText.Text.Length;
                    SearchOccurring = true;
                    searchThread = new Thread(() => LinearSearchExt(searchText.Text, "C:\\Windows\\System32"));
                    searchThread.Start();                
                }
                if (SearchFinished)
                {
                    searchThread.Abort();
                    SearchFinished = false;
                    Invoke(new Action(() => 
                    {
                       loadingDots.Visible = false;
                       loadingDots.Dispose();
                       ScrollBar();
                    }));
                }
                Thread.Sleep(500);
           }
        }

        private void LinearSearchExt(string searchpatten, string path)
        {
             LinearSearch(searchpatten, path);
             SearchFinished = true;
        }
        
        private void LinearSearch(string searchpattern, string path)
        {
            if (!Directory.Exists(path)) return;
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] directories = null;
            FileInfo[] files = null;
            try
            {
               directories = directoryInfo.GetDirectories();
               files = directoryInfo.GetFiles();
            }
            catch (Exception)
            {
                return;
            }
            if(files.Length == 0 && directories.Length == 0) return;

            if(files.Length > 0)
            foreach(FileInfo fileInfo in files)
            {
                if (!fileInfo.Name.ToLower().Contains(searchpattern.ToLower())) continue;
                //the files searched based on that pattern.
                Invoke(new Action(() => 
                {
                    ApplicationStartIcon applicationStartIcon = new ApplicationStartIcon(fileInfo.Name, new Action(() => StartProcess(fileInfo.FullName)), Data.color, Icon.ExtractAssociatedIcon(fileInfo.FullName));
                    locationY += applicationStartIcon.Size.Height + 1;
                    applicationStartIcon.Location = new Point(10, locationY);
                    ApplicationsContext.Controls.Add(applicationStartIcon); 
                    applicationStartIcon.Show(); 
                }));
            }
            if(directories.Length > 0)
            {
                foreach(DirectoryInfo directory in directories)
                {
                    LinearSearch(searchpattern, directory.FullName);
                }
            }
        }
        
        private static void StartProcess(string processPath)
        {
            ButtonBehaviour();
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo(processPath){
                   UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }
        

        private static void LoadForm(Form form)
        {
            ButtonBehaviour();
            LoadingScreen.ShowScreen();
            Data.FormContainers.mainContainer.LoadForm(form);
            LoadingScreen.CloseForm();
        }


        private void ScrollBar()
        {
            if(locationY > ApplicationsContext.Height)
            {
                ApplicationsContext.VerticalScroll.Visible = false;
                ApplicationsContext.AutoScroll = false;
                vScrollBar = new VScrollBar
                {
                    Dock = DockStyle.Right
                };
                
                vScrollBar.Minimum = 0;
                vScrollBar.Maximum = locationY;
                vScrollBar.LargeChange = locationY / 8;
                vScrollBar.SmallChange = locationY / 8;
                ApplicationsContext.VerticalScroll.Maximum = locationY;
                ApplicationsContext.VerticalScroll.Minimum = 0;
                vScrollBar.Visible = false;

                vScrollBar.Scroll += (senderScroll, eventSc) =>
                {
                    ApplicationsContext.VerticalScroll.Value = vScrollBar.Value;
                };
            }
        }

        private void StartMenuLoading()
        {
            char letter = ' ';
            DirectoryInfo programdata = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Microsoft\Windows\Start Menu\Programs");
            FileInfo[] Filesinfo = programdata.GetFiles();
            this.DoubleBuffered = true;
            Thread.Sleep(1000);
            foreach(FileInfo application in Filesinfo)
            {
               if(letter != application.Name[0])
               {
                   letter = application.Name[0];
                   ApplicationLetter applicationLetter = new ApplicationLetter(letter.ToString().ToUpper());
                   locationY += applicationLetter.Size.Height + 10;
                   applicationLetter.Location = new Point(10, locationY);
                   Invoke(new Action(() => {
                       ApplicationsContext.Controls.Add(applicationLetter);
                       applicationLetter.Show();
                   }));
               }
               ApplicationStartIcon applicationStartIcon = new ApplicationStartIcon(application.Name, new Action(() => StartProcess(application.FullName)), Data.color, Icon.ExtractAssociatedIcon(application.FullName));
               locationY += applicationStartIcon.Size.Height + 1;
               applicationStartIcon.Location = new Point(10, locationY);
               Invoke(new Action(() => {
                   ApplicationsContext.Controls.Add(applicationStartIcon); 
                   applicationStartIcon.Show();
                   ScrollBar();
                }));
            }
        }

        VScrollBar vScrollBar;
        int locationY = 0;
        private async void Startmenu_Load(object sender, EventArgs e)
        {
         //   FormBorderStyle = FormBorderStyle.None;
         //   this.Location = new Point(0, Data.screenResolution.Height - Data.FormContainers.startMenu.Height - ActivityList.Height);
            textWritingThread = new Thread(() => OnTextWriting());
            textWritingThread.Start();
            loadingDots = new PictureBox
            {
                            BackgroundImageLayout = ImageLayout.Center,
                            Image = Properties.Resources._294__7_,
                            Location = new Point(3, 0),
                            Size = new Size(325, 19),
                            TabIndex = 0,
                            TabStop = false,
                            Visible = true
            };
            Invoke(new Action(() => {
                ApplicationsContext.Controls.Add(loadingDots);
                loadingDots.Show();
            }));
            await Task.Run(() => StartMenuLoading());
            loadingDots.Visible = false;
            loadingDots.Dispose();
            MouseWheel += new MouseEventHandler(ScrollMouseEvent);
            Controls.Add(vScrollBar);
           // StartMenuLoading();
        }

        private void ScrollMouseEvent(object sender, MouseEventArgs e)
        {
            ApplicationsContext.Focus();
            int deltaScroll = locationY / 16;
            if(e.Delta > 0)
            { 
                if(vScrollBar.Value - deltaScroll >= vScrollBar.Minimum)
                {
                     vScrollBar.Value -= deltaScroll;
                }
                else
                {
                    vScrollBar.Value = vScrollBar.Minimum;
                }
            }
            else 
            {
                if(vScrollBar.Value + deltaScroll <= vScrollBar.Maximum)
                {
                     vScrollBar.Value += deltaScroll;
                }
                else
                {
                    vScrollBar.Value = vScrollBar.Maximum;
                }
            }
            ApplicationsContext.VerticalScroll.Value = vScrollBar.Value;
        }


        private void startMenuLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnDeactivate(EventArgs e)
        {
            Data.FormContainers.mainContainer.isStartButtonClicked = false;
            Hide();
            base.OnDeactivate(e);
        }

        private void ApplicationsContext_Scroll(object sender, ScrollEventArgs e)
        {
            ApplicationsContext.Invalidate();
        }

        private void FileExplorer_Click_1(object sender, EventArgs e)
        {
             LoadForm(new File_explorer(){FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, ShowInTaskbar = false, TopLevel = false, TopMost = false});
        }

        private void Settings_Click_1(object sender, EventArgs e)
        {
            LoadForm(new SettingsForm(){FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, ShowInTaskbar = false, TopLevel = false, TopMost = false});
        }

        private void Power_Click(object sender, EventArgs e)
        {
            AdaptiveMethods.WPEInitialization("RebootW", "");
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void searchText_Click(object sender, EventArgs e)
        {
            if(DefaultText)
            {
               searchText.Clear();
               DefaultText = false;
            }
        }
    }
}
