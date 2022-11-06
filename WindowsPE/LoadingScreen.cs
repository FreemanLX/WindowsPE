using System;
using System.Windows.Forms;
using System.Threading;
using WindowsPE;
using System.Reflection;

namespace WindowsPE
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen() => InitializeComponent();        

        private delegate void CloseDelegate();
        private static Thread loadingMainFormThread;
        private static LoadingScreen loadingScreen;

        static public void ShowScreen()
        {
            if(loadingScreen != null) return;
            loadingScreen = new LoadingScreen
            {
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None
            };
            loadingMainFormThread = new Thread(new ThreadStart(ShowForm))
            {
                IsBackground = true
            };
            loadingMainFormThread.SetApartmentState(ApartmentState.STA);
            loadingMainFormThread.Start();
        }

        static private void ShowForm()
        {
            if(loadingScreen != null) Application.Run(loadingScreen);
        }

        static public void CloseForm()
        {
            if(loadingScreen != null)
            loadingScreen?.Invoke(new CloseDelegate(CloseInternal));
        }

        static private void CloseInternal()
        {
            if(loadingScreen != null)
            {
                loadingScreen.Close();
                loadingScreen = null;
            }
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            Focus();
            Show();
        }
    }
}
