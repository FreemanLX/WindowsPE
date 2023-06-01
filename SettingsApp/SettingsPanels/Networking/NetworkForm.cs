using System;
using System.Windows.Forms;
using SettingsApp.SettingsPanels.Networking;
using System.Net.NetworkInformation;

namespace WindowsPE
{
    public partial class NetworkForm : UserControl
    {
        public NetworkForm() => InitializeComponent();

        public void GetDnsAdresses()
        {
            /*NetworkListManager networkListManager = new NetworkListManager();
            IEnumNetworks connectedNetworks = networkListManager.GetNetworks(NLM_ENUM_NETWORK.NLM_ENUM_NETWORK_CONNECTED);
            int height = activeNetworksLabel.Location.Y + 15;
            foreach(INetwork network in connectedNetworks)
            {
                string type = "";
                switch (network.GetCategory())
                {
                     case NLM_NETWORK_CATEGORY.NLM_NETWORK_CATEGORY_PRIVATE:
                         type = "Private network";
                         break;
                     
                     case NLM_NETWORK_CATEGORY.NLM_NETWORK_CATEGORY_PUBLIC:
                         type = "Public network";
                         break;
                }

                string connectivityType = "Limited access";
                var connectivityTypeNLM = network.GetConnectivity();
                if((connectivityTypeNLM & NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV4_INTERNET) != 0 || (connectivityTypeNLM & NLM_CONNECTIVITY.NLM_CONNECTIVITY_IPV6_INTERNET) != 0)
                {
                    connectivityType = "Internet";
                }
                NetworkObject networkObject = new NetworkObject(network.GetName(), type, connectivityType)
                {
                    Location = new System.Drawing.Point(26, height)
                };
                privateNetworkLayout.Controls.Add(networkObject);
                networkObject.Show();
                height += networkObject.Size.Height + 10; - Windows PE Doesn't support NLM :(
            }*/

            //the .net way
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            int height = activeNetworksLabel.Location.Y + 15;
            foreach(NetworkInterface networkInterface in adapters)
            {
                IPInterfaceProperties properties = networkInterface.GetIPProperties();
                if(networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    string nicName = (!string.IsNullOrWhiteSpace(properties.DnsSuffix)) ? properties.DnsSuffix : networkInterface.Name;
                    NetworkObject networkObject = new NetworkObject(nicName, "Private Network", "Limited", networkInterface.NetworkInterfaceType.ToString())
                    {
                        Location = new System.Drawing.Point(26, height)
                    };
                    privateNetworkLayout.Controls.Add(networkObject);
                    networkObject.Show();
                    height += networkObject.Size.Height + 10;
                }
            }
        }

        private void networking_Load(object sender, EventArgs e)
        {
            GetDnsAdresses();
           NetworkChange.NetworkAddressChanged += new
            NetworkAddressChangedEventHandler(AddressChangedCallback);
        }

        private void AddressChangedCallback(object sender, EventArgs e)
        {
            GetDnsAdresses();
        }

        private void setNetworkLabel_Click(object sender, EventArgs e)
        {
            ChangeNetworkForm changeNetworkForm = new ChangeNetworkForm();
            changeNetworkForm.ShowDialog();
        }

        private void filesharingSettings_Click(object sender, EventArgs e)
        {

        }

        private void firewallSettings_Click(object sender, EventArgs e)
        {

        }

        private void privateNetworkLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
