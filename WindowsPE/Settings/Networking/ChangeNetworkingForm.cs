using System;
using System.Windows.Forms;

namespace WindowsPE.Settings.Networking
{
    public partial class ChangeNetworkingForm : Form
    {
        public ChangeNetworkingForm() => InitializeComponent();

        private void ChangeNetworkingForm_Paint(object sender, PaintEventArgs e)
        {
            
        }

        IPListCheck iPv4ListCheck;
        IPListCheck iPv6ListCheck;
        private void ChangeNetworkingForm_Load(object sender, EventArgs e)
        {
            saveBtn.BackColor = cancelBtn.BackColor = Data.color;
            comboBox1.Items.AddRange(Data.Network.nic.ToArray());
            iPv4ListCheck = new IPListCheck();
            iPv6ListCheck = new IPListCheck();
            panelIPV4.Controls.Add(iPv4ListCheck);
            panelIPV6.Controls.Add(iPv6ListCheck);
            iPv6ListCheck.Show();
            iPv4ListCheck.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var IPv4data = iPv4ListCheck.RetrieveData();
            var IPv6data = iPv6ListCheck.RetrieveData();
            
            SetupNetworkInterface setupNetworkInterface = new SetupNetworkInterface(IPv4data["IP"], 
                IPv4data["SubnetMask"], 
                IPv4data["Gateway"], 
                new string[]{IPv4data["DNS1"], IPv4data["DNS2"] }, this.comboBox1.GetItemText(this.comboBox1.SelectedItem));
            setupNetworkInterface.SetStaticIP();
            this.Close();
        }
    }
}
