using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace Browser
{
    public partial class DisplayForm : UserControl
    {

        public void UpdateDisplayForm()
        {
            InitializeComponent();
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            comboBox1.Items.AddRange(Data.resolutions);
            comboBox1.Text = screenWidth + "x" + screenHeight;
            comboBox3.Text = Data.ToString(Data.fit);
        }
        public DisplayForm() => UpdateDisplayForm();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void display_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Data.form.BackgroundImage;
            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
             Data.fit = Data.ToFit((comboBox3.SelectedItem).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileName openFileDialog = new OpenFileName();
                openFileDialog.structSize = Marshal.SizeOf(openFileDialog);
                openFileDialog.file = new string(new char[256]);
                openFileDialog.maxFile = openFileDialog.file.Length;

                openFileDialog.fileTitle = new String( new char[ 64 ]);
                openFileDialog.maxFileTitle = openFileDialog.fileTitle.Length;    

                openFileDialog.initialDir = Path.GetPathRoot(Environment.SystemDirectory);
                openFileDialog.title = "Select background image";
                openFileDialog.defExt = "txt";
                if(ExternalMethods.GetOpenFileName(openFileDialog)) {   
                      pictureBox1.BackgroundImage = new Bitmap(openFileDialog.file);
                      Data.image = pictureBox1.BackgroundImage;
                 }  
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split = comboBox1.SelectedItem.ToString().Split('x');
            try{
                 Application.Exit();
                 WindowsPE.Restart.Application(split[0] + " " + split[1] + " ");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
