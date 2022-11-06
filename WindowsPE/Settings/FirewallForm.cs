using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPE.Settings
{
    public partial class FirewallForm : UserControl
    {
        public FirewallForm()
        {
            InitializeComponent();
            dataGridView2.DefaultCellStyle.SelectionBackColor = Data.color;
            dataOutboundFirewall.DefaultCellStyle.SelectionBackColor = Data.color;      
        }

        private void GetData()
        {
            System.Threading.Thread.Sleep(200);
            AdaptiveMethods.firewallData[] data = AdaptiveMethods.GetFirewallData();
            if(data.Length < 0 || data == null)
                 return;
            for(int i = 0; i<data.Length; i++)
            {
                if(data[i].protocol != "UDP" && data[i].protocol != "TCP" && data[i].protocol != "ICMP" )
                {
                    data[i].localPort = data[i].remotePort = data[i].protocol = "any";
                }
                if(data[i].outbound == true)
                {
                    Invoke(new Action(() =>
                    dataOutboundFirewall.Rows.Add(data[i].name, "None", data[i].enabled.ToString(), data[i].action, data[i].program, data[i].localAddress, data[i].remoteAddress, data[i].protocol, data[i].localPort, data[i].remotePort)));
                    continue;
                }
                Invoke(new Action(() => dataGridView2.Rows.Add(data[i].name, "None", data[i].enabled.ToString(), data[i].action, data[i].program, data[i].localAddress, data[i].remoteAddress, data[i].protocol, data[i].localPort, data[i].remotePort)));
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private async void FirewallForm_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataOutboundFirewall.Visible = false;
            await Task.Run(() => GetData());
            dataGridView2.Visible = true;
            dataOutboundFirewall.Visible = true;
            //disposed..
        }
    }
}
