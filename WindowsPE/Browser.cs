using System;
using System.Windows.Forms;

namespace WindowsPE
{

    public partial class Browser : Form
    {
        public Browser() => InitializeComponent();
        private void Browser_Load(object sender, EventArgs e)
        {
            tableLayoutPanel2.Dock = tableLayoutPanel1.Dock = webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("https://docs.microsoft.com/Windows");
            webBrowser1.ScriptErrorsSuppressed = true;
            textBox1.Dock = DockStyle.Fill;
            
        }
        private void Button4_Click(object sender, EventArgs e) => this.Close();

        private void Navigate() => webBrowser1.Navigate((Uri.TryCreate(textBox1.Text, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps) == false) ?
                    "https://google.com/?q=" + textBox1.Text : textBox1.Text);

        private void Button3_Click(object sender, EventArgs e) => Navigate();
        private void Button2_Click(object sender, EventArgs e) => webBrowser1.GoForward();
        private void Button1_Click(object sender, EventArgs e) => webBrowser1.GoBack();
        private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e) => textBox1.Text = webBrowser1.Url.ToString();

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Navigate();
        }
    }
}
