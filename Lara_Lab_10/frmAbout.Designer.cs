namespace Lara_Lab_10
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxMew = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMew)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Inheritance";
            // 
            // pbxMew
            // 
            this.pbxMew.Image = ((System.Drawing.Image)(resources.GetObject("pbxMew.Image")));
            this.pbxMew.Location = new System.Drawing.Point(19, 37);
            this.pbxMew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxMew.Name = "pbxMew";
            this.pbxMew.Size = new System.Drawing.Size(262, 137);
            this.pbxMew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMew.TabIndex = 0;
            this.pbxMew.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(45, 189);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(204, 52);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "Programmed by Christian Lara\r\n\r\nThis program showcases the functionality \r\nof Inh" +
    "erited forms and classes";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(126, 263);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 292);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxMew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbxMew;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Button btnClose;
    }
}