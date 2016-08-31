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
        public List<Game> Games { get; set; } = new List<Game>();

        public Main()
        {
            InitializeComponent();

            Settings = new LauncherSettings().GetSettings();

            PopulateSettings();
            new Thread(PopulateGames).Start();
        }

        #region Populate Stuff

        private void PopulateGames()
        {
            Games = new List<Game>();

            flpGames.InvokeThreadSafeMethod(() => flpGames.Controls.Clear());
            flpGames.SetThreadSafeProperty(() => flpGames.Enabled, false);

            GamesList gamesList = new GamesList();
            gamesList.OnMessageUpdate += GamesList_OnMessageUpdate;
            gamesList.OnGameAdded += GamesList_OnGameAdded;
            gamesList.OnGameAddingComplete += GamesList_OnGameAddingComplete;

            Games = gamesList.GetGames(Settings.GameDirectories);
        }

        private void PopulateSettings()
        {
            chkDoubleClickToStartGame.Checked = Settings.DoubleClickToStartGame;
            chkFindDecafExeAuto.Checked = Settings.FindDecafExecutableAutomatically;
            txtDecafPath.Text = Settings.DecafExecutablePath;
            foreach (GameRootDirectory directory in Settings.GameDirectories)
            {
                ListViewItem item = new ListViewItem();
                item.Checked = directory.Enabled;
                item.Text = directory.Directory;
                item.SubItems.Add(directory.GameDirectoryID.ToString());

                vwGameDirectories.Items.Add(item);
            }

            //Decaf config settings
            chkDecafOptions_DebuggerEnabled.Checked = Settings.Config.Debugger.Enabled;
            chkDecafOptions_DebuggerBreakOnEntry.Checked = Settings.Config.Debugger.BreakOnEntry;
            chkDecafOptions_GpuDebug.Checked = Settings.Config.Gpu.Debug;
            chkDecafOptions_GpuForceSync.Checked = Settings.Config.Gpu.ForceSync;
            chkDecafOptions_GX2DumpTextures.Checked = Settings.Config.Gx2.DumpTextures;
            chkDecafOptions_GX2DumpShaders.Checked = Settings.Config.Gx2.DumpShaders;
            chkDecafOptions_SoundDumpSounds.Checked = Settings.Config.Sound.DumpSounds;
            chkDecafOptions_JitEnabled.Checked = Settings.Config.Jit.Enabled;
            chkDecafOptions_JitVerify.Checked = Settings.Config.Jit.Verify;
            chkDecafOptions_LogAsync.Checked = Settings.Config.Log.Async;
            chkDecafOptions_LogToFile.Checked = Settings.Config.Log.ToFile;
            chkDecafOptions_LogToStdOut.Checked = Settings.Config.Log.ToStdOut;
            chkDecafOptions_LogKernelTrace.Checked = Settings.Config.Log.KernelTrace;
            chkDecafOptions_LogBranchTrace.Checked = Settings.Config.Log.BranchTrace;
            cbxDecafOptions_LogLevel.SelectedText = Settings.Config.Log.Level;

            gamesQuickMenu.CurrentGameView = Settings.GameView;
            gamesQuickMenu.OnGameViewChanged += GamesQuickMenu_OnGameViewChanged;
            gamesQuickMenu.OnSearch += GamesQuickMenu_OnSearch;
        }

        private void GamesQuickMenu_OnSearch(object source, string e)
        {
            if (e == string.Empty)
                flpGames.Controls.Cast<Control>().ToList().ForEach(c => c.Visible = true);
            else
            {
                foreach (var control in flpGames.Controls)
                {
                    if (Settings.GameView == GameView.Default)
                    {
                        DefaultGameView gameView = control as DefaultGameView;
                        if (gameView.Game.Name.ToLower().Contains(e.ToLower()))
                            gameView.Visible = true;
                        else
                            gameView.Visible = false;
                    }
                    else if (Settings.GameView == GameView.Compact)
                    {
                        CompactGameView gameView = control as CompactGameView;
                        if (gameView.Game.Name.ToLower().Contains(e.ToLower()))
                            gameView.Visible = true;
                        else
                            gameView.Visible = false;
                    }
                }
            }
        }

        private void GamesQuickMenu_OnGameViewChanged(object source, GameView e)
        {
            try
            {
                Settings.GameView = e;
                Settings.Save();

                new Thread(PopulateAllGameViews).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to change the view: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GamesList_OnMessageUpdate(object source, string e)
        {
            lblMessage.SetThreadSafeProperty(() => lblMessage.Text, e);
        }
        private void GamesList_OnGameAdded(object source, Game e)
        {
            if (Settings.GameView == GameView.Default)
                PopulateDefaultGameView(e);
            else if (Settings.GameView == GameView.Compact)
                PopulateCompactGameView(e);
        }
        private void GamesList_OnGameAddingComplete(object source)
        {
            flpGames.SetThreadSafeProperty(() => flpGames.Enabled, true);
        }
        private void PopulateDefaultGameView(Game game)
        {
            DefaultGameView defaultGameView = new DefaultGameView(game);
            defaultGameView.OnGameClicked += GameViews_OnGameClicked;
            defaultGameView.OnGameDoubleClicked += GameViews_OnGameDoubleClicked;
            
            flpGames.InvokeThreadSafeMethod(() => flpGames.Controls.Add(defaultGameView));
        }
        private void PopulateCompactGameView(Game game)
        {
            List<CompactGameView> gameViews = flpGames.Controls.Cast<CompactGameView>().ToList();
            Color color = Color.White;

            if (gameViews.Count == 0)
                color = Color.White;
            else if (gameViews[gameViews.Count - 1].BackColor == Color.White)
                color = SystemColors.Control;
            else if (gameViews[gameViews.Count - 1].BackColor == SystemColors.Control)
                color = Color.White;

            CompactGameView compactGameView = new CompactGameView(game) { BackColor = color, Width = flpGames.Width - 10 };
            compactGameView.OnGameClicked += GameViews_OnGameClicked;
            compactGameView.OnGameDoubleClicked += GameViews_OnGameDoubleClicked;

            flpGames.InvokeThreadSafeMethod(() => flpGames.Controls.Add(compactGameView));
        }
        private void PopulateAllGameViews()
        {
            flpGames.InvokeThreadSafeMethod(() => flpGames.Controls.Clear());

            foreach (Game game in Games)
            {
                if (Settings.GameView == GameView.Default)
                    PopulateDefaultGameView(game);
                else if (Settings.GameView == GameView.Compact)
                    PopulateCompactGameView(game);
            }
        }
        #endregion

        #region Settings Page

        private void lblSelectDecafExe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                txtDecafPath.Text = dialog.FileName;
        }
        private void btnSaveOptions_Click(object sender, EventArgs e)
        {
            bool canSave = true;

            Settings.FindDecafExecutableAutomatically = chkFindDecafExeAuto.Checked;
            Settings.DoubleClickToStartGame = chkDoubleClickToStartGame.Checked;
            Settings.DecafExecutablePath = txtDecafPath.Text;

            //Add and update items in view
            foreach (ListViewItem item in vwGameDirectories.Items)
            {
                if (Settings.GameDirectories.Where(x => x.GameDirectoryID == Guid.Parse(item.SubItems[1].Text)).Count() == 0)
                    Settings.GameDirectories.Add(new GameRootDirectory() { Enabled = item.Checked, GameDirectoryID = Guid.Parse(item.SubItems[1].Text), Directory = item.Text });
                else
                {
                    Settings.GameDirectories.Single(x => x.GameDirectoryID == Guid.Parse(item.SubItems[1].Text)).Enabled = item.Checked;
                    Settings.GameDirectories.Single(x => x.GameDirectoryID == Guid.Parse(item.SubItems[1].Text)).Directory = item.Text;
                }
            }
            //Remove items from list that aren't in view
            Settings.GameDirectories = (from directory in Settings.GameDirectories
                                        where vwGameDirectories.Items.Cast<ListViewItem>().Any(x => Guid.Parse(x.SubItems[1].Text) == directory.GameDirectoryID)
                                        select directory).ToList();

            Settings.Config.Debugger.Enabled = chkDecafOptions_DebuggerEnabled.Checked;
            Settings.Config.Debugger.BreakOnEntry = chkDecafOptions_DebuggerBreakOnEntry.Checked;
            Settings.Config.Gpu.Debug = chkDecafOptions_GpuDebug.Checked;
            Settings.Config.Gpu.ForceSync = chkDecafOptions_GpuForceSync.Checked;
            Settings.Config.Gx2.DumpTextures = chkDecafOptions_GX2DumpTextures.Checked;
            Settings.Config.Gx2.DumpShaders = chkDecafOptions_GX2DumpShaders.Checked;
            Settings.Config.Sound.DumpSounds = chkDecafOptions_SoundDumpSounds.Checked;
            Settings.Config.Jit.Enabled = chkDecafOptions_JitEnabled.Checked;
            Settings.Config.Jit.Verify = chkDecafOptions_JitVerify.Checked;
            Settings.Config.Log.Async = chkDecafOptions_LogAsync.Checked;
            Settings.Config.Log.ToFile = chkDecafOptions_LogToFile.Checked;
            Settings.Config.Log.ToStdOut = chkDecafOptions_LogToStdOut.Checked;
            Settings.Config.Log.KernelTrace = chkDecafOptions_LogKernelTrace.Checked;
            Settings.Config.Log.BranchTrace = chkDecafOptions_LogBranchTrace.Checked;
            Settings.Config.Log.Level = cbxDecafOptions_LogLevel.SelectedText;

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error while trying to save options:\r\n\r\n{ex.Message}");
            }
        }
        private void lblAddGameDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (vwGameDirectories.Items.Cast<ListViewItem>().Where(x => x.Text == dialog.SelectedPath).Count() == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Checked = true;
                    item.Text = dialog.SelectedPath;
                    item.SubItems.Add(Guid.NewGuid().ToString());

                    vwGameDirectories.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("That game directory has already been added.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Game Opening

        private void GameViews_OnGameClicked(object source, Game e)
        {
            if (!Settings.DoubleClickToStartGame)
                OpenGame(e);
        }
        private void GameViews_OnGameDoubleClicked(object source, Game e)
        {
            if (Settings.DoubleClickToStartGame)
                OpenGame(e);
        }
        private void OpenGame(Game game)
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
                    decaf.PlayGame(game.GameDirectory.FullName);
                else
                    decaf.PlayGame(game.GameDirectory.FullName, Settings.DecafExecutablePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\r\n\r\n{ex.Message}");
            }
        }

        #endregion

        #region Help Boxes

        private void HelpBoxes_Click(object sender, EventArgs e)
        {
            if (sender == picHelp_GameDirectories)
            {
                MessageBox.Show("The game launcher will automatically find all games within any subdirectories where it is located. You can add any additional top level directories where your games are stored.", "Game Directories", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void MenuButtons_Click(object sender, EventArgs e)
        {
            if (sender == btnGames)
            {
                menuPages.SelectedIndex = 0;
                this.Text = "Decaf Game Launcher - Games";
            }
            else if (sender == btnOptions)
            {
                menuPages.SelectedIndex = 1;
                this.Text = "Decaf Game Launcher - Options";
            }
            else if (sender == btnControllers)
            {
                menuPages.SelectedIndex = 2;
                this.Text = "Decaf Game Launcher - Controllers";
            }
            else if (sender == btnDebug)
            {
                menuPages.SelectedIndex = 3;
                this.Text = "Decaf Game Launcher - Debug";
            }
            //else if (sender == btnRefreshGames)
            //{
            //    PopulateGames();
            //}
            //else if (sender == btnGameView)
            //{
            //    try
            //    {
            //        if (Settings.GameView == GameView.Default)
            //        {
            //            btnGameView.Image = Properties.Resources.compact_view;
            //            Settings.GameView = GameView.Compact;
            //        }
            //        else if (Settings.GameView == GameView.Compact)
            //        {
            //            btnGameView.Image = Properties.Resources.default_view;
            //            Settings.GameView = GameView.Default;
            //        }

            //        PopulateAllGameViews();
            //        Settings.Save();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred while trying to change the view: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vwGameDirectories.SelectedItems.Count > 0)
            {
                vwGameDirectories.Items.Remove(vwGameDirectories.SelectedItems[0]);
            }
        }

        private void flpGames_Resize(object sender, EventArgs e)
        {
            if (Settings.GameView == GameView.Compact)
            {
                foreach (CompactGameView view in flpGames.Controls)
                {
                    view.Width = flpGames.Width - 20;
                }
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            //This is incredibly hacky, but it works for now. If you resized the window beyond the length of the text of the label, it would run out eventually
            //My super quick solution is just to make the number of underscore characters in the label the same as the width of the form. And since it's not a 1:1
            //ratio, it'll always be wider. And so it never runs out.
            string dividerCharacters = "";
            for (int i = 0; i < this.Width; i++)
            {
                dividerCharacters = dividerCharacters + "_";
            }
            lblDivider.Text = dividerCharacters;
        }
    }
}
