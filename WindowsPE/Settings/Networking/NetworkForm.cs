using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using WindowsPE.Settings.Networking;
using System.Threading.Tasks;

namespace WindowsPE
{
    public partial class NetworkForm : UserControl
    {
        public NetworkForm() => InitializeComponent();

        protected override void OnHandleDestroyed(EventArgs e) => base.OnHandleDestroyed(e);

        internal int CheckIP(string IP)
        { 
            IPAddress iPAddress;
            if(IPAddress.TryParse(IP, out iPAddress))
            {
                switch (iPAddress.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork: return 0;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6: return 1;
                    default: return 2;
                }
            }
            return 2;
        }

        public void ShowNetworkInterfaces()
        {
            
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Data.Network.nic = new System.Collections.Generic.List<string>();
            if (nics == null || nics.Length < 1)
            {
                return;
            }

            int y = 0;
            foreach (NetworkInterface adapter in nics)
            {
                string ipv4 = "";
                string ipv6 = "";
                string mask = "";
                string gateway = "";
                foreach(UnicastIPAddressInformation unicastIPAddressInformation in adapter.GetIPProperties().UnicastAddresses)
                {
                     switch (unicastIPAddressInformation.Address.AddressFamily)
                     {
                        case System.Net.Sockets.AddressFamily.InterNetwork:
                              ipv4 += unicastIPAddressInformation.Address.ToString();
                              mask += unicastIPAddressInformation.IPv4Mask.ToString();
                              break;

                        case System.Net.Sockets.AddressFamily.InterNetworkV6: 
                              ipv6 += unicastIPAddressInformation.Address.ToString();
                              break;

                        default: continue;
                     }

                }

                foreach(GatewayIPAddressInformation gatewayIPAddressInformation in adapter.GetIPProperties().GatewayAddresses)
                {
                    try
                    {
                        gateway = gatewayIPAddressInformation.Address.ToString();
                    }
                    catch
                    {
                        continue;
                    }
                }
                if(gateway == "") continue;
                gateway = (gateway == "") ? " None" : " " + gateway;
                ipv4 = (ipv4 == "") ? " None" : ipv4;
                ipv6 = (ipv6 == "") ? " None" : ipv6;            
                string ip = " [IPV4: " + ipv4 + " IPV6: " + ipv6 + " ]";
                string DNS = (adapter.GetIPProperties().DnsSuffix == "") ? " None" : adapter.GetIPProperties().DnsSuffix;
                string description = (adapter.Description == "") ? " None" : adapter.Description;
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Network_profile networkForm = new Network_profile(
                adapter.GetPhysicalAddress().ToString(),
                true,
                gateway, ip, mask, DNS, description); 
                Data.Network.nic.Add(description);
                networkForm.Location = new Point(label5.Location.X, y);
                y+= networkForm.Size.Height;
                Invoke(new Action(()=>{
                    NetworkPanel.Controls.Add(networkForm);
                    networkForm.Show();
                }));
            }
        }

        private async void networking_Load(object sender, EventArgs e)
        {
            networkSettingsBtn.BackColor = Data.color;
            await Task.Run(() => ShowNetworkInterfaces());
        }

        private void button1_Click(object sender, EventArgs e) {
            new ChangeNetworkingForm().ShowDialog();
            ShowNetworkInterfaces();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
