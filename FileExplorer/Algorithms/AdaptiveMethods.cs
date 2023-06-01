using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace WindowsPE
{
    class AdaptiveMethods
    {
        public static List<Icon> getIcons()
        {
            int IconsCount = ExternalMethods.ExtractIconEx("shell32.dll", -1, null, null, 0);
            List<Icon> iconList = new List<Icon>();
            if(IconsCount > 0)
            {
                IntPtr[] ImageSmallList = new IntPtr[IconsCount];
                var result = ExternalMethods.ExtractIconEx("shell32.dll", 0, null, ImageSmallList, IconsCount);
                iconList.AddRange(ImageSmallList.Select(x => Icon.FromHandle(x)).ToArray());
            }
            return iconList;
        }

    }

}
