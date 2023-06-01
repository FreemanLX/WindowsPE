using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall
{
    public partial class FirewallStatus : UserControl
    {
        public FirewallStatus(string firewallType, bool enabled)
        {
            InitializeComponent();
            this.firewallType.Text = firewallType;
            if(!enabled)
                this.colorFirewall.BackColor = Color.Red;
        }
    }
}
