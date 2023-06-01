using System.Windows.Forms;

namespace WindowsPE.Settings.Firewall
{
    public partial class FirewallRules : UserControl
    {
        public FirewallRules(string headerName)
        {
            InitializeComponent();
            headerTitle.Text = headerName;
        }

        public void ClearTable() => dataFirewall.Rows.Clear();
        public void insertFirewallData(string name, string profile, string enabled, string action, string program, string localAddress, string remoteAddress, string protocol, string localPort, string remotePort) => dataFirewall.Rows.Add(name, profile, enabled, action, program, localAddress, remoteAddress, protocol, localPort, remotePort);
        public void FirewallRules_Load(object sender, System.EventArgs e) => dataFirewall.DefaultCellStyle.SelectionBackColor = Data.color;

        private void dataFirewall_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete rule"));
                m.Show(dataFirewall, e.Location);
            }
        }
    }
}
