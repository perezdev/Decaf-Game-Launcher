using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Decaf_Game_Launcher.Controls.Menu
{
    public partial class MenuToolbar : ToolStrip
    {
        public MenuToolbar()
        {
            InitializeComponent();

            this.GripStyle = ToolStripGripStyle.Hidden;
            this.AutoSize = false;
            this.Renderer = new CustomToolStripRenderer() { RoundedEdges = false };
        }
    }
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        public CustomToolStripRenderer() { }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            LinearGradientMode mode = LinearGradientMode.Vertical;

            using (LinearGradientBrush b = new LinearGradientBrush(e.AffectedBounds, Color.FromArgb(48, 152, 220), Color.FromArgb(48, 126, 220), mode))
            {
                e.Graphics.FillRectangle(b, e.AffectedBounds);
            }
        }
    }
}
