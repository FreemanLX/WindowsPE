using System;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class ApplicationLetter : UserControl
    {
        public ApplicationLetter(string letter)
        {
            InitializeComponent();
            applicationName.Text = letter;
        }

        private void Application_Letter_Load(object sender, EventArgs e)
        {

        }

        private void applicationName_Click(object sender, EventArgs e)
        {

        }
    }
}
