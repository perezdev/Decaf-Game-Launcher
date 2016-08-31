using System;
using System.Windows.Forms;
using Decaf_Game_Launcher.Games;
using System.Diagnostics;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class DefaultGameView : UserControl
    {
        public delegate void GameClickedEventHandler(object source, Game e);
        public event GameClickedEventHandler OnGameClicked;

        public delegate void GameDoubleClickedEventHandler(object source, Game e);
        public event GameDoubleClickedEventHandler OnGameDoubleClicked;

        public Game Game { get; set; }

        public DefaultGameView(Game game)
        {
            InitializeComponent();

            Game = game;

            picBoxArt.Image = Game.BoxArtImage == null ? Game.BannerImage : Game.BoxArtImage;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picBoxArt, game.Name);
        }

        private void picBoxArt_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OnGameClicked != null)
                    OnGameClicked(this, Game);
            }
        }

        private void picBoxArt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OnGameDoubleClicked != null)
                    OnGameDoubleClicked(this, Game);
            }
        }

        private void ToolStripMenuItems_Click(object sender, EventArgs e)
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
