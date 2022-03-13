using System;
using System.Drawing;
using System.Windows.Forms;
using SimpleWifi;

namespace Browser
{
    public partial class NetworkForm : UserControl
    {
        public NetworkForm() => InitializeComponent();

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        private void networking_Load(object sender, EventArgs e)
        {
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
                : (Data.Connected == true) ? "You are connected to the internet using ethernet cable" : "You are not connected to the internet";

            label3.Text = "Connect to WiFi\n";
        }

        public void button5_Click(object sender, EventArgs e) => new WifiConnection().ShowDialog();
    }
}
