namespace Decaf_Game_Launcher.Controls.Controllers
{
    partial class WiiUProOptions
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
            this.cbxControllerType = new System.Windows.Forms.ComboBox();
            this.cbxControllerNumber = new System.Windows.Forms.ComboBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.picController = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picController)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxControllerType
            // 
            this.cbxControllerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxControllerType.Enabled = false;
            this.cbxControllerType.FormattingEnabled = true;
            this.cbxControllerType.Items.AddRange(new object[] {
            "Standard Controller",
            "Keyboard"});
            this.cbxControllerType.Location = new System.Drawing.Point(159, 5);
            this.cbxControllerType.Name = "cbxControllerType";
            this.cbxControllerType.Size = new System.Drawing.Size(148, 21);
            this.cbxControllerType.TabIndex = 1;
            // 
            // cbxControllerNumber
            // 
            this.cbxControllerNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxControllerNumber.Enabled = false;
            this.cbxControllerNumber.FormattingEnabled = true;
            this.cbxControllerNumber.Items.AddRange(new object[] {
            "Controller 1",
            "Controller 2",
            "Controller 3",
            "Controller 4"});
            this.cbxControllerNumber.Location = new System.Drawing.Point(5, 5);
            this.cbxControllerNumber.Name = "cbxControllerNumber";
            this.cbxControllerNumber.Size = new System.Drawing.Size(148, 21);
            this.cbxControllerNumber.TabIndex = 2;
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.AutoSize = true;
            this.lblDivider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblDivider.Location = new System.Drawing.Point(-178, 19);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(1147, 13);
            this.lblDivider.TabIndex = 4;
            this.lblDivider.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_____________________________";
            // 
            // picController
            // 
            this.picController.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picController.Enabled = false;
            this.picController.Image = global::Decaf_Game_Launcher.Properties.Resources.controller_wiiupro;
            this.picController.Location = new System.Drawing.Point(159, 35);
            this.picController.Name = "picController";
            this.picController.Size = new System.Drawing.Size(526, 355);
            this.picController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picController.TabIndex = 5;
            this.picController.TabStop = false;
            // 
            // WiiUProOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picController);
            this.Controls.Add(this.cbxControllerType);
            this.Controls.Add(this.cbxControllerNumber);
            this.Controls.Add(this.lblDivider);
            this.Name = "WiiUProOptions";
            this.Size = new System.Drawing.Size(851, 387);
            this.SizeChanged += new System.EventHandler(this.WiiUProOptions_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxControllerType;
        private System.Windows.Forms.ComboBox cbxControllerNumber;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.PictureBox picController;
    }
}
