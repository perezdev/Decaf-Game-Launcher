using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decaf_Game_Launcher.Games;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class GameView : UserControl
    {
        public delegate void GameDoubleClickedEventHandler(object source, Game e);
        public event GameDoubleClickedEventHandler OnGameDoubleClicked;

        public Game Game { get; set; }

        public GameView(Game game)
        {
            InitializeComponent();

            Game = game;

            picGameCover.Image = Game.CoverArtImage;
        }

        private void picGameCover_DoubleClick(object sender, EventArgs e)
        {
            if (OnGameDoubleClicked != null)
                OnGameDoubleClicked(this, Game);
        }
    }
}
