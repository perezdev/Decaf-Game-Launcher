using System.Drawing;
using System.Windows.Forms;
using Decaf_Game_Launcher.Games;
using System.IO;
using System.Diagnostics;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class CompactGameView : UserControl
    {
        public delegate void GameClickedEventHandler(object source, Game e);
        public event GameClickedEventHandler OnGameClicked;

        public delegate void GameDoubleClickedEventHandler(object source, Game e);
        public event GameDoubleClickedEventHandler OnGameDoubleClicked;

        public Game Game { get; set; }

        public CompactGameView(Game game)
        {
            InitializeComponent();

            Game = game;

            picBanner.Image = Game.BannerImage;
            lblGameName.Text = Game.Name;
            lblPublisher.Text = Game.Publisher;
            lblGameSize.Text = Game.GameSize;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(22, 10), new Point(22, 1100));
        }

        private void CompactGameView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OnGameClicked != null)
                    OnGameClicked(this, Game);
            }
        }

        private void CompactGameView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OnGameDoubleClicked != null)
                    OnGameDoubleClicked(this, Game);
            }
        }

        private void ToolStripMenuItems_Click(object sender, System.EventArgs e)
        {
            if (sender == tsmiOpenBoxArt)
            {
                Process.Start(Game.BoxArtURL);
            }
            else if (sender == tsmiOpenInFileSystem)
            {
                if (Game.GameDirectory.Exists)
                {
                    Process.Start(Game.GameDirectory.FullName);
                }
            }
        }
    }
}
