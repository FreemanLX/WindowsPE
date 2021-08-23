using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleWifi;

namespace WindowsPE
{
    public partial class connect_to_wifi : Form
    {
        Wifi wifi;
        public connect_to_wifi()
        {
            InitializeComponent();
            wifi = new Wifi();
        }

        List<AccessPoint> accesspoints;

        void get_wifi()
        {
            
            try
            {
                accesspoints = wifi.GetAccessPoints();
                foreach (AccessPoint access in accesspoints)
                {
                    this.dataGridView1.Rows.Add(access.Name, access.IsSecure, "2.4 Ghz", access.SignalStrength);
                }
            }
            catch (Exception)
            {

            }
        }


        private void connect_to_wifi_Load(object sender, EventArgs e) => get_wifi();

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            get_wifi();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            using(password password_pa = new password(accesspoints[dataGridView1.CurrentCell.RowIndex]))
            {
                password_pa.ShowDialog();
                password_pa.get_status();
            }
            this.Close();
        }
    }
}
