using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsPE
{
    public partial class display : UserControl
    {
        public display()
        {
            InitializeComponent();
            trackBar1.Enabled = true;
            trackBar1.Value = (Data.opaque / 25) - 3;
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            comboBox1.Text = screenWidth + "x" + screenHeight;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Data.opaque = (3 + trackBar1.Value) * 25;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.theme = (comboBox3.SelectedIndex == 1) ? System.Drawing.Color.Black : System.Drawing.Color.White;
            Data.fortheme = (comboBox3.SelectedIndex == 0) ? System.Drawing.Color.Black : System.Drawing.Color.White;
            load();
        }

        private void load()
        {
            this.BackColor = Data.theme;
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Data.theme;
                    control.ForeColor = Data.fortheme;
                }
                if (control is Panel)
                {
                    control.BackColor = Data.theme;
                    Panel panel = (Panel)control;
                    foreach (Control panel_control in panel.Controls)
                    {
                        if (panel_control is Label)
                        {
                            panel_control.BackColor = Data.theme;
                            panel_control.ForeColor = Data.fortheme;
                            control.ForeColor = Data.fortheme;
                            control.BackColor = Data.theme;
                        }
                    }
                }
            }
        }

        private void display_Load(object sender, EventArgs e)
        {
            load();
            comboBox3.Text = (Data.theme == System.Drawing.Color.Black) ? "Dark" : "Light";
            Refresh();
        }
    }
}
