namespace Decaf_Game_Launcher.Controls.Games
{
    partial class CompactGameView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblGameSize = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.cmsGame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenBoxArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenInFileSystem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.cmsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.Location = new System.Drawing.Point(135, 21);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(230, 23);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Test Game Name";
            this.lblGameName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseClick);
            this.lblGameName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseDoubleClick);
            // 
            // lblPublisher
            // 
            this.lblPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(371, 21);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(256, 23);
            this.lblPublisher.TabIndex = 1;
            this.lblPublisher.Text = "TestPublisher";
            this.lblPublisher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseClick);
            this.lblPublisher.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseDoubleClick);
            // 
            // lblGameSize
            // 
            this.lblGameSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGameSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameSize.Location = new System.Drawing.Point(650, 21);
            this.lblGameSize.Name = "lblGameSize";
            this.lblGameSize.Size = new System.Drawing.Size(123, 23);
            this.lblGameSize.TabIndex = 1;
            this.lblGameSize.Text = "TestSize";
            this.lblGameSize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseClick);
            this.lblGameSize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseDoubleClick);
            // 
            // picBanner
            // 
            this.picBanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(116, 65);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            this.picBanner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseClick);
            this.picBanner.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseDoubleClick);
            // 
            // cmsGame
            // 
            this.cmsGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenBoxArt,
            this.tsmiOpenInFileSystem});
            this.cmsGame.Name = "cmsGame";
            this.cmsGame.Size = new System.Drawing.Size(213, 48);
            this.cmsGame.Text = "Test";
            // 
            // tsmiOpenBoxArt
            // 
            this.tsmiOpenBoxArt.Name = "tsmiOpenBoxArt";
            this.tsmiOpenBoxArt.Size = new System.Drawing.Size(212, 22);
            this.tsmiOpenBoxArt.Text = "Open box art @ GameTDB";
            this.tsmiOpenBoxArt.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // tsmiOpenInFileSystem
            // 
            this.tsmiOpenInFileSystem.Name = "tsmiOpenInFileSystem";
            this.tsmiOpenInFileSystem.Size = new System.Drawing.Size(212, 22);
            this.tsmiOpenInFileSystem.Text = "Open in file system";
            this.tsmiOpenInFileSystem.Click += new System.EventHandler(this.ToolStripMenuItems_Click);
            // 
            // CompactGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmsGame;
            this.Controls.Add(this.lblGameSize);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.picBanner);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CompactGameView";
            this.Size = new System.Drawing.Size(776, 65);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CompactGameView_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.cmsGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblGameSize;
        private System.Windows.Forms.ContextMenuStrip cmsGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenBoxArt;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenInFileSystem;
    }
}
