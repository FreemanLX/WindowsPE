using System.Threading;
using System.Windows.Forms;

namespace WindowsPE
{
    class ThreadException
    {
        public ThreadException()
        {

        }

        public void OnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
             Application.Exit();
             Restart.Application(Screen.PrimaryScreen.Bounds.Width.ToString() + " " + Screen.PrimaryScreen.Bounds.Height.ToString());
        }

    }
}
