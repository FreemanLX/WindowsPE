using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE
{

    public partial class Settings : Form
    {
        public Settings() => InitializeComponent();
        private void Settings_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            int width = Screen.PrimaryScreen.Bounds.Width;
            panel2.Location = new Point((int)((double) 31 / 100 * (double)width), panel2.Location.Y);
            panel2.Size = new Size(panel2.Size.Width, Screen.PrimaryScreen.Bounds.Height);
            panel1.Size = new Size((int)((double)29 / 100 * (double)width), panel1.Size.Height);
            about1.Dock = networking1.Dock = display1.Dock = DockStyle.Fill;
            display1.Show(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e) => base.OnFormClosing(e);

        private void button4_Click(object sender, EventArgs e) => this.Close();

        private void button1_Click(object sender, EventArgs e)
        {
            display1.Show();
            about1.Hide();
            networking1.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            display1.Hide();
            about1.Hide();
            networking1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display1.Hide();
            about1.Show();
            networking1.Hide();

        }
        protected override void OnFormClosed(FormClosedEventArgs e) => base.OnFormClosed(e);


    }
}
