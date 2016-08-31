using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class TranslucentPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        public TranslucentPanel()
        {
            this.BackColor = Color.Black;
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 50;
        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity * 255 / 100, this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }


        //protected void TickHandler(object sender, EventArgs e)
        //{
        //    this.InvalidateEx();
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;

        //        cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT

        //        return cp;
        //    }
        //}

        //protected void InvalidateEx()
        //{
        //    if (Parent == null)
        //    {
        //        return;
        //    }

        //    Rectangle rc = new Rectangle(this.Location, this.Size);

        //    Parent.Invalidate(rc, true);
        //}

        //protected override void OnPaintBackground(PaintEventArgs pevent)
        //{

        //}

        //private Random r = new Random();

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, 0, 0, 0)), this.ClientRectangle);
        //}
    }
}
