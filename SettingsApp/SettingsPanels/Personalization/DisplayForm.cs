using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsPE.Algorithms;

namespace WindowsPE.Settings
{
    public partial class DisplayForm : UserControl
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        int GeneralDisplayIndex = 0;
        Dictionary<int, Panel> displayIndexes;
        private void DisplayForm_Load(object sender, EventArgs e)
        {
            
            Panel[] panels = new Panel[AdaptiveMethods.screens.Length];
            displayIndexes = new Dictionary<int, Panel>();
            int screensWidth = 0;
            displaysFormContainers.ColumnStyles.Clear();
            displaysFormContainers.RowStyles.Clear();
            displaysFormContainers.RowCount = 3;
            displaysFormContainers.ColumnCount = AdaptiveMethods.screens.Length + 2;
            displaysFormContainers.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            displaysFormContainers.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            displaysFormContainers.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            int percentage = (AdaptiveMethods.screens.Length == 1) ? 35 : 25;
            displaysFormContainers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentage)); //the left margin
            for (int i = 0; i < AdaptiveMethods.screens.Length; i++)
                displaysFormContainers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float) (100.0 / AdaptiveMethods.screens.Length * (AdaptiveMethods.screens[i].Bounds.Width / 1000.0 + 1))));
            displaysFormContainers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentage)); //the right margin
            
            for(int i = 0; i < AdaptiveMethods.screens.Length; i++)
            {
                panels[i] = new Panel
                {
                    Height = (int)(AdaptiveMethods.screens[i].Bounds.Height * 100.0 / AdaptiveMethods.screens.Length),
                    Width = (int)(AdaptiveMethods.screens[i].Bounds.Width  * 100.0 / AdaptiveMethods.screens.Length),
                    BorderStyle = BorderStyle.FixedSingle
                };
                screensWidth += panels[i].Size.Width + 3;
                Label displayId = new Label
                {
                    Font = new Font("Segoe UI", 50, FontStyle.Regular),
                    Text = (i + 1).ToString(),
                    ForeColor = Color.Black,
                };
                displayId.Size = new Size(Size.Width, 100);
                displayId.Dock = DockStyle.Fill;
                displayId.TextAlign = ContentAlignment.MiddleCenter;
                displayId.MouseClick += new MouseEventHandler((MouseSender, MouseEvent) => GeneralDisplayScreenResolution(MouseSender, MouseEvent));
                panels[i].Controls.Add(displayId);
                if(AdaptiveMethods.screens[i].PrimaryScreen)
                {
                    panels[i].BackColor = Data.color;
                    GeneralDisplayIndex = i;
                    displayId.ForeColor = Color.White;
                    ResolutionComboBox.Text = AdaptiveMethods.screens[i].CurrentScreenResolution;
                    ResolutionComboBox.Items.AddRange(AdaptiveMethods.screens[i].ScreenResolutions);
                }
                displayIndexes[i] = panels[i];
                displaysFormContainers.Controls.Add(panels[i], i + 1, 1);
            }
        }

        private void GeneralDisplayScreenResolution(object sender, MouseEventArgs e)
        {
             ResolutionComboBox.Items.Clear();
             Panel panel = null;
             if(sender is Label)
             {
                panel = (sender as Label).Parent as Panel;
             }
             int DisplayIndex = displayIndexes.FirstOrDefault(x => x.Value == panel).Key;
             displayIndexes[GeneralDisplayIndex].BackColor = Color.Transparent;
             displayIndexes[GeneralDisplayIndex].Controls[0].ForeColor = Color.Black;
             GeneralDisplayIndex = DisplayIndex;
             displayIndexes[DisplayIndex].BackColor = Data.color;
             if (AdaptiveMethods.screens[DisplayIndex].DisabledScreen)
             {
                ResolutionComboBox.Text = "Disabled";
                ResolutionComboBox.Enabled = false;
                return;
             }
             ResolutionComboBox.Enabled = true;
             ResolutionComboBox.Text = AdaptiveMethods.screens[DisplayIndex].CurrentScreenResolution;
             displayIndexes[GeneralDisplayIndex].Controls[0].ForeColor = Color.White;
             ResolutionComboBox.Items.AddRange(AdaptiveMethods.screens[DisplayIndex].ScreenResolutions);
        }

        private void DisplayHeaderLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displaysFormContainers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] split = ResolutionComboBox.SelectedItem.ToString().Split('x');
            Data.screenResolution = new Size(int.Parse(split[0]), int.Parse(split[1]));
            ExternalMethods.ScreenApi.ChangeScreenResolutionU(Data.screenResolution.Height, Data.screenResolution.Width);
        }
    }
}
