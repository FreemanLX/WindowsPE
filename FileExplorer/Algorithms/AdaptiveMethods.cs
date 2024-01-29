using System;
using System.Drawing;

namespace WindowsPE
{
    class AdaptiveMethods
    {
        public static Icon GetIcon(string file, int number, bool largeIcon = false)
        {
            ExternalMethods.ExtractIconEx(file, number, IntPtr.Zero, out IntPtr small, 1);
            return small != IntPtr.Zero ? Icon.FromHandle(small) : null;
        }
    }

}
