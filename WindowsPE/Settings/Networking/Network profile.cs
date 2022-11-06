using System;
using System.Windows.Forms;

namespace WindowsPE.Settings.Networking
{
    public partial class Network_profile : UserControl
    {
        public Network_profile(string physicalAddress, bool DHCP, string IPGateway, string IPAddress, string SubnetMask, string DNS, string physicalDescription)
        {
            InitializeComponent();
            physicalAddressLabel.Text += physicalAddress;
            dhcpLabel.Text += DHCP.ToString();
            gatewayLabel.Text += IPGateway;
            ipAddressesLabel.Text += IPAddress;
            subnetMaskLabel.Text += SubnetMask;
            dnsServersLabel.Text += " " + DNS;
            ethernetAdapterLabel.Text += physicalDescription;
        }

        private void Network_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
