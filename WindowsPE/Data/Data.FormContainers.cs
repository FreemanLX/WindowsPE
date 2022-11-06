using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsPE
{
    public static partial class Data
    {
        public static class FormContainers
        {
            public static MainContainer.MainContainer mainContainer = null;
            public static bool OSLoaded = false;
            public static List<Form> allOpenedForms = new List<Form>();
            public static List<string> logData = new List<string>();
            public static Startmenu startMenu = null;
            public static Search searchMenu = null;
        }
    }
}
  
