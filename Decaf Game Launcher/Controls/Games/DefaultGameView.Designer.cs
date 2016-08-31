namespace Decaf_Game_Launcher.Controls.Games
{
    partial class DefaultGameView
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
            this.picBoxArt = new System.Windows.Forms.PictureBox();
            this.cmsGame = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpenBoxArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenInFileSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.translucentPanel1 = new Decaf_Game_Launcher.Controls.Games.TranslucentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArt)).BeginInit();
            this.cmsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxArt
            // 
            this.picBoxArt.ContextMenuStrip = this.cmsGame;
            this.picBoxArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxArt.Location = new System.Drawing.Point(0, 0);
            this.picBoxArt.Name = "picBoxArt";
            this.picBoxArt.Size = new System.Drawing.Size(250, 352);
            this.picBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArt.TabIndex = 0;
            this.picBoxArt.TabStop = false;
            this.picBoxArt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBoxArt_MouseClick);
            this.picBoxArt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picBoxArt_MouseDoubleClick);
            // 
            // cmsGame
            // 
            this.cmsGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenBoxArt,
            this.tsmiOpenInFileSystem});
            this.cmsGame.Name = "cmsGame";
            this.cmsGame.Size = new System.Drawing.Size(213, 48);
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
            // translucentPanel1
            // 
            this.translucentPanel1.BackColor = System.Drawing.Color.Black;
            this.translucentPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.translucentPanel1.Location = new System.Drawing.Point(0, 324);
            this.translucentPanel1.Name = "translucentPanel1";
            this.translucentPanel1.Size = new System.Drawing.Size(250, 28);
            this.translucentPanel1.TabIndex = 1;
            // 
            // DefaultGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.translucentPanel1);
            this.Controls.Add(this.picBoxArt);
            this.Name = "DefaultGameView";
            this.Size = new System.Drawing.Size(250, 352);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArt)).EndInit();
            this.cmsGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxArt;
        private TranslucentPanel translucentPanel1;
        private System.Windows.Forms.ContextMenuStrip cmsGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenBoxArt;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenInFileSystem;
    }
}
