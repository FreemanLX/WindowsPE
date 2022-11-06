using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPE.Settings.Networking
{
    public partial class IPListCheck : UserControl
    {
        public IPListCheck()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> RetrieveData()
        {
            Dictionary<string, string> NetworkDetails = new Dictionary<string, string>();
            NetworkDetails["IP"] = textBox1.Text;
            NetworkDetails["Gateway"] = textBox2.Text;
            NetworkDetails["SubnetMask"] = textBox3.Text;
            NetworkDetails["DNS1"] = textBox4.Text;
            NetworkDetails["DNS2"] = textBox5.Text;
            return NetworkDetails;
        }

        private void IPListCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
