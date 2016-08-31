using Decaf_Game_Launcher.Settings.DecafConfig;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Decaf_Game_Launcher.Controls.Controllers
{
    public partial class WiiUGamePadOptions : UserControl
    {
        public Input Input { get; set; }

        public WiiUGamePadOptions()
        {
            InitializeComponent();

            cbxControllerNumber.SelectedIndex = 0;
            cbxControllerType.SelectedIndex = 0;
        }

        private void WiiUGamePadOptions_SizeChanged(object sender, EventArgs e)
        {
            string dividerCharacters = "";
            for (int i = 0; i < this.Width; i++)
            {
                dividerCharacters = dividerCharacters + "_";
            }
            lblDivider.Text = dividerCharacters;
        }

        public void SetConfigs(Input input)
        {
            Input = input;
        }

        private void cbxControllerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxControllerType.SelectedText == "Keyboard")
            {
                var device = Input.Devices.SingleOrDefault(x => x.GetType() == typeof(KeyboardDevice));
                if (device != null)
                {

                }
            }
            else if (cbxControllerType.SelectedText == "Standard Controller")
            {
                var device = Input.Devices.SingleOrDefault(x => x.GetType() == typeof(JoystickDevice));
                if (device != null)
                {

                }
            }
        }
    }
}
