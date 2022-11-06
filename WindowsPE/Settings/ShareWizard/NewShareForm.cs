using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsPE.Settings.ShareWizard;

namespace WindowsPE.Settings
{
    public partial class NewShareForm : Form
    {
        public List<string> prev;
        public List<string> next;
        ShareWizard_Location shareWizard_Location;
        ShareWizard_Name shareWizard_Name;
       // ShareWizard_Permissions shareWizard_Permissions;
        ShareWizard_Confirmation shareWizard_Confirmation;
        public NewShareForm()
        {
            InitializeComponent();
            prev = new List<string>()
            {
                "location"
            };
            next = new List<string>()
            {
                "name", "confirmation"

            };
            shareWizard_Location = new ShareWizard_Location();
            shareWizard_Name = new ShareWizard_Name();
            //shareWizard_Permissions = new ShareWizard_Permissions();
            shareWizard_Confirmation = new ShareWizard_Confirmation();
            SelectedColorBtn(shareLocationBtn);
        }

        private void SelectedColorBtn(Label button)
        {
            button.BackColor = Data.color;
            button.ForeColor = System.Drawing.Color.White;
        }

        private void ColorBtn(Label button)
        {
            button.BackColor = System.Drawing.Color.White;
            button.ForeColor = System.Drawing.Color.Black;
        }

        public void ChangePanel(string current)
        {
            prevBtn.Enabled = true;
            nextBtn.Enabled = createBtn.Enabled = false;
            ColorBtn(shareLocationBtn);
            ColorBtn(shareNameBtn);
            ColorBtn(ShareConfirmationBtn);
            switch (current)
            {
                case "location":
                    prevBtn.Enabled = false;
                    ChangePanel(shareWizard_Location);
                    SelectedColorBtn(shareLocationBtn);
                    break;
 
                case "name":
                    shareWizard_Location.LocationData();
                    shareWizard_Name.LoadData();
                    SelectedColorBtn(shareNameBtn);
                    ChangePanel(shareWizard_Name);
                    break;

           //     case "permission":
           //         ChangePanel(shareWizard_Permissions);
           //         break;

                case "confirmation":
                    createBtn.Enabled = true;
                    shareWizard_Name.LocationData();
                    shareWizard_Confirmation.LoadData();
                    SelectedColorBtn(ShareConfirmationBtn);
                    ChangePanel(shareWizard_Confirmation);
                    break;
            }

        }

        public void ChangePanel(Control control)
        {
            try
            {
                ShareWizard_Container.Controls.Clear();
            }
            catch(Exception) {}
            if(control is UserControl)
            {
                control.Dock = DockStyle.Fill;
                nextBtn.Enabled = false;
                control.Show();
                ShareWizard_Container.Controls.Add(control);
            }
        }


        private void button4_Click(object sender, EventArgs e) => this.Close();

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void NewShareForm_Load(object sender, EventArgs e) => ChangePanel(shareWizard_Location);

        public void SetNextBtn(bool enable) => nextBtn.Enabled = enable;

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string nextusercontrol = next[0];
            prev.Add(next[0]);
            next.RemoveAt(0);
            ChangePanel(nextusercontrol);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if(prev.Count > 1){
               next.Insert(0, prev[prev.Count - 1]);
               prev.RemoveAt(prev.Count - 1);
               ChangePanel(prev[prev.Count - 1]);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(ExternalMethods.AddFileSharing(ShareData.pointer) == true)
            {
                AdaptiveMethods.GetFileSharing();
            }
            this.Close();
        }
    }
}
