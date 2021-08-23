using System;
using System.Drawing;
using System.Windows.Forms;
using SimpleWifi;
using System.Threading;


namespace WindowsPE
{
    public partial class networking : UserControl
    {
        public networking() => InitializeComponent();

        Thread thread_theme;

        private void theme()
        {

            while (true)
            {
                Invoke(new Action(() =>
                {
                    this.BackColor = Data.theme;
                    Refresh();
                    foreach (Control control in this.Controls)
                    {
                        if (control is Label)
                        {
                            control.BackColor = Data.theme;
                            control.ForeColor = Data.fortheme;
                        }
                    }
                }));
                Thread.Sleep(50);
            }
        }


        protected override void OnHandleDestroyed(EventArgs e)
        {
            thread_theme.Abort();
            base.OnHandleDestroyed(e);
        }

        private void networking_Load(object sender, EventArgs e)
        {
            thread_theme = new Thread(() => theme());
            thread_theme.Start();
            Wifi wifi = new Wifi();
            if(wifi.NoWifiAvailable == true)
            {
                label3.Visible = false;
                button5.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label3.Location = new Point(label3.Location.X, 186);
                button5.Visible = true;
            }
            label4.Text = wifi.ConnectionStatus == WifiStatus.Connected
                ? "You are connected to the internet using WiFi!"
                : (Data.connected_to_internet == true) ? "You are connected to the internet using ethernet cable" : "You are not connected to the internet";

            label3.Text = "Connect to WiFi\n";
        }

        public void button5_Click(object sender, EventArgs e) => new connect_to_wifi().ShowDialog();
    }
}
