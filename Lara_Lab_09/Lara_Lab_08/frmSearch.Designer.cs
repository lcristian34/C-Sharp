namespace Lara_Lab_08
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblEnterSearch = new System.Windows.Forms.Label();
            this.txtlblEnterSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstRecordNum = new System.Windows.Forms.ListBox();
            this.lstFName = new System.Windows.Forms.ListBox();
            this.lstLName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEnterSearch
            // 
            this.lblEnterSearch.AutoSize = true;
            this.lblEnterSearch.Location = new System.Drawing.Point(31, 18);
            this.lblEnterSearch.Name = "lblEnterSearch";
            this.lblEnterSearch.Size = new System.Drawing.Size(38, 13);
            this.lblEnterSearch.TabIndex = 0;
            this.lblEnterSearch.Text = "Enter :";
            // 
            // txtlblEnterSearch
            // 
            this.txtlblEnterSearch.Location = new System.Drawing.Point(34, 43);
            this.txtlblEnterSearch.Name = "txtlblEnterSearch";
            this.txtlblEnterSearch.Size = new System.Drawing.Size(100, 20);
            this.txtlblEnterSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 222);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstRecordNum
            // 
            this.lstRecordNum.FormattingEnabled = true;
            this.lstRecordNum.Items.AddRange(new object[] {
            "Record #",
            "-----------------"});
            this.lstRecordNum.Location = new System.Drawing.Point(34, 69);
            this.lstRecordNum.Name = "lstRecordNum";
            this.lstRecordNum.Size = new System.Drawing.Size(64, 121);
            this.lstRecordNum.TabIndex = 5;
            // 
            // lstFName
            // 
            this.lstFName.FormattingEnabled = true;
            this.lstFName.Items.AddRange(new object[] {
            "First Name",
            "------------------------------------"});
            this.lstFName.Location = new System.Drawing.Point(94, 69);
            this.lstFName.Name = "lstFName";
            this.lstFName.Size = new System.Drawing.Size(120, 121);
            this.lstFName.TabIndex = 6;
            // 
            // lstLName
            // 
            this.lstLName.FormattingEnabled = true;
            this.lstLName.Items.AddRange(new object[] {
            "Last Name",
            "------------------------------------"});
            this.lstLName.Location = new System.Drawing.Point(211, 69);
            this.lstLName.Name = "lstLName";
            this.lstLName.Size = new System.Drawing.Size(120, 121);
            this.lstLName.TabIndex = 7;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 261);
            this.Controls.Add(this.lstLName);
            this.Controls.Add(this.lstFName);
            this.Controls.Add(this.lstRecordNum);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtlblEnterSearch);
            this.Controls.Add(this.lblEnterSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtlblEnterSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstRecordNum;
        private System.Windows.Forms.ListBox lstFName;
        private System.Windows.Forms.ListBox lstLName;
        public System.Windows.Forms.Label lblEnterSearch;
    }
}