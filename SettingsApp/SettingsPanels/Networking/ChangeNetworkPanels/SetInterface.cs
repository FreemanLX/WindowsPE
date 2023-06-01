using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace WindowsPE.Settings.Networking.ChangeNetworkPanels
{
    public partial class SetInterface : SettingsUserControl
    {
        public SetInterface()
        {
            InitializeComponent();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach(NetworkInterface networkInterface in networkInterfaces)
            {
                interfaceComboBox.Items.Add(networkInterface.Name);
            }
            interfaceComboBox.SelectedIndex = 0; //the first one
            connectionTypeComboBox.SelectedIndex = 1;
        }

        private void interfaceComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void connectionTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
