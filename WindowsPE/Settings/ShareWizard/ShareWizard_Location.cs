using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareWizard_Location : UserControl
    {
        public ShareWizard_Location()
        {
            InitializeComponent();
        }

        private void radioPathBtn_CheckedChanged(object sender, EventArgs e)
        {
            radioVolumeBtn.Checked = (radioPathBtn.Checked == true) ? false : true;
            textBox1.Enabled = browseBtn.Enabled = radioPathBtn.Checked;
            dataGridView1.Enabled = radioVolumeBtn.Checked;
            textBox1.Clear();
            ShareData.newShareForm.SetNextBtn(false);
        }

        private void radioVolumeBtn_CheckedChanged(object sender, EventArgs e)
        {
            radioPathBtn.Checked = (radioVolumeBtn.Checked == true) ? false : true;
            textBox1.Enabled = browseBtn.Enabled = radioPathBtn.Checked;
            textBox1.Clear();
            dataGridView1.Enabled = radioVolumeBtn.Checked;
            ShareData.newShareForm.SetNextBtn(false);
        }

        bool Verify_drive_avaibility(DriveInfo driver) => !(driver.DriveType == 0 || driver.DriveType == DriveType.CDRom || driver.DriveType == DriveType.Network);

        void Partitions()
        {
            foreach (DriveInfo driver in DriveInfo.GetDrives())
            {
                if (Verify_drive_avaibility(driver) && driver.IsReady == true)
                {
                    dataGridView1.Rows.Add(new string[] { driver.Name, Math.Round(driver.AvailableFreeSpace / Math.Pow(1024, 3), 2).ToString() + " GB",
                        Math.Round(driver.TotalFreeSpace / Math.Pow(1024, 3), 2).ToString() + " GB", driver.DriveFormat });
                }
            }
        }

        public void LocationData()
        {
            if(textBox1.Text.Length > 0 && radioPathBtn.Checked == true) {
               if(!Directory.Exists(textBox1.Text)){
                    Directory.CreateDirectory(textBox1.Text);
               }
               ShareData.pointer.shi2_path = textBox1.Text;
            }
            else
            {
                ShareData.pointer.shi2_path = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "share";
            } 
        }

        private void ShareWizard_Location_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Data.color;
            radioVolumeBtn.Checked = true;
            radioPathBtn.Checked = false;
            browseBtn.Enabled = false;      
            Partitions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                ShareData.newShareForm.SetNextBtn(true);
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           if(e.StateChanged != DataGridViewElementStates.Selected) return;
           ShareData.newShareForm.SetNextBtn(true);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK && 
                       !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    textBox1.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
