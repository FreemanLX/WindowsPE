using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ButtonBehaviour()
        {
            searchPanel.Controls.Clear();
            searchPanel.Controls.Add(LoadingText);
            Data.FormContainers.searchMenu.Hide();
            //Data.FormContainers.mainContainer.isStartButtonClicked = false;
        }

        private void StartProcess(string processPath)
        {
            ButtonBehaviour();
            textBox1.Text = "What do you want to search?";
            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo(processPath){
                   UseShellExecute = true
            };
            System.Diagnostics.Process.Start(processStartInfo);
        }

        int locationY = 0;
        public void SearchFunction(string searchPattern, string path)
        {
           try
           { 
                DirectoryInfo DirectoryList = new DirectoryInfo(path);
                FileInfo[] files = DirectoryList.GetFiles();
                DirectoryInfo[] directories = DirectoryList.GetDirectories();
            
                foreach (FileInfo fileInfo in files)
                {
                    if(fileInfo.Name.ToLower().Contains(searchPattern.ToLower())){
                       LoadingText.Visible = false;
                       ApplicationStartIcon applicationStartIcon = new ApplicationStartIcon(fileInfo.Name, new Action(() => StartProcess(fileInfo.FullName)), Data.color, Icon.ExtractAssociatedIcon(fileInfo.FullName));
                       locationY += applicationStartIcon.Size.Height + 1;
                       applicationStartIcon.Location = new Point(10, locationY);
                       searchPanel.Controls.Add(applicationStartIcon); 
                       applicationStartIcon.Show();
                    }
                }

                foreach (DirectoryInfo directory in directories)
                {
                    SearchFunction(searchPattern, directory.FullName);
                }
            }
            catch
            {

            }
        
            
        }

        protected override void OnDeactivate(EventArgs e)
        {
            // Data.FormContainers.mainContainer.isStartButtonClicked = false;
            Hide();
            textBox1.Text = "What do you want to search?";
            if(searchTask != null)
               searchTask.Dispose();
            searchPanel.Controls.Clear();
            searchPanel.Controls.Add(LoadingText);
            base.OnDeactivate(e);
        }

        Task searchTask;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchPanel.Controls.Clear();
                searchPanel.Controls.Add(LoadingText);
                string drive = Environment.SystemDirectory;
                LoadingText.Visible = true;
                searchTask = Task.Run(new Action(() => SearchFunction(textBox1.Text, drive)));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
