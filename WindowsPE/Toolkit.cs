using System;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class Toolkit : Form
    {
        public Toolkit() => InitializeComponent();

        private void Toolkit_Load(object sender, EventArgs e) {
            listBox1.BackColor = Data.theme;
            listBox1.ForeColor = Data.fortheme;

        }

        private void generate_process(string program, string args) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(program)
        {
            Arguments = args,
            CreateNoWindow = true
        });

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        System.Diagnostics.Process.Start("cmd.exe");
                        break;

                    case 1:
                        generate_process("cmd.exe", "/K powershell.exe");
                        break;

                    case 2:
                        System.Diagnostics.Process.Start("notepad.exe");
                        break;

                    case 3:
                        System.Diagnostics.Process.Start("taskmgr.exe");
                        break;

                    case 4:
                        System.Diagnostics.Process.Start("regedit.exe");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
