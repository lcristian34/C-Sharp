namespace Lara_Lab_10
{
    partial class frmProductionWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionWorker));
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpPW = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtShift = new System.Windows.Forms.MaskedTextBox();
            this.grpPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(11, 34);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(45, 13);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Emp ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(2, 111);
            this.lblPayRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(54, 13);
            this.lblPayRate.TabIndex = 3;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(163, 114);
            this.lblShift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(31, 13);
            this.lblShift.TabIndex = 8;
            this.lblShift.Text = "Shift:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(21, 254);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 19);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(121, 254);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 19);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 254);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpPW
            // 
            this.grpPW.Controls.Add(this.txtShift);
            this.grpPW.Controls.Add(this.txtName);
            this.grpPW.Controls.Add(this.lblEmpID);
            this.grpPW.Controls.Add(this.txtEmpID);
            this.grpPW.Controls.Add(this.lblName);
            this.grpPW.Controls.Add(this.lblShift);
            this.grpPW.Controls.Add(this.lblPayRate);
            this.grpPW.Controls.Add(this.txtPayRate);
            this.grpPW.Location = new System.Drawing.Point(12, 12);
            this.grpPW.Name = "grpPW";
            this.grpPW.Size = new System.Drawing.Size(273, 155);
            this.grpPW.TabIndex = 12;
            this.grpPW.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 71);
            this.txtName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 14;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmpID.Location = new System.Drawing.Point(69, 34);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(176, 20);
            this.txtEmpID.TabIndex = 1;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(69, 111);
            this.txtPayRate.Margin = new System.Windows.Forms.Padding(2);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(76, 20);
            this.txtPayRate.TabIndex = 6;
            this.txtPayRate.TextChanged += new System.EventHandler(this.txtPayRate_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(218, 218);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 19);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(199, 111);
            this.txtShift.Mask = "0";
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(46, 20);
            this.txtShift.TabIndex = 14;
            // 
            // frmProductionWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 289);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpPW);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProductionWorker";
            this.Text = "Production Worker";
            this.Load += new System.EventHandler(this.frmProductionWorker_Load);
            this.grpPW.ResumeLayout(false);
            this.grpPW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.GroupBox grpPW;
        public System.Windows.Forms.Button btnPrevious;
        public System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.Label lblPayRate;
        public System.Windows.Forms.Label lblShift;
        public System.Windows.Forms.TextBox txtPayRate;
        public System.Windows.Forms.TextBox txtEmpID;
        public System.Windows.Forms.MaskedTextBox txtName;
        public System.Windows.Forms.MaskedTextBox txtShift;
    }
}