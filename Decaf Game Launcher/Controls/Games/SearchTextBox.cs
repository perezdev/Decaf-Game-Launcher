using System.ComponentModel;
using System.Windows.Forms;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class SearchTextBox : TextBox
    {
        [DefaultValue(false)]
        [Browsable(true)]
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }

        public SearchTextBox()
        {
            InitializeComponent();

            this.AutoSize = false;
            this.Height = 28;
            this.BorderStyle = BorderStyle.None;
        }
    }
}
