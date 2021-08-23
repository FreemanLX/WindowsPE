using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsPE
{
    public partial class rename : Form
    {
        string selected_path, parent_directory;
        bool directory;
        public rename(string selected_path)
        {
            InitializeComponent();
            directory = true;
            if (File.Exists(selected_path)) { label1.Text = "Do you really want to rename the selected file named " + selected_path + " ?"; directory = false; }
            if(Directory.Exists(selected_path)) label1.Text = "Do you really want to rename the folder named " + selected_path + " ?";
            this.selected_path = selected_path;
            parent_directory = Directory.GetParent(selected_path).FullName;
        }

        private void rename_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 255;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                bool overwrite = false;
                if (File.Exists(parent_directory + "\\" + textBox1.Text) && MessageBox.Show("The selected file " + selected_path + "\\" + textBox1.Text + " exists, do you want to overwrite it?", "Overwrite file",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                     == DialogResult.Yes) overwrite = true;
                if (Directory.Exists(parent_directory + "\\" + textBox1.Text) && MessageBox.Show("The selected directory " + selected_path + "\\" + textBox1.Text + " exists, do you want to overwrite it?", "Overwrite file",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                     == DialogResult.Yes) overwrite = true;
                    else
                    {
                        return;
                    }
                try
                {
                    if (directory == false)
                    {
                        if (overwrite == true)
                            File.Delete(parent_directory + "\\" + textBox1.Text);
                        File.Move(selected_path, parent_directory + "\\" + textBox1.Text);
                    }
                    else
                    {
                        if (overwrite == true)
                            Directory.Delete(parent_directory + "\\" + textBox1.Text);
                        Directory.Move(selected_path, parent_directory + "\\" + textBox1.Text);
                    }
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
