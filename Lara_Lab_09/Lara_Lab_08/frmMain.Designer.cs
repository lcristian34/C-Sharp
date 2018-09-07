namespace Lara_Lab_08
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnusMainStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchFName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchLName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxBook = new System.Windows.Forms.PictureBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.mnusMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // mnusMainStrip
            // 
            this.mnusMainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnusMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuSearch,
            this.mnuHelp});
            this.mnusMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnusMainStrip.Name = "mnusMainStrip";
            this.mnusMainStrip.Size = new System.Drawing.Size(452, 24);
            this.mnusMainStrip.TabIndex = 0;
            this.mnusMainStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrint,
            this.mnuPrintPreview,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(143, 22);
            this.mnuPrint.Text = "Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(143, 22);
            this.mnuPrintPreview.Text = "Print Preview";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuUpdate,
            this.mnuDelete});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(112, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(112, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(112, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchFName,
            this.mnuSearchLName});
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.Size = new System.Drawing.Size(70, 20);
            this.mnuSearch.Text = "Search by";
            // 
            // mnuSearchFName
            // 
            this.mnuSearchFName.Name = "mnuSearchFName";
            this.mnuSearchFName.Size = new System.Drawing.Size(131, 22);
            this.mnuSearchFName.Text = "First Name";
            this.mnuSearchFName.Click += new System.EventHandler(this.mnuSearchFName_Click);
            // 
            // mnuSearchLName
            // 
            this.mnuSearchLName.Name = "mnuSearchLName";
            this.mnuSearchLName.Size = new System.Drawing.Size(131, 22);
            this.mnuSearchLName.Text = "Last Name";
            this.mnuSearchLName.Click += new System.EventHandler(this.mnuSearchLName_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // pbxBook
            // 
            this.pbxBook.Image = ((System.Drawing.Image)(resources.GetObject("pbxBook.Image")));
            this.pbxBook.Location = new System.Drawing.Point(85, 27);
            this.pbxBook.Name = "pbxBook";
            this.pbxBook.Size = new System.Drawing.Size(272, 265);
            this.pbxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBook.TabIndex = 1;
            this.pbxBook.TabStop = false;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(80, 312);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(289, 25);
            this.lblClass.TabIndex = 2;
            this.lblClass.Text = "ITSE 2338 Advance C# .NET";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 346);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.pbxBook);
            this.Controls.Add(this.mnusMainStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnusMainStrip;
            this.Name = "frmMain";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnusMainStrip.ResumeLayout(false);
            this.mnusMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMainStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.PictureBox pbxBook;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchFName;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchLName;
    }
}

