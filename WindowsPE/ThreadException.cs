using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsPE
{
    class ThreadException
    {
        public ThreadException(){}
        public void OnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
             Application.Exit();
             ProcessStartInfo processStartInfo = new ProcessStartInfo(Application.ExecutablePath);
             Process.Start(processStartInfo);
        }
    }
}
