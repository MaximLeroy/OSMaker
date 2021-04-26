using System;

namespace MetroFramework.Controls
{
    public class TabPageClosedEventArgs : EventArgs
    {
        public TabPageClosedEventArgs(MetroTabPage tabPage)
        {
            TabPage = tabPage;
        }

        public MetroTabPage TabPage { get; private set; }
    }
}
