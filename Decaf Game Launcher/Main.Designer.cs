namespace Decaf_Game_Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmsGameDirectories = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPages = new Decaf_Game_Launcher.Controls.Menu.MenuPages();
            this.pageGames = new System.Windows.Forms.TabPage();
            this.gamesQuickMenu = new Decaf_Game_Launcher.Controls.Games.GamesQuickMenu();
            this.flpGames = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDivider = new System.Windows.Forms.Label();
            this.pageOptions = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabControl();
            this.pageLauncherOptions = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vwGameDirectories = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picHelp_GameDirectories = new System.Windows.Forms.PictureBox();
            this.lblAddGameDirectory = new System.Windows.Forms.LinkLabel();
            this.chkDoubleClickToStartGame = new System.Windows.Forms.CheckBox();
            this.lblSelectDecafExe = new System.Windows.Forms.LinkLabel();
            this.chkFindDecafExeAuto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecafPath = new System.Windows.Forms.TextBox();
            this.pageDecafOptions = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_LogAsync = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_LogToFile = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_LogToStdOut = new System.Windows.Forms.CheckBox();
            this.lblDecafOptions_KernelTraceFilters = new System.Windows.Forms.LinkLabel();
            this.chkDecafOptions_LogKernelTrace = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_LogBranchTrace = new System.Windows.Forms.CheckBox();
            this.cbxDecafOptions_LogLevel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_SoundDumpSounds = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_GX2DumpTextures = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_GX2DumpShaders = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_GpuDebug = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_GpuForceSync = new System.Windows.Forms.CheckBox();
            this.lblDecafOptions_GpuDebugFilters = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_JitEnabled = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_JitVerify = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDecafOptions_DebuggerEnabled = new System.Windows.Forms.CheckBox();
            this.chkDecafOptions_DebuggerBreakOnEntry = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.pageControllers = new System.Windows.Forms.TabPage();
            this.btnSaveControllers = new System.Windows.Forms.Button();
            this.tabControllers = new System.Windows.Forms.TabControl();
            this.pageWiiUGamePadController = new System.Windows.Forms.TabPage();
            this.wiiUGamePadOptions1 = new Decaf_Game_Launcher.Controls.Controllers.WiiUGamePadOptions();
            this.pageWiiUProController = new System.Windows.Forms.TabPage();
            this.wiiUProOptions1 = new Decaf_Game_Launcher.Controls.Controllers.WiiUProOptions();
            this.pageDebug = new System.Windows.Forms.TabPage();
            this.menu = new Decaf_Game_Launcher.Controls.Menu.MenuToolbar();
            this.btnGames = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnControllers = new System.Windows.Forms.ToolStripButton();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.cmsGameDirectories.SuspendLayout();
            this.menuPages.SuspendLayout();
            this.pageGames.SuspendLayout();
            this.pageOptions.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.pageLauncherOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp_GameDirectories)).BeginInit();
            this.pageDecafOptions.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pageControllers.SuspendLayout();
            this.tabControllers.SuspendLayout();
            this.pageWiiUGamePadController.SuspendLayout();
            this.pageWiiUProController.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 21);
            this.panel1.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(4, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(38, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Ready";
            // 
            // cmsGameDirectories
            // 
            this.cmsGameDirectories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsGameDirectories.Name = "cmsGameDirectories";
            this.cmsGameDirectories.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuPages
            // 
            this.menuPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPages.Controls.Add(this.pageGames);
            this.menuPages.Controls.Add(this.pageOptions);
            this.menuPages.Controls.Add(this.pageControllers);
            this.menuPages.Controls.Add(this.pageDebug);
            this.menuPages.Location = new System.Drawing.Point(0, 65);
            this.menuPages.Name = "menuPages";
            this.menuPages.SelectedIndex = 0;
            this.menuPages.Size = new System.Drawing.Size(874, 514);
            this.menuPages.TabIndex = 2;
            // 
            // pageGames
            // 
            this.pageGames.BackColor = System.Drawing.Color.White;
            this.pageGames.Controls.Add(this.gamesQuickMenu);
            this.pageGames.Controls.Add(this.flpGames);
            this.pageGames.Controls.Add(this.lblDivider);
            this.pageGames.Location = new System.Drawing.Point(0, 0);
            this.pageGames.Name = "pageGames";
            this.pageGames.Padding = new System.Windows.Forms.Padding(3);
            this.pageGames.Size = new System.Drawing.Size(874, 514);
            this.pageGames.TabIndex = 0;
            this.pageGames.Text = "tabPage1";
            // 
            // gamesQuickMenu
            // 
            this.gamesQuickMenu.BackColor = System.Drawing.Color.White;
            this.gamesQuickMenu.CurrentGameView = Decaf_Game_Launcher.Settings.GameView.Default;
            this.gamesQuickMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamesQuickMenu.Location = new System.Drawing.Point(3, 3);
            this.gamesQuickMenu.Name = "gamesQuickMenu";
            this.gamesQuickMenu.Size = new System.Drawing.Size(868, 24);
            this.gamesQuickMenu.TabIndex = 1;
            // 
            // flpGames
            // 
            this.flpGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpGames.AutoScroll = true;
            this.flpGames.BackColor = System.Drawing.Color.White;
            this.flpGames.Location = new System.Drawing.Point(0, 29);
            this.flpGames.Name = "flpGames";
            this.flpGames.Size = new System.Drawing.Size(872, 487);
            this.flpGames.TabIndex = 0;
            this.flpGames.Resize += new System.EventHandler(this.flpGames_Resize);
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.AutoSize = true;
            this.lblDivider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblDivider.Location = new System.Drawing.Point(-33, 16);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1147, 13);
            this.lblDivider.TabIndex = 2;
            this.lblDivider.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_____________________________";
            // 
            // pageOptions
            // 
            this.pageOptions.Controls.Add(this.tabOptions);
            this.pageOptions.Controls.Add(this.btnSaveOptions);
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pageOptions.Size = new System.Drawing.Size(874, 514);
            this.pageOptions.TabIndex = 1;
            this.pageOptions.Text = "tabPage2";
            this.pageOptions.UseVisualStyleBackColor = true;
            // 
            // tabOptions
            // 
            this.tabOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptions.Controls.Add(this.pageLauncherOptions);
            this.tabOptions.Controls.Add(this.pageDecafOptions);
            this.tabOptions.Location = new System.Drawing.Point(3, 3);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.SelectedIndex = 0;
            this.tabOptions.Size = new System.Drawing.Size(865, 476);
            this.tabOptions.TabIndex = 6;
            // 
            // pageLauncherOptions
            // 
            this.pageLauncherOptions.Controls.Add(this.groupBox1);
            this.pageLauncherOptions.Controls.Add(this.chkDoubleClickToStartGame);
            this.pageLauncherOptions.Controls.Add(this.lblSelectDecafExe);
            this.pageLauncherOptions.Controls.Add(this.chkFindDecafExeAuto);
            this.pageLauncherOptions.Controls.Add(this.label1);
            this.pageLauncherOptions.Controls.Add(this.txtDecafPath);
            this.pageLauncherOptions.Location = new System.Drawing.Point(4, 22);
            this.pageLauncherOptions.Name = "pageLauncherOptions";
            this.pageLauncherOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pageLauncherOptions.Size = new System.Drawing.Size(857, 450);
            this.pageLauncherOptions.TabIndex = 0;
            this.pageLauncherOptions.Text = "Launcher Options";
            this.pageLauncherOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.vwGameDirectories);
            this.groupBox1.Controls.Add(this.picHelp_GameDirectories);
            this.groupBox1.Controls.Add(this.lblAddGameDirectory);
            this.groupBox1.Location = new System.Drawing.Point(364, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 436);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Directories";
            // 
            // vwGameDirectories
            // 
            this.vwGameDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vwGameDirectories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vwGameDirectories.CheckBoxes = true;
            this.vwGameDirectories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.vwGameDirectories.ContextMenuStrip = this.cmsGameDirectories;
            this.vwGameDirectories.FullRowSelect = true;
            this.vwGameDirectories.GridLines = true;
            this.vwGameDirectories.Location = new System.Drawing.Point(3, 35);
            this.vwGameDirectories.MultiSelect = false;
            this.vwGameDirectories.Name = "vwGameDirectories";
            this.vwGameDirectories.Size = new System.Drawing.Size(668, 414);
            this.vwGameDirectories.TabIndex = 9;
            this.vwGameDirectories.UseCompatibleStateImageBehavior = false;
            this.vwGameDirectories.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game Directory";
            this.columnHeader1.Width = 410;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "GameDirectoryID";
            this.columnHeader2.Width = 0;
            // 
            // picHelp_GameDirectories
            // 
            this.picHelp_GameDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picHelp_GameDirectories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHelp_GameDirectories.Image = global::Decaf_Game_Launcher.Properties.Resources.help;
            this.picHelp_GameDirectories.Location = new System.Drawing.Point(656, 13);
            this.picHelp_GameDirectories.Name = "picHelp_GameDirectories";
            this.picHelp_GameDirectories.Size = new System.Drawing.Size(16, 16);
            this.picHelp_GameDirectories.TabIndex = 8;
            this.picHelp_GameDirectories.TabStop = false;
            this.picHelp_GameDirectories.Click += new System.EventHandler(this.HelpBoxes_Click);
            // 
            // lblAddGameDirectory
            // 
            this.lblAddGameDirectory.ActiveLinkColor = System.Drawing.Color.White;
            this.lblAddGameDirectory.AutoSize = true;
            this.lblAddGameDirectory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(220)))));
            this.lblAddGameDirectory.Location = new System.Drawing.Point(5, 17);
            this.lblAddGameDirectory.Name = "lblAddGameDirectory";
            this.lblAddGameDirectory.Size = new System.Drawing.Size(102, 13);
            this.lblAddGameDirectory.TabIndex = 5;
            this.lblAddGameDirectory.TabStop = true;
            this.lblAddGameDirectory.Text = "Add Game Directory";
            this.lblAddGameDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddGameDirectory_LinkClicked);
            // 
            // chkDoubleClickToStartGame
            // 
            this.chkDoubleClickToStartGame.AutoSize = true;
            this.chkDoubleClickToStartGame.Location = new System.Drawing.Point(8, 8);
            this.chkDoubleClickToStartGame.Name = "chkDoubleClickToStartGame";
            this.chkDoubleClickToStartGame.Size = new System.Drawing.Size(154, 17);
            this.chkDoubleClickToStartGame.TabIndex = 1;
            this.chkDoubleClickToStartGame.Text = "Double click to start games";
            this.chkDoubleClickToStartGame.UseVisualStyleBackColor = true;
            // 
            // lblSelectDecafExe
            // 
            this.lblSelectDecafExe.ActiveLinkColor = System.Drawing.Color.White;
            this.lblSelectDecafExe.AutoSize = true;
            this.lblSelectDecafExe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(220)))));
            this.lblSelectDecafExe.Location = new System.Drawing.Point(274, 53);
            this.lblSelectDecafExe.Name = "lblSelectDecafExe";
            this.lblSelectDecafExe.Size = new System.Drawing.Size(58, 13);
            this.lblSelectDecafExe.TabIndex = 5;
            this.lblSelectDecafExe.TabStop = true;
            this.lblSelectDecafExe.Text = "Select Exe";
            this.lblSelectDecafExe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectDecafExe_LinkClicked);
            // 
            // chkFindDecafExeAuto
            // 
            this.chkFindDecafExeAuto.AutoSize = true;
            this.chkFindDecafExeAuto.Location = new System.Drawing.Point(8, 29);
            this.chkFindDecafExeAuto.Name = "chkFindDecafExeAuto";
            this.chkFindDecafExeAuto.Size = new System.Drawing.Size(270, 17);
            this.chkFindDecafExeAuto.TabIndex = 1;
            this.chkFindDecafExeAuto.Text = "Find Decaf Exectuable (decaf-sdl.exe) automatically";
            this.chkFindDecafExeAuto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decaf Path:";
            // 
            // txtDecafPath
            // 
            this.txtDecafPath.Location = new System.Drawing.Point(97, 49);
            this.txtDecafPath.Name = "txtDecafPath";
            this.txtDecafPath.ReadOnly = true;
            this.txtDecafPath.Size = new System.Drawing.Size(174, 20);
            this.txtDecafPath.TabIndex = 2;
            // 
            // pageDecafOptions
            // 
            this.pageDecafOptions.Controls.Add(this.groupBox7);
            this.pageDecafOptions.Controls.Add(this.groupBox6);
            this.pageDecafOptions.Controls.Add(this.groupBox5);
            this.pageDecafOptions.Controls.Add(this.groupBox4);
            this.pageDecafOptions.Controls.Add(this.groupBox3);
            this.pageDecafOptions.Controls.Add(this.groupBox2);
            this.pageDecafOptions.Controls.Add(this.panel2);
            this.pageDecafOptions.Location = new System.Drawing.Point(4, 22);
            this.pageDecafOptions.Name = "pageDecafOptions";
            this.pageDecafOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pageDecafOptions.Size = new System.Drawing.Size(857, 450);
            this.pageDecafOptions.TabIndex = 1;
            this.pageDecafOptions.Text = "Decaf Options";
            this.pageDecafOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkDecafOptions_LogAsync);
            this.groupBox7.Controls.Add(this.chkDecafOptions_LogToFile);
            this.groupBox7.Controls.Add(this.chkDecafOptions_LogToStdOut);
            this.groupBox7.Controls.Add(this.lblDecafOptions_KernelTraceFilters);
            this.groupBox7.Controls.Add(this.chkDecafOptions_LogKernelTrace);
            this.groupBox7.Controls.Add(this.chkDecafOptions_LogBranchTrace);
            this.groupBox7.Controls.Add(this.cbxDecafOptions_LogLevel);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Location = new System.Drawing.Point(448, 30);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(403, 241);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Log";
            // 
            // chkDecafOptions_LogAsync
            // 
            this.chkDecafOptions_LogAsync.AutoSize = true;
            this.chkDecafOptions_LogAsync.Location = new System.Drawing.Point(9, 19);
            this.chkDecafOptions_LogAsync.Name = "chkDecafOptions_LogAsync";
            this.chkDecafOptions_LogAsync.Size = new System.Drawing.Size(55, 17);
            this.chkDecafOptions_LogAsync.TabIndex = 2;
            this.chkDecafOptions_LogAsync.Text = "Async";
            this.chkDecafOptions_LogAsync.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_LogToFile
            // 
            this.chkDecafOptions_LogToFile.AutoSize = true;
            this.chkDecafOptions_LogToFile.Location = new System.Drawing.Point(133, 19);
            this.chkDecafOptions_LogToFile.Name = "chkDecafOptions_LogToFile";
            this.chkDecafOptions_LogToFile.Size = new System.Drawing.Size(58, 17);
            this.chkDecafOptions_LogToFile.TabIndex = 2;
            this.chkDecafOptions_LogToFile.Text = "To File";
            this.chkDecafOptions_LogToFile.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_LogToStdOut
            // 
            this.chkDecafOptions_LogToStdOut.AutoSize = true;
            this.chkDecafOptions_LogToStdOut.Location = new System.Drawing.Point(243, 19);
            this.chkDecafOptions_LogToStdOut.Name = "chkDecafOptions_LogToStdOut";
            this.chkDecafOptions_LogToStdOut.Size = new System.Drawing.Size(78, 17);
            this.chkDecafOptions_LogToStdOut.TabIndex = 2;
            this.chkDecafOptions_LogToStdOut.Text = "To Std Out";
            this.chkDecafOptions_LogToStdOut.UseVisualStyleBackColor = true;
            // 
            // lblDecafOptions_KernelTraceFilters
            // 
            this.lblDecafOptions_KernelTraceFilters.ActiveLinkColor = System.Drawing.Color.White;
            this.lblDecafOptions_KernelTraceFilters.AutoSize = true;
            this.lblDecafOptions_KernelTraceFilters.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(220)))));
            this.lblDecafOptions_KernelTraceFilters.Location = new System.Drawing.Point(95, 61);
            this.lblDecafOptions_KernelTraceFilters.Name = "lblDecafOptions_KernelTraceFilters";
            this.lblDecafOptions_KernelTraceFilters.Size = new System.Drawing.Size(34, 13);
            this.lblDecafOptions_KernelTraceFilters.TabIndex = 3;
            this.lblDecafOptions_KernelTraceFilters.TabStop = true;
            this.lblDecafOptions_KernelTraceFilters.Text = "Filters";
            // 
            // chkDecafOptions_LogKernelTrace
            // 
            this.chkDecafOptions_LogKernelTrace.AutoSize = true;
            this.chkDecafOptions_LogKernelTrace.Location = new System.Drawing.Point(9, 60);
            this.chkDecafOptions_LogKernelTrace.Name = "chkDecafOptions_LogKernelTrace";
            this.chkDecafOptions_LogKernelTrace.Size = new System.Drawing.Size(93, 17);
            this.chkDecafOptions_LogKernelTrace.TabIndex = 2;
            this.chkDecafOptions_LogKernelTrace.Text = "Kernel Trace -";
            this.chkDecafOptions_LogKernelTrace.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_LogBranchTrace
            // 
            this.chkDecafOptions_LogBranchTrace.AutoSize = true;
            this.chkDecafOptions_LogBranchTrace.Location = new System.Drawing.Point(133, 57);
            this.chkDecafOptions_LogBranchTrace.Name = "chkDecafOptions_LogBranchTrace";
            this.chkDecafOptions_LogBranchTrace.Size = new System.Drawing.Size(91, 17);
            this.chkDecafOptions_LogBranchTrace.TabIndex = 2;
            this.chkDecafOptions_LogBranchTrace.Text = "Branch Trace";
            this.chkDecafOptions_LogBranchTrace.UseVisualStyleBackColor = true;
            // 
            // cbxDecafOptions_LogLevel
            // 
            this.cbxDecafOptions_LogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDecafOptions_LogLevel.FormattingEnabled = true;
            this.cbxDecafOptions_LogLevel.Items.AddRange(new object[] {
            "Alert",
            "Critical",
            "Debug",
            "Error",
            "Emerg",
            "Info",
            "Notice",
            "Off",
            "Trace",
            "Warning"});
            this.cbxDecafOptions_LogLevel.Location = new System.Drawing.Point(282, 55);
            this.cbxDecafOptions_LogLevel.Name = "cbxDecafOptions_LogLevel";
            this.cbxDecafOptions_LogLevel.Size = new System.Drawing.Size(84, 21);
            this.cbxDecafOptions_LogLevel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Level:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkDecafOptions_SoundDumpSounds);
            this.groupBox6.Location = new System.Drawing.Point(3, 177);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 45);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dump Sounds";
            // 
            // chkDecafOptions_SoundDumpSounds
            // 
            this.chkDecafOptions_SoundDumpSounds.AutoSize = true;
            this.chkDecafOptions_SoundDumpSounds.Location = new System.Drawing.Point(6, 19);
            this.chkDecafOptions_SoundDumpSounds.Name = "chkDecafOptions_SoundDumpSounds";
            this.chkDecafOptions_SoundDumpSounds.Size = new System.Drawing.Size(93, 17);
            this.chkDecafOptions_SoundDumpSounds.TabIndex = 2;
            this.chkDecafOptions_SoundDumpSounds.Text = "Dump Sounds";
            this.chkDecafOptions_SoundDumpSounds.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkDecafOptions_GX2DumpTextures);
            this.groupBox5.Controls.Add(this.chkDecafOptions_GX2DumpShaders);
            this.groupBox5.Location = new System.Drawing.Point(3, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(439, 45);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GX2";
            // 
            // chkDecafOptions_GX2DumpTextures
            // 
            this.chkDecafOptions_GX2DumpTextures.AutoSize = true;
            this.chkDecafOptions_GX2DumpTextures.Location = new System.Drawing.Point(6, 16);
            this.chkDecafOptions_GX2DumpTextures.Name = "chkDecafOptions_GX2DumpTextures";
            this.chkDecafOptions_GX2DumpTextures.Size = new System.Drawing.Size(98, 17);
            this.chkDecafOptions_GX2DumpTextures.TabIndex = 2;
            this.chkDecafOptions_GX2DumpTextures.Text = "Dump Textures";
            this.chkDecafOptions_GX2DumpTextures.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_GX2DumpShaders
            // 
            this.chkDecafOptions_GX2DumpShaders.AutoSize = true;
            this.chkDecafOptions_GX2DumpShaders.Location = new System.Drawing.Point(104, 16);
            this.chkDecafOptions_GX2DumpShaders.Name = "chkDecafOptions_GX2DumpShaders";
            this.chkDecafOptions_GX2DumpShaders.Size = new System.Drawing.Size(96, 17);
            this.chkDecafOptions_GX2DumpShaders.TabIndex = 2;
            this.chkDecafOptions_GX2DumpShaders.Text = "Dump Shaders";
            this.chkDecafOptions_GX2DumpShaders.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkDecafOptions_GpuDebug);
            this.groupBox4.Controls.Add(this.chkDecafOptions_GpuForceSync);
            this.groupBox4.Controls.Add(this.lblDecafOptions_GpuDebugFilters);
            this.groupBox4.Location = new System.Drawing.Point(3, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(439, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GPU";
            // 
            // chkDecafOptions_GpuDebug
            // 
            this.chkDecafOptions_GpuDebug.AutoSize = true;
            this.chkDecafOptions_GpuDebug.Location = new System.Drawing.Point(6, 19);
            this.chkDecafOptions_GpuDebug.Name = "chkDecafOptions_GpuDebug";
            this.chkDecafOptions_GpuDebug.Size = new System.Drawing.Size(64, 17);
            this.chkDecafOptions_GpuDebug.TabIndex = 2;
            this.chkDecafOptions_GpuDebug.Text = "Debug -";
            this.chkDecafOptions_GpuDebug.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_GpuForceSync
            // 
            this.chkDecafOptions_GpuForceSync.AutoSize = true;
            this.chkDecafOptions_GpuForceSync.Location = new System.Drawing.Point(106, 19);
            this.chkDecafOptions_GpuForceSync.Name = "chkDecafOptions_GpuForceSync";
            this.chkDecafOptions_GpuForceSync.Size = new System.Drawing.Size(80, 17);
            this.chkDecafOptions_GpuForceSync.TabIndex = 2;
            this.chkDecafOptions_GpuForceSync.Text = "Force Sync";
            this.chkDecafOptions_GpuForceSync.UseVisualStyleBackColor = true;
            // 
            // lblDecafOptions_GpuDebugFilters
            // 
            this.lblDecafOptions_GpuDebugFilters.ActiveLinkColor = System.Drawing.Color.White;
            this.lblDecafOptions_GpuDebugFilters.AutoSize = true;
            this.lblDecafOptions_GpuDebugFilters.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(220)))));
            this.lblDecafOptions_GpuDebugFilters.Location = new System.Drawing.Point(66, 20);
            this.lblDecafOptions_GpuDebugFilters.Name = "lblDecafOptions_GpuDebugFilters";
            this.lblDecafOptions_GpuDebugFilters.Size = new System.Drawing.Size(34, 13);
            this.lblDecafOptions_GpuDebugFilters.TabIndex = 3;
            this.lblDecafOptions_GpuDebugFilters.TabStop = true;
            this.lblDecafOptions_GpuDebugFilters.Text = "Filters";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDecafOptions_JitEnabled);
            this.groupBox3.Controls.Add(this.chkDecafOptions_JitVerify);
            this.groupBox3.Location = new System.Drawing.Point(3, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 45);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "JIT";
            // 
            // chkDecafOptions_JitEnabled
            // 
            this.chkDecafOptions_JitEnabled.AutoSize = true;
            this.chkDecafOptions_JitEnabled.Location = new System.Drawing.Point(8, 15);
            this.chkDecafOptions_JitEnabled.Name = "chkDecafOptions_JitEnabled";
            this.chkDecafOptions_JitEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkDecafOptions_JitEnabled.TabIndex = 2;
            this.chkDecafOptions_JitEnabled.Text = "Enabled";
            this.chkDecafOptions_JitEnabled.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_JitVerify
            // 
            this.chkDecafOptions_JitVerify.AutoSize = true;
            this.chkDecafOptions_JitVerify.Location = new System.Drawing.Point(106, 17);
            this.chkDecafOptions_JitVerify.Name = "chkDecafOptions_JitVerify";
            this.chkDecafOptions_JitVerify.Size = new System.Drawing.Size(52, 17);
            this.chkDecafOptions_JitVerify.TabIndex = 2;
            this.chkDecafOptions_JitVerify.Text = "Verify";
            this.chkDecafOptions_JitVerify.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDecafOptions_DebuggerEnabled);
            this.groupBox2.Controls.Add(this.chkDecafOptions_DebuggerBreakOnEntry);
            this.groupBox2.Location = new System.Drawing.Point(3, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 45);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debugger";
            // 
            // chkDecafOptions_DebuggerEnabled
            // 
            this.chkDecafOptions_DebuggerEnabled.AutoSize = true;
            this.chkDecafOptions_DebuggerEnabled.Location = new System.Drawing.Point(8, 19);
            this.chkDecafOptions_DebuggerEnabled.Name = "chkDecafOptions_DebuggerEnabled";
            this.chkDecafOptions_DebuggerEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkDecafOptions_DebuggerEnabled.TabIndex = 2;
            this.chkDecafOptions_DebuggerEnabled.Text = "Enabled";
            this.chkDecafOptions_DebuggerEnabled.UseVisualStyleBackColor = true;
            // 
            // chkDecafOptions_DebuggerBreakOnEntry
            // 
            this.chkDecafOptions_DebuggerBreakOnEntry.AutoSize = true;
            this.chkDecafOptions_DebuggerBreakOnEntry.Location = new System.Drawing.Point(106, 19);
            this.chkDecafOptions_DebuggerBreakOnEntry.Name = "chkDecafOptions_DebuggerBreakOnEntry";
            this.chkDecafOptions_DebuggerBreakOnEntry.Size = new System.Drawing.Size(96, 17);
            this.chkDecafOptions_DebuggerBreakOnEntry.TabIndex = 2;
            this.chkDecafOptions_DebuggerBreakOnEntry.Text = "Break on Entry";
            this.chkDecafOptions_DebuggerBreakOnEntry.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 25);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "WARNING - These settings are only for advanced users. Changing them may adversely" +
    " affect Decaf.";
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOptions.Location = new System.Drawing.Point(793, 485);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOptions.TabIndex = 0;
            this.btnSaveOptions.Text = "Save";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // pageControllers
            // 
            this.pageControllers.Controls.Add(this.btnSaveControllers);
            this.pageControllers.Controls.Add(this.tabControllers);
            this.pageControllers.Location = new System.Drawing.Point(0, 0);
            this.pageControllers.Name = "pageControllers";
            this.pageControllers.Padding = new System.Windows.Forms.Padding(3);
            this.pageControllers.Size = new System.Drawing.Size(874, 514);
            this.pageControllers.TabIndex = 2;
            this.pageControllers.Text = "tabPage3";
            this.pageControllers.UseVisualStyleBackColor = true;
            // 
            // btnSaveControllers
            // 
            this.btnSaveControllers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveControllers.Location = new System.Drawing.Point(793, 485);
            this.btnSaveControllers.Name = "btnSaveControllers";
            this.btnSaveControllers.Size = new System.Drawing.Size(75, 23);
            this.btnSaveControllers.TabIndex = 1;
            this.btnSaveControllers.Text = "Save";
            this.btnSaveControllers.UseVisualStyleBackColor = true;
            // 
            // tabControllers
            // 
            this.tabControllers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControllers.Controls.Add(this.pageWiiUGamePadController);
            this.tabControllers.Controls.Add(this.pageWiiUProController);
            this.tabControllers.Location = new System.Drawing.Point(3, 3);
            this.tabControllers.Name = "tabControllers";
            this.tabControllers.SelectedIndex = 0;
            this.tabControllers.Size = new System.Drawing.Size(865, 476);
            this.tabControllers.TabIndex = 0;
            // 
            // pageWiiUGamePadController
            // 
            this.pageWiiUGamePadController.Controls.Add(this.wiiUGamePadOptions1);
            this.pageWiiUGamePadController.Location = new System.Drawing.Point(4, 22);
            this.pageWiiUGamePadController.Name = "pageWiiUGamePadController";
            this.pageWiiUGamePadController.Padding = new System.Windows.Forms.Padding(3);
            this.pageWiiUGamePadController.Size = new System.Drawing.Size(857, 450);
            this.pageWiiUGamePadController.TabIndex = 1;
            this.pageWiiUGamePadController.Text = "Wii U GamePad";
            this.pageWiiUGamePadController.UseVisualStyleBackColor = true;
            // 
            // wiiUGamePadOptions1
            // 
            this.wiiUGamePadOptions1.BackColor = System.Drawing.Color.White;
            this.wiiUGamePadOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiUGamePadOptions1.Enabled = false;
            this.wiiUGamePadOptions1.Input = null;
            this.wiiUGamePadOptions1.Location = new System.Drawing.Point(3, 3);
            this.wiiUGamePadOptions1.Name = "wiiUGamePadOptions1";
            this.wiiUGamePadOptions1.Size = new System.Drawing.Size(851, 444);
            this.wiiUGamePadOptions1.TabIndex = 0;
            // 
            // pageWiiUProController
            // 
            this.pageWiiUProController.Controls.Add(this.wiiUProOptions1);
            this.pageWiiUProController.Location = new System.Drawing.Point(4, 22);
            this.pageWiiUProController.Name = "pageWiiUProController";
            this.pageWiiUProController.Padding = new System.Windows.Forms.Padding(3);
            this.pageWiiUProController.Size = new System.Drawing.Size(857, 450);
            this.pageWiiUProController.TabIndex = 0;
            this.pageWiiUProController.Text = "Wii U Pro";
            this.pageWiiUProController.UseVisualStyleBackColor = true;
            // 
            // wiiUProOptions1
            // 
            this.wiiUProOptions1.BackColor = System.Drawing.Color.White;
            this.wiiUProOptions1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wiiUProOptions1.Enabled = false;
            this.wiiUProOptions1.Location = new System.Drawing.Point(3, 3);
            this.wiiUProOptions1.Name = "wiiUProOptions1";
            this.wiiUProOptions1.Size = new System.Drawing.Size(851, 444);
            this.wiiUProOptions1.TabIndex = 0;
            // 
            // pageDebug
            // 
            this.pageDebug.Location = new System.Drawing.Point(0, 0);
            this.pageDebug.Name = "pageDebug";
            this.pageDebug.Size = new System.Drawing.Size(874, 514);
            this.pageDebug.TabIndex = 3;
            this.pageDebug.Text = "pageDebug";
            this.pageDebug.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGames,
            this.btnOptions,
            this.btnControllers,
            this.btnDebug});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(874, 65);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuToolbar1";
            // 
            // btnGames
            // 
            this.btnGames.ForeColor = System.Drawing.Color.White;
            this.btnGames.Image = global::Decaf_Game_Launcher.Properties.Resources.games;
            this.btnGames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGames.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(52, 62);
            this.btnGames.Text = "Games";
            this.btnGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGames.Click += new System.EventHandler(this.MenuButtons_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = global::Decaf_Game_Launcher.Properties.Resources.options;
            this.btnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(53, 65);
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOptions.Click += new System.EventHandler(this.MenuButtons_Click);
            // 
            // btnControllers
            // 
            this.btnControllers.ForeColor = System.Drawing.Color.White;
            this.btnControllers.Image = global::Decaf_Game_Launcher.Properties.Resources.snes_controller;
            this.btnControllers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControllers.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnControllers.Name = "btnControllers";
            this.btnControllers.Size = new System.Drawing.Size(69, 62);
            this.btnControllers.Text = "Controllers";
            this.btnControllers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControllers.Click += new System.EventHandler(this.MenuButtons_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.ForeColor = System.Drawing.Color.White;
            this.btnDebug.Image = global::Decaf_Game_Launcher.Properties.Resources.debug_icon;
            this.btnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebug.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(52, 62);
            this.btnDebug.Text = "Debug";
            this.btnDebug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDebug.Click += new System.EventHandler(this.MenuButtons_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 604);
            this.Controls.Add(this.menuPages);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decaf Game Launcher - Games";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsGameDirectories.ResumeLayout(false);
            this.menuPages.ResumeLayout(false);
            this.pageGames.ResumeLayout(false);
            this.pageGames.PerformLayout();
            this.pageOptions.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.pageLauncherOptions.ResumeLayout(false);
            this.pageLauncherOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp_GameDirectories)).EndInit();
            this.pageDecafOptions.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pageControllers.ResumeLayout(false);
            this.tabControllers.ResumeLayout(false);
            this.pageWiiUGamePadController.ResumeLayout(false);
            this.pageWiiUProController.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.Menu.MenuToolbar menu;
        private System.Windows.Forms.ToolStripButton btnGames;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnControllers;
        private Controls.Menu.MenuPages menuPages;
        private System.Windows.Forms.TabPage pageGames;
        private System.Windows.Forms.TabPage pageOptions;
        private System.Windows.Forms.TabPage pageControllers;
        private System.Windows.Forms.FlowLayoutPanel flpGames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSaveOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecafPath;
        private System.Windows.Forms.CheckBox chkFindDecafExeAuto;
        private System.Windows.Forms.LinkLabel lblSelectDecafExe;
        private System.Windows.Forms.CheckBox chkDoubleClickToStartGame;
        private System.Windows.Forms.TabControl tabOptions;
        private System.Windows.Forms.TabPage pageLauncherOptions;
        private System.Windows.Forms.TabPage pageDecafOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblDecafOptions_GpuDebugFilters;
        private System.Windows.Forms.CheckBox chkDecafOptions_DebuggerBreakOnEntry;
        private System.Windows.Forms.CheckBox chkDecafOptions_GpuForceSync;
        private System.Windows.Forms.CheckBox chkDecafOptions_GpuDebug;
        private System.Windows.Forms.CheckBox chkDecafOptions_DebuggerEnabled;
        private System.Windows.Forms.ComboBox cbxDecafOptions_LogLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDecafOptions_GX2DumpShaders;
        private System.Windows.Forms.CheckBox chkDecafOptions_JitVerify;
        private System.Windows.Forms.CheckBox chkDecafOptions_GX2DumpTextures;
        private System.Windows.Forms.CheckBox chkDecafOptions_LogBranchTrace;
        private System.Windows.Forms.CheckBox chkDecafOptions_LogKernelTrace;
        private System.Windows.Forms.CheckBox chkDecafOptions_LogToStdOut;
        private System.Windows.Forms.CheckBox chkDecafOptions_LogToFile;
        private System.Windows.Forms.CheckBox chkDecafOptions_LogAsync;
        private System.Windows.Forms.CheckBox chkDecafOptions_SoundDumpSounds;
        private System.Windows.Forms.CheckBox chkDecafOptions_JitEnabled;
        private System.Windows.Forms.LinkLabel lblDecafOptions_KernelTraceFilters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picHelp_GameDirectories;
        private System.Windows.Forms.ListView vwGameDirectories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.LinkLabel lblAddGameDirectory;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip cmsGameDirectories;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Controls.Games.GamesQuickMenu gamesQuickMenu;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.ToolStripButton btnDebug;
        private System.Windows.Forms.TabPage pageDebug;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControllers;
        private System.Windows.Forms.TabPage pageWiiUProController;
        private System.Windows.Forms.TabPage pageWiiUGamePadController;
        private Controls.Controllers.WiiUProOptions wiiUProOptions1;
        private System.Windows.Forms.Button btnSaveControllers;
        private Controls.Controllers.WiiUGamePadOptions wiiUGamePadOptions1;
    }
}