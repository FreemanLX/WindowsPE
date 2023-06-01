using System.Windows.Forms;

namespace WindowsPE.Settings.Networking.ChangeNetworkPanels
{
    public partial class SetIPAdress : SettingsUserControl
    {
        SetIPAddressDNS dns;
        public SetIPAdress()
        {
            InitializeComponent();            
        }

        private void SetIPAdress_Load(object sender, System.EventArgs e)
        {
            dns = new SetIPAddressDNS();

        }

        public bool ValidateSettings()
        {
            return true;

        }
    }
}
