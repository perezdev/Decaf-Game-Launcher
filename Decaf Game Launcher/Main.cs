using Decaf_Game_Launcher.Controls.Games;
using Decaf_Game_Launcher.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decaf_Game_Launcher.Settings;
using Decaf_Game_Launcher.Decaf;

namespace Decaf_Game_Launcher
{
    public partial class Main : Form
    {
        public LauncherSettings Settings { get; set; }

        public Main()
        {
            InitializeComponent();

            Settings = new LauncherSettings().GetSettings();

            PopulateSettings();
            new Thread(PopulateGames).Start();
        }

        private void PopulateGames()
        {
            GamesList gamesList = new GamesList();
            gamesList.OnMessageUpdate += GamesList_OnMessageUpdate;

            foreach (var game in gamesList.GetGames())
            {
                GameView gameView = new GameView(game);
                gameView.OnGameDoubleClicked += GameView_OnGameClicked;

                flpGames.InvokeThreadSafeMethod(() => flpGames.Controls.Add(gameView));
            }
        }
        private void PopulateSettings()
        {
            chkFindDecafExeAuto.Checked = Settings.FindDecafExecutableAutomatically;
            txtDecafPath.Text = Settings.DecafExecutablePath;
        }

        private void GamesList_OnMessageUpdate(object source, string e)
        {
            lblMessage.SetThreadSafeProperty(() => lblMessage.Text, e);
        }

        private void GameView_OnGameClicked(object source, Game e)
        {
            if (!Settings.FindDecafExecutableAutomatically && !File.Exists(Settings.DecafExecutablePath))
            {
                MessageBox.Show($"Decaf executable was not found at:\r\n\r\n{Settings.DecafExecutablePath}", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            try
            {
                DecafEmulator decaf = new DecafEmulator();

                if (Settings.FindDecafExecutableAutomatically)
                    decaf.PlayGame(e.GameDirectory.FullName);
                else
                    decaf.PlayGame(e.GameDirectory.FullName, Settings.DecafExecutablePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error:\r\n\r\n{ex.Message}");
            }
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            if (sender == btnGames)
                menuPages.SelectedIndex = 0;
            else if (sender == btnOptions)
                menuPages.SelectedIndex = 1;
            else if (sender == btnControllers)
                menuPages.SelectedIndex = 2;
        }

        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            bool canSave = true;

            Settings.FindDecafExecutableAutomatically = chkFindDecafExeAuto.Checked;
            Settings.DecafExecutablePath = txtDecafPath.Text;

            if (txtDecafPath.Text != string.Empty && !File.Exists(txtDecafPath.Text))
            {
                MessageBox.Show("The decaf executable could not be found.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canSave = false;
            }

            try
            {
                if (canSave)
                    Settings.Save();

                MessageBox.Show("Options saved successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error while trying to save options:\r\n\r\n{ex.Message}");
            }
        }

        private void lblSelectDecafExe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDecafPath.Text = dialog.FileName;
            }
        }
    }
}
