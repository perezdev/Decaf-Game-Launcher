using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decaf_Game_Launcher.Controls.Controllers
{
    public partial class WiiUProOptions : UserControl
    {
        public WiiUProOptions()
        {
            InitializeComponent();

            cbxControllerNumber.SelectedIndex = 0;
            cbxControllerType.SelectedIndex = 0;
        }

        private void WiiUProOptions_SizeChanged(object sender, EventArgs e)
        {
            string dividerCharacters = "";
            for (int i = 0; i < this.Width; i++)
            {
                dividerCharacters = dividerCharacters + "_";
            }
            lblDivider.Text = dividerCharacters;
        }
    }
}
