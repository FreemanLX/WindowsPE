using System.Windows.Forms;

namespace SettingsApp.SettingsPanels.Networking
{
    public partial class NetworkObject : UserControl
    {
        public NetworkObject(string dns, string networkType, string accessType, string connectionType)
        {
            InitializeComponent();
            this.networkDNS.Text = dns;
            this.networkTypeLabel.Text = networkType;
            this.accessTypeLabel.Text = "Access type: " + accessType;
            this.connectionTypeLabel.Text = "Connection: " + connectionType;
        }

        private void NetworkObject_Load(object sender, System.EventArgs e)
        {

        }
    }
}
