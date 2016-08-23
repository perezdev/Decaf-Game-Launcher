namespace Decaf_Game_Launcher.Controls.Games
{
    partial class GameView
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
            this.picGameCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGameCover)).BeginInit();
            this.SuspendLayout();
            // 
            // picGameCover
            // 
            this.picGameCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGameCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picGameCover.Location = new System.Drawing.Point(0, 0);
            this.picGameCover.Name = "picGameCover";
            this.picGameCover.Size = new System.Drawing.Size(250, 352);
            this.picGameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGameCover.TabIndex = 0;
            this.picGameCover.TabStop = false;
            this.picGameCover.DoubleClick += new System.EventHandler(this.picGameCover_DoubleClick);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picGameCover);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(250, 352);
            ((System.ComponentModel.ISupportInitialize)(this.picGameCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGameCover;
    }
}
