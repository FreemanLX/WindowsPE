using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;


namespace WindowsPE
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();
        int opaque = 250;
        public void Change_to_form_threading(Form form, bool dialog = false)
        {
            if (dialog == false) form.Show();
            else form.ShowDialog();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            networking_thread.Abort();
            theme.Abort();
            base.OnFormClosed(e);
        }

        public void CheckInternet()
        {
            while (true)
            {
                bool ava_net = false;
                try
                {
                     ava_net = new Ping().Send("google.com", 1000, new byte[32], new PingOptions()).Status == 0;
                }
                catch{}
                if (ava_net != Data.connected_to_internet)
                {
                    Data.connected_to_internet = ava_net;
                    pictureBox1.Invoke(new Action(() => pictureBox1.Visible = ava_net));
                }
                System.Threading.Thread.Sleep(100);
            }
        }



        System.Threading.Thread networking_thread, theme;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Name = "IntegrateOS Explorer";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            pictureBox1.Location = new Point(pictureBox1.Location.X, screenHeight - 50);
            button1.Location = new Point(button1.Location.X, screenHeight - 50);
            networking_thread = new System.Threading.Thread(() => CheckInternet());
            networking_thread.Start();
            theme = new System.Threading.Thread(() => set_theme());
            theme.Start();
            try
            {
                
                BackgroundImageLayout = ImageLayout.Stretch;
                Image image = new Bitmap("@X:\\Windows\\System32\\winpe.jpg");
                BackgroundImage = image;
                Refresh();
            }
            catch (Exception exc){
                MessageBox.Show(exc.Message);
            }
        }

        private void Set_transparency(Panel panel)
        {
            panel.BackColor = Color.FromArgb(Data.opaque, Data.color);
            foreach(Control control in panel.Controls)
            {
                control.BackColor = Color.Transparent;
            }
        }


        private void set_theme()
        {
            while (true)
            {
                if(Data.opaque != opaque)
                {
                    Invoke(new Action(() =>
                    {
                        Set_transparency(panel4);
                        Set_transparency(panel5);
                        Set_transparency(panel1);
                        Set_transparency(panel3);
                    }));
                    opaque = Data.opaque;
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to restart?", "Restart request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Close();
                }
                catch 
                {

                }
            }
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                Change_to_form_threading(new Browser(), false);
            }
            else
            {
                MessageBox.Show("You aren't connected to the internet, please recheck your connection.");
            }
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e) => Change_to_form_threading(new Toolkit(), true);

        private void Panel5_MouseClick(object sender, MouseEventArgs e) => Change_to_form_threading(new File_explorer(), false);

        private void Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("X:\\setup.exe");
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to start the Windows Setup! Please retry or contact support!");
            }
        }

        private void panel4_DoubleClick(object sender, EventArgs e) => Change_to_form_threading(new Settings(), false);

        private void panel4_Click(object sender, EventArgs e) => Change_to_form_threading(new Settings(), false);

        private void pictureBox4_Click(object sender, EventArgs e) => Change_to_form_threading(new Toolkit(), true);

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("X:\\setup.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start the Windows Setup! Please retry or contact support!");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) => Change_to_form_threading(new Settings(), false);

        private void pictureBox3_Click(object sender, EventArgs e) => Change_to_form_threading(new File_explorer(), false);
    }
}
