using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace Browser
{
    public partial class ColorsForm : UserControl
    {
        public ColorsForm()
        {
            InitializeComponent();
            trackBar1.Enabled = true;
            trackBar1.Value = (Data.opaque / 25) - 3;
            
        }

        private void ColorsForm_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(Color); 
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos) 
            {
                  if(propInfo.Name != "Transparent")
                  comboBox3.Items.Add(propInfo.Name);
            }
            comboBox3.Text = Data.color.Name;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Data.opaque = (3 + trackBar1.Value) * 25;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                Data.color = Color.FromName((comboBox3.SelectedItem).ToString());
            }
            catch(Exception)
            {
                //logs
            }
        }
    }
}
