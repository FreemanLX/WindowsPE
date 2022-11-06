using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class CustomForm : Form
    {

        private static CustomForm formData;
        public CustomForm()
        {
            InitializeComponent();
        }

        private ControlButtons MinimizeButton = new ControlButtons(new Action(() =>
        {
            formData.WindowState = FormWindowState.Minimized;
        }), "_", new Font("Microsoft YaHei UI", 18F, FontStyle.Bold));



        private ControlButtons CloseButton = new ControlButtons(new Action(() =>
        {
            formData.Close();
        }), "X", new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold));



        private void CustomForm_Load(object sender, EventArgs e)
        {
            formData = this;
            this.BackColor = Color.White;
            MinimizeButton.Location = new Point(0, Title.Location.Y);
            CloseButton.Location = new Point(MinimizeButton.Size.Width, Title.Location.Y);
            FormStatePanel.Controls.Add(MinimizeButton);
            FormStatePanel.Controls.Add(CloseButton);

            this.WindowState = FormWindowState.Maximized;
        }
    }
}
