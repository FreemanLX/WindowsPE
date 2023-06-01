using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsPE.Algorithms;
using System.Net.Sockets;
using WindowsPE.Settings.Firewall;
using System.Drawing;

namespace WindowsPE.Settings
{
    public partial class FirewallForm : UserControl
    {

        Firewall.FirewallRules outfirewallRules, infirewallRules;

        public FirewallForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            outfirewallRules = new Firewall.FirewallRules("Outbound rules") {Dock = DockStyle.Fill};
            infirewallRules = new Firewall.FirewallRules("Inbound rules") {Dock = DockStyle.Fill };
        }

        public unsafe void GetFirewallData()
        {
            ExternalStructures.UnmanagedFirewallData* data;
            if (ExternalMethods.FirewallApi.GetFirewallData(&data, out int size) == 1)
            {
                  for(int i = 0; i<size; i++)
                  {   
                      ExternalStructures.UnmanagedFirewallData* ptr = data + i;
                      string profile = "";
                      if((ptr->profile & 0x2) != 0)
                           profile += "Private | ";
                      if((ptr->profile & 0x4) != 0)
                           profile += "Public | ";
                      if((ptr->profile & 0x1) != 0)
                           profile += "Domain | ";

                      insertFirewallData(ptr->outbound == 1, 
                                        Marshal.PtrToStringAnsi(ptr->name), 
                                        profile,
                                        (ptr->enabled == 1) ? "Yes" : "No",
                                        (ptr->action == 1) ? "Allow" : "Block",
                                        Marshal.PtrToStringAnsi(ptr->program),
                                        Marshal.PtrToStringAnsi(ptr->localAddress),
                                        Marshal.PtrToStringAnsi(ptr->remoteAddress),
                                        (ptr->protocol == 256) ? "*" : ((ProtocolType)ptr->protocol).ToString().ToUpper(),
                                        Marshal.PtrToStringAnsi(ptr->localPort),
                                        Marshal.PtrToStringAnsi(ptr->remotePort)
                      );
                  }
                  ExternalMethods.FirewallApi.FirewallDataClear((IntPtr)data, size);
            }
        }

        public void insertFirewallData(bool outbound, string name, string profile, string enabled, string action, string program, string localAddress, string remoteAddress, string protocol, string localPort, string remotePort)       
        {
            if (outbound)
               outfirewallRules.insertFirewallData(name, profile, enabled, action, program, localAddress, remoteAddress, protocol, localPort, remotePort);
            
            else infirewallRules.insertFirewallData(name, profile, enabled, action, program, localAddress, remoteAddress, protocol, localPort, remotePort);       
         }

        private void SetFirewallStatus_Click(object sender, EventArgs e)
        {
            ChangeFirewallStatus changeFirewallStatus = new ChangeFirewallStatus();
            changeFirewallStatus.ShowDialog();
            CheckFirewall();
        }

        /// <summary>
        /// Checks the status of firewall
        /// </summary>
        private void CheckFirewall()
        {

            int firewallStatusPrivate = ExternalMethods.FirewallApi.CheckFirewall(ExternalStructures.NET_FW_PROFILE_TYPE2.NET_FW_PROFILE2_PRIVATE);
            int firewallStatusPublic = ExternalMethods.FirewallApi.CheckFirewall(ExternalStructures.NET_FW_PROFILE_TYPE2.NET_FW_PROFILE2_PUBLIC);

            FirewallStatus privateFirewall = new FirewallStatus("Private networks", firewallStatusPrivate == 1);
            privateFirewall.Location = new Point(statusFirewallLabel.Location.X, statusFirewallLabel.Location.Y + statusFirewallLabel.Size.Height + 10);
            FirewallStatus publicFirewall = new FirewallStatus("Public networks", firewallStatusPrivate == 1);
            publicFirewall.Location = new Point(statusFirewallLabel.Location.X, privateFirewall.Location.Y + privateFirewall.Size.Height + 10);
            firewallContainer.Controls.Add(privateFirewall);
            firewallContainer.Controls.Add(publicFirewall);
        }

        /// <summary>
        /// Loads the firewall data.
        /// </summary>
        void LoadFirewallData()
        {
            infirewallRules.ClearTable();
            outfirewallRules.ClearTable();
       //     GetFirewallData();
            CheckFirewall();
        }

        /// <summary>
        /// Adds a new firewall rule
        /// </summary>
        private void firewallAddNewRule_Click(object sender, EventArgs e)
        {
            AddNewRuleFirewall addNewRuleFirewall = new AddNewRuleFirewall();
            addNewRuleFirewall.ShowDialog();
            LoadFirewallData();
        }

        private void firewallRefresh_Click(object sender, EventArgs e) => LoadFirewallData();

        private void optionsLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineDrawing_Click(object sender, EventArgs e)
        {

        }

        private void FirewallForm_Load(object sender, EventArgs e) {
        //    firewallLayoutPanel.SuspendLayout();
         //   firewallLayoutPanel.Controls.Add(infirewallRules, 0, 0);   
         //   firewallLayoutPanel.Controls.Add(outfirewallRules, 0, 1);  
            LoadFirewallData();
          //  firewallLayoutPanel.ResumeLayout();
        }

    }
}
