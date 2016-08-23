using System;
using System.Windows.Forms;

namespace Decaf_Game_Launcher.Controls.Menu
{
    public partial class MenuPages : TabControl
    {
        public MenuPages()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if ((m.Msg == 4904))
                m.Result = ((IntPtr)(1));
            else
                base.WndProc(ref m);
        }
    }
}
