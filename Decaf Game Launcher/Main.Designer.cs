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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuPages = new Decaf_Game_Launcher.Controls.Menu.MenuPages();
            this.pageGames = new System.Windows.Forms.TabPage();
            this.flpGames = new System.Windows.Forms.FlowLayoutPanel();
            this.pageOptions = new System.Windows.Forms.TabPage();
            this.lblSelectDecafExe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecafPath = new System.Windows.Forms.TextBox();
            this.chkFindDecafExeAuto = new System.Windows.Forms.CheckBox();
            this.btnSaveOptions = new System.Windows.Forms.Button();
            this.pageControllers = new System.Windows.Forms.TabPage();
            this.menu = new Decaf_Game_Launcher.Controls.Menu.MenuToolbar();
            this.btnGames = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnControllers = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.menuPages.SuspendLayout();
            this.pageGames.SuspendLayout();
            this.pageOptions.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 21);
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
            // menuPages
            // 
            this.menuPages.Controls.Add(this.pageGames);
            this.menuPages.Controls.Add(this.pageOptions);
            this.menuPages.Controls.Add(this.pageControllers);
            this.menuPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPages.Location = new System.Drawing.Point(0, 62);
            this.menuPages.Name = "menuPages";
            this.menuPages.SelectedIndex = 0;
            this.menuPages.Size = new System.Drawing.Size(806, 364);
            this.menuPages.TabIndex = 2;
            // 
            // pageGames
            // 
            this.pageGames.Controls.Add(this.flpGames);
            this.pageGames.Location = new System.Drawing.Point(0, 0);
            this.pageGames.Name = "pageGames";
            this.pageGames.Padding = new System.Windows.Forms.Padding(3);
            this.pageGames.Size = new System.Drawing.Size(806, 360);
            this.pageGames.TabIndex = 0;
            this.pageGames.Text = "tabPage1";
            this.pageGames.UseVisualStyleBackColor = true;
            // 
            // flpGames
            // 
            this.flpGames.AutoScroll = true;
            this.flpGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGames.Location = new System.Drawing.Point(3, 3);
            this.flpGames.Name = "flpGames";
            this.flpGames.Size = new System.Drawing.Size(800, 354);
            this.flpGames.TabIndex = 0;
            // 
            // pageOptions
            // 
            this.pageOptions.Controls.Add(this.lblSelectDecafExe);
            this.pageOptions.Controls.Add(this.label1);
            this.pageOptions.Controls.Add(this.txtDecafPath);
            this.pageOptions.Controls.Add(this.chkFindDecafExeAuto);
            this.pageOptions.Controls.Add(this.btnSaveOptions);
            this.pageOptions.Location = new System.Drawing.Point(0, 0);
            this.pageOptions.Name = "pageOptions";
            this.pageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pageOptions.Size = new System.Drawing.Size(806, 364);
            this.pageOptions.TabIndex = 1;
            this.pageOptions.Text = "tabPage2";
            this.pageOptions.UseVisualStyleBackColor = true;
            // 
            // lblSelectDecafExe
            // 
            this.lblSelectDecafExe.ActiveLinkColor = System.Drawing.Color.White;
            this.lblSelectDecafExe.AutoSize = true;
            this.lblSelectDecafExe.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(131)))), ((int)(((byte)(220)))));
            this.lblSelectDecafExe.Location = new System.Drawing.Point(278, 41);
            this.lblSelectDecafExe.Name = "lblSelectDecafExe";
            this.lblSelectDecafExe.Size = new System.Drawing.Size(58, 13);
            this.lblSelectDecafExe.TabIndex = 5;
            this.lblSelectDecafExe.TabStop = true;
            this.lblSelectDecafExe.Text = "Select Exe";
            this.lblSelectDecafExe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectDecafExe_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Decaf Path:";
            // 
            // txtDecafPath
            // 
            this.txtDecafPath.Location = new System.Drawing.Point(101, 37);
            this.txtDecafPath.Name = "txtDecafPath";
            this.txtDecafPath.Size = new System.Drawing.Size(174, 20);
            this.txtDecafPath.TabIndex = 2;
            // 
            // chkFindDecafExeAuto
            // 
            this.chkFindDecafExeAuto.AutoSize = true;
            this.chkFindDecafExeAuto.Location = new System.Drawing.Point(12, 17);
            this.chkFindDecafExeAuto.Name = "chkFindDecafExeAuto";
            this.chkFindDecafExeAuto.Size = new System.Drawing.Size(270, 17);
            this.chkFindDecafExeAuto.TabIndex = 1;
            this.chkFindDecafExeAuto.Text = "Find Decaf Exectuable (decaf-sdl.exe) automatically";
            this.chkFindDecafExeAuto.UseVisualStyleBackColor = true;
            // 
            // btnSaveOptions
            // 
            this.btnSaveOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOptions.Location = new System.Drawing.Point(723, 335);
            this.btnSaveOptions.Name = "btnSaveOptions";
            this.btnSaveOptions.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOptions.TabIndex = 0;
            this.btnSaveOptions.Text = "Save";
            this.btnSaveOptions.UseVisualStyleBackColor = true;
            this.btnSaveOptions.Click += new System.EventHandler(this.btnSaveOptions_Click);
            // 
            // pageControllers
            // 
            this.pageControllers.Location = new System.Drawing.Point(0, 0);
            this.pageControllers.Name = "pageControllers";
            this.pageControllers.Padding = new System.Windows.Forms.Padding(3);
            this.pageControllers.Size = new System.Drawing.Size(806, 360);
            this.pageControllers.TabIndex = 2;
            this.pageControllers.Text = "tabPage3";
            this.pageControllers.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGames,
            this.btnOptions,
            this.btnControllers});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(806, 62);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuToolbar1";
            // 
            // btnGames
            // 
            this.btnGames.ForeColor = System.Drawing.Color.White;
            this.btnGames.Image = global::Decaf_Game_Launcher.Properties.Resources.games;
            this.btnGames.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(52, 59);
            this.btnGames.Text = "Games";
            this.btnGames.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = global::Decaf_Game_Launcher.Properties.Resources.options;
            this.btnOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(53, 62);
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOptions.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnControllers
            // 
            this.btnControllers.ForeColor = System.Drawing.Color.White;
            this.btnControllers.Image = global::Decaf_Game_Launcher.Properties.Resources.snes_controller;
            this.btnControllers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControllers.Name = "btnControllers";
            this.btnControllers.Size = new System.Drawing.Size(69, 59);
            this.btnControllers.Text = "Controllers";
            this.btnControllers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControllers.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 447);
            this.Controls.Add(this.menuPages);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuPages.ResumeLayout(false);
            this.pageGames.ResumeLayout(false);
            this.pageOptions.ResumeLayout(false);
            this.pageOptions.PerformLayout();
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
    }
}