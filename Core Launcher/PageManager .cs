using System.Collections.Generic;
using System.Windows.Forms;

namespace Core_Launcher.Forms
{
    public static class PageManager //does pages
    {
        public static Dictionary<string, Control> Pages { get; private set; } = new Dictionary<string, Control>();
    }
}