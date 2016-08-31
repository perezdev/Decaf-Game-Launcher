using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decaf_Game_Launcher.Settings;

namespace Decaf_Game_Launcher.Controls.Games
{
    public partial class GamesQuickMenu : UserControl
    {
        public delegate void GameViewChangedEventHandler(object source, GameView e);
        public event GameViewChangedEventHandler OnGameViewChanged;

        public delegate void SearchEventHandler(object source, string e);
        public event SearchEventHandler OnSearch;

        private GameView _CurrentGameView = GameView.Default;
        public GameView CurrentGameView
        {
            get
            {
                return _CurrentGameView;
            }

            set
            {
                _CurrentGameView = value;

                if (_CurrentGameView == GameView.Default)
                {
                    picGrid.Image = Properties.Resources.gridview_default_blue;
                    picBars.Image = Properties.Resources.gridview_compact_gray;
                }
                else if (_CurrentGameView == GameView.Compact)
                {
                    picBars.Image = Properties.Resources.gridview_compact_blue;
                    picGrid.Image = Properties.Resources.gridview_default_gray;
                }
            }
        }

        public GamesQuickMenu()
        {
            InitializeComponent();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = string.Empty;
                txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearch.Text == string.Empty)
            //{
            //    txtSearch.Text = "Search";
            //    txtSearch.Font = new Font(txtSearch.Font, FontStyle.Italic);
            //}

            if (OnSearch != null)
                OnSearch(this, txtSearch.Text);
        }

        private void ViewChange_Click(object sender, EventArgs e)
        {
            if (CurrentGameView == GameView.Default)
                CurrentGameView = GameView.Compact;
            else if (CurrentGameView == GameView.Compact)
                CurrentGameView = GameView.Default;

            if (OnGameViewChanged != null)
                OnGameViewChanged(this, CurrentGameView);
        }
    }
}
