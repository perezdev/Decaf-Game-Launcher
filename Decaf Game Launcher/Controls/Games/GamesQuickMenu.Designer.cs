namespace Decaf_Game_Launcher.Controls.Games
{
    partial class GamesQuickMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBars = new System.Windows.Forms.PictureBox();
            this.picGrid = new System.Windows.Forms.PictureBox();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new Decaf_Game_Launcher.Controls.Games.SearchTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipQuickMenu = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.picSearchIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 24);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picBars);
            this.panel2.Controls.Add(this.picGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(493, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 24);
            this.panel2.TabIndex = 4;
            // 
            // picBars
            // 
            this.picBars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBars.Image = global::Decaf_Game_Launcher.Properties.Resources.gridview_compact_gray;
            this.picBars.Location = new System.Drawing.Point(159, 4);
            this.picBars.Name = "picBars";
            this.picBars.Size = new System.Drawing.Size(16, 16);
            this.picBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBars.TabIndex = 3;
            this.picBars.TabStop = false;
            this.toolTipQuickMenu.SetToolTip(this.picBars, "Compact View");
            this.picBars.Click += new System.EventHandler(this.ViewChange_Click);
            // 
            // picGrid
            // 
            this.picGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGrid.Image = global::Decaf_Game_Launcher.Properties.Resources.gridview_default_blue;
            this.picGrid.Location = new System.Drawing.Point(181, 4);
            this.picGrid.Name = "picGrid";
            this.picGrid.Size = new System.Drawing.Size(16, 16);
            this.picGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrid.TabIndex = 3;
            this.picGrid.TabStop = false;
            this.toolTipQuickMenu.SetToolTip(this.picGrid, "Grid View");
            this.picGrid.Click += new System.EventHandler(this.ViewChange_Click);
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Image = global::Decaf_Game_Launcher.Properties.Resources.search_gray;
            this.picSearchIcon.Location = new System.Drawing.Point(6, 4);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(16, 16);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon.TabIndex = 1;
            this.picSearchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.txtSearch.Location = new System.Drawing.Point(27, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 19);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(118, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIEW";
            // 
            // toolTipQuickMenu
            // 
            this.toolTipQuickMenu.BackColor = System.Drawing.SystemColors.Control;
            // 
            // GamesQuickMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GamesQuickMenu";
            this.Size = new System.Drawing.Size(693, 24);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SearchTextBox txtSearch;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipQuickMenu;
    }
}
