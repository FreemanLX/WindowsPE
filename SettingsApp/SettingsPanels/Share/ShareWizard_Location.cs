using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsPE.Settings.ShareWizard
{
    public partial class ShareWizard_Location : UserControl
    {
        public ShareWizard_Location() => InitializeComponent();

        private void radioPathBtn_CheckedChanged(object sender, EventArgs e)
        {
           volumeDataGrid.Enabled = radioVolumeBtn.Checked = !radioPathBtn.Checked;
           customPathTextBox.Enabled = browseBtn.Enabled = radioPathBtn.Checked;
           customPathTextBox.Clear();
           volumeDataGrid.ClearSelection();
        //   ShareData.customWizardForm.SetNextBtn(false);
        }

        private void radioVolumeBtn_CheckedChanged(object sender, EventArgs e)
        {
            customPathTextBox.Enabled = browseBtn.Enabled = radioPathBtn.Checked = !radioVolumeBtn.Checked;
            volumeDataGrid.Enabled = radioVolumeBtn.Checked;
            customPathTextBox.Clear();
            volumeDataGrid.ClearSelection();
        //    ShareData.customWizardForm.SetNextBtn(false);
        }

        bool Verify_drive_avaibility(DriveInfo driver) => !(driver.DriveType == 0 || driver.DriveType == DriveType.CDRom || driver.DriveType == DriveType.Network);

        void Partitions()
        {
            foreach (DriveInfo driver in DriveInfo.GetDrives())
            {
                if (Verify_drive_avaibility(driver) && driver.IsReady == true)
                {
                    volumeDataGrid.Rows.Add(new string[] { driver.Name, Math.Round(driver.AvailableFreeSpace / Math.Pow(1024, 3), 2).ToString() + " GB",
                        Math.Round(driver.TotalFreeSpace / Math.Pow(1024, 3), 2).ToString() + " GB", driver.DriveFormat });
                }
            }
        }

        private void ShareWizard_Location_Load(object sender, EventArgs e)
        {
            volumeDataGrid.DefaultCellStyle.SelectionBackColor = Data.color;
            radioVolumeBtn.Checked = true;
            radioPathBtn.Checked = false;
            browseBtn.Enabled = false;      
            Partitions();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if(folderBrowserDialog.ShowDialog() == DialogResult.OK && 
                       !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                   ShareData.pointer.shi2_path = customPathTextBox.Text = folderBrowserDialog.SelectedPath;
            //       ShareData.customWizardForm.SetNextBtn(true);
                }
            }
        }

        private void volumeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShareData.pointer.shi2_path = volumeDataGrid.SelectedRows[0].Cells[0].Value.ToString() + "share";
          //  ShareData.customWizardForm.SetNextBtn(true);
        }
    }
}
