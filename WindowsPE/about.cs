using System;
using System.Windows.Forms;
using System.Threading;


namespace WindowsPE
{
    public partial class about : UserControl
    {
        public about()
        {
            InitializeComponent();
        }

        Thread theme_thread_about;


        void theme()
        {
            while (true)
            {
                Invoke(new Action(() =>
                {
                    this.BackColor = Data.theme;
                    Refresh();
                    foreach (Control control in this.Controls)
                    {
                        if (control is Label)
                        {
                            control.BackColor = Data.theme;
                            control.ForeColor = Data.fortheme;
                        }
                    }
                }));
                Thread.Sleep(50);
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            theme_thread_about.Abort();
            base.OnHandleDestroyed(e);
        }

        private void about_Load(object sender, EventArgs e)
        {
            theme_thread_about = new Thread(() => theme());
            theme_thread_about.Start();
        }
    }
}
