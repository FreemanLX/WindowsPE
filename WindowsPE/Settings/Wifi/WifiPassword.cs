using System;
using System.Windows.Forms;
using SimpleWifi;

namespace Browser
{
    public partial class WifiPassword : Form
    {

        AccessPoint ap;
        public WifiPassword(AccessPoint ap_par)
        {
            InitializeComponent();
            ap = ap_par;
        }

        private void password_Load(object sender, EventArgs e)
        {

        }

        bool connection = false;

        private void button5_Click(object sender, EventArgs e)
        {
            connection = ap.Connect(new AuthRequest(ap) { Password = textBox1.Text });
            if(connection == false)
            {
                MessageBox.Show("The wifi connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        public bool get_status()
        {
            return connection;
        }
    }
}
