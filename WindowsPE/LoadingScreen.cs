using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using Browser;

namespace WindowsPE
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void LoadingScreen_Shown(object sender, EventArgs e)
        {
            
            LoadingLabel.Text = "Loading: Initialize network card";
            if(AdaptiveMethods.WPEInitialization("WaitForNetworkW", "") != 0)
                 new Exception("Error in initializing the network card.");
            
            LoadingLabel.Text = "Loading: Initialize network adapter";
            if(AdaptiveMethods.WPEInitialization("InitializeNetworkW", "") != 0)
                  new Exception("Error in initializing the network adapter.");

            LoadingLabel.Text = "Loading: Get available screen resolutions";
            Thread thread = new Thread(() => Data.resolutions = AdaptiveMethods.GetScreenResolutions());
            thread.Start();
            while (thread.IsAlive)
            {
                Application.DoEvents();
            }
            LoadingLabel.Text = "Loading: Enable firewall adapter";
            int hResult = AdaptiveMethods.WPEInitialization("EnableFirewallW", "");
            Browser.Data.form = new Browser.Main(hResult);
            Browser.Data.form.Show();
            Hide();
        }
    }
}
