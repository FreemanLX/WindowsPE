using System.Drawing;
using System.Windows.Forms;

namespace WindowsPE.Settings
{
    public partial class Default_form : UserControl
    {
        ControlItem firewall;
        ControlItem network;
        ControlItem personalization;
        ControlItem display;

        public Default_form()
        {
            InitializeComponent();
            firewall = new ControlItem(SettingsApp.Properties.Resources.Def001, "System and Security", () => Data.settingsForm.ChangePanel(new FirewallForm())) { Location = new Point(25, 25) };
            network = new ControlItem(SettingsApp.Properties.Resources.Display065, "Network and Internet", () => Data.settingsForm.ChangePanel(new NetworkForm())) { Location = new Point(25, 91) };
           // fileSharing = new ControlItem(SettingsApp.Properties.Resources.CP032, "File Sharing", () => Data.settingsForm.ChangePanel(new FilesharingForm())) { Location = new Point(25, 152) };
            personalization = new ControlItem(SettingsApp.Properties.Resources.Display016, "Appearence and Personalization", () => Data.settingsForm.ChangePanel(new PersonalizationForm())) { Location = new Point(25, 152) };
            display = new ControlItem(SettingsApp.Properties.Resources.Display028, "Display", () => Data.settingsForm.ChangePanel(new DisplayForm())) { Location = new Point(25, 213) };

            controlItemContainer.Controls.Add(firewall);
            controlItemContainer.Controls.Add(network);
            //controlItemContainer.Controls.Add(fileSharing);
            controlItemContainer.Controls.Add(personalization);
            controlItemContainer.Controls.Add(display);

            firewall.Show();
            network.Show();
           // fileSharing.Show();
            personalization.Show();
            display.Show();
        }

    }
}
