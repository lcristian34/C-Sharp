namespace Lara_Lab_11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_AddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_UpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_DeleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSubjectCodes = new System.Windows.Forms.Label();
            this.cbxSubjectCodes = new System.Windows.Forms.ComboBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.mbxCopyDate = new System.Windows.Forms.MaskedTextBox();
            this.mbxSubCode = new System.Windows.Forms.MaskedTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblCopyDate = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblSubCode = new System.Windows.Forms.Label();
            this.bbsSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.errProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnsMainMenu.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnsMainMenu.Size = new System.Drawing.Size(1012, 28);
            this.mnsMainMenu.TabIndex = 0;
            this.mnsMainMenu.Text = "menuStrip1";
            this.mnsMainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMainMenu_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_ClearAll,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_ClearAll
            // 
            this.mnuFile_ClearAll.Name = "mnuFile_ClearAll";
            this.mnuFile_ClearAll.Size = new System.Drawing.Size(140, 26);
            this.mnuFile_ClearAll.Text = "Clear All";
            this.mnuFile_ClearAll.Click += new System.EventHandler(this.mnuFile_ClearAll_Click);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(140, 26);
            this.mnuFile_Exit.Text = "Exit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_AddBook,
            this.mnuEdit_UpdateBook,
            this.mnuEdit_DeleteBook});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(47, 24);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEdit_AddBook
            // 
            this.mnuEdit_AddBook.Name = "mnuEdit_AddBook";
            this.mnuEdit_AddBook.Size = new System.Drawing.Size(171, 26);
            this.mnuEdit_AddBook.Text = "Add Book";
            this.mnuEdit_AddBook.Click += new System.EventHandler(this.mnuEdit_AddBook_Click);
            // 
            // mnuEdit_UpdateBook
            // 
            this.mnuEdit_UpdateBook.Name = "mnuEdit_UpdateBook";
            this.mnuEdit_UpdateBook.Size = new System.Drawing.Size(171, 26);
            this.mnuEdit_UpdateBook.Text = "Update Book";
            this.mnuEdit_UpdateBook.Click += new System.EventHandler(this.mnuEdit_UpdateBook_Click);
            // 
            // mnuEdit_DeleteBook
            // 
            this.mnuEdit_DeleteBook.Name = "mnuEdit_DeleteBook";
            this.mnuEdit_DeleteBook.Size = new System.Drawing.Size(171, 26);
            this.mnuEdit_DeleteBook.Text = "Delete Book";
            this.mnuEdit_DeleteBook.Click += new System.EventHandler(this.mnuEdit_DeleteBook_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(125, 26);
            this.mnuHelp_About.Text = "About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // lblSubjectCodes
            // 
            this.lblSubjectCodes.AutoSize = true;
            this.lblSubjectCodes.Location = new System.Drawing.Point(35, 54);
            this.lblSubjectCodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectCodes.Name = "lblSubjectCodes";
            this.lblSubjectCodes.Size = new System.Drawing.Size(164, 17);
            this.lblSubjectCodes.TabIndex = 1;
            this.lblSubjectCodes.Text = "Available Subject Codes:";
            // 
            // cbxSubjectCodes
            // 
            this.cbxSubjectCodes.FormattingEnabled = true;
            this.cbxSubjectCodes.Location = new System.Drawing.Point(209, 50);
            this.cbxSubjectCodes.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSubjectCodes.Name = "cbxSubjectCodes";
            this.cbxSubjectCodes.Size = new System.Drawing.Size(160, 24);
            this.cbxSubjectCodes.TabIndex = 2;
            this.cbxSubjectCodes.Text = "All Sub Codes";
            this.cbxSubjectCodes.SelectedIndexChanged += new System.EventHandler(this.cbxSubjectCodes_SelectedIndexChanged);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.mbxCopyDate);
            this.grpInfo.Controls.Add(this.mbxSubCode);
            this.grpInfo.Controls.Add(this.btnOk);
            this.grpInfo.Controls.Add(this.txtPages);
            this.grpInfo.Controls.Add(this.lblPages);
            this.grpInfo.Controls.Add(this.txtPublisher);
            this.grpInfo.Controls.Add(this.lblPublisher);
            this.grpInfo.Controls.Add(this.txtAuthor);
            this.grpInfo.Controls.Add(this.lblAuthor);
            this.grpInfo.Controls.Add(this.lblCopyDate);
            this.grpInfo.Controls.Add(this.txtTitle);
            this.grpInfo.Controls.Add(this.lblTitle);
            this.grpInfo.Controls.Add(this.txtISBN);
            this.grpInfo.Controls.Add(this.lblISBN);
            this.grpInfo.Controls.Add(this.lblSubCode);
            this.grpInfo.Location = new System.Drawing.Point(16, 97);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpInfo.Size = new System.Drawing.Size(480, 203);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            // 
            // mbxCopyDate
            // 
            this.mbxCopyDate.Location = new System.Drawing.Point(105, 119);
            this.mbxCopyDate.Margin = new System.Windows.Forms.Padding(4);
            this.mbxCopyDate.Mask = "0000";
            this.mbxCopyDate.Name = "mbxCopyDate";
            this.mbxCopyDate.PromptChar = ' ';
            this.mbxCopyDate.Size = new System.Drawing.Size(132, 22);
            this.mbxCopyDate.TabIndex = 8;
            // 
            // mbxSubCode
            // 
            this.mbxSubCode.Location = new System.Drawing.Point(105, 21);
            this.mbxSubCode.Margin = new System.Windows.Forms.Padding(4);
            this.mbxSubCode.Mask = ">LLL";
            this.mbxSubCode.Name = "mbxSubCode";
            this.mbxSubCode.PromptChar = ' ';
            this.mbxSubCode.Size = new System.Drawing.Size(132, 22);
            this.mbxSubCode.TabIndex = 3;
            this.mbxSubCode.Validating += new System.ComponentModel.CancelEventHandler(this.mbxSubCode_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(339, 159);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 28);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(105, 151);
            this.txtPages.Margin = new System.Windows.Forms.Padding(4);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(132, 22);
            this.txtPages.TabIndex = 10;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(40, 155);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(48, 17);
            this.lblPages.TabIndex = 12;
            this.lblPages.Text = "Pages";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(321, 123);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(132, 22);
            this.txtPublisher.TabIndex = 9;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(247, 127);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(71, 17);
            this.lblPublisher.TabIndex = 10;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(105, 87);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(348, 22);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(43, 91);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 17);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author:";
            // 
            // lblCopyDate
            // 
            this.lblCopyDate.AutoSize = true;
            this.lblCopyDate.Location = new System.Drawing.Point(9, 123);
            this.lblCopyDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyDate.Name = "lblCopyDate";
            this.lblCopyDate.Size = new System.Drawing.Size(78, 17);
            this.lblCopyDate.TabIndex = 6;
            this.lblCopyDate.Text = "Copy Date:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 55);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(348, 22);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(49, 59);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(321, 21);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(132, 22);
            this.txtISBN.TabIndex = 4;
            this.txtISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtISBN_KeyUp);
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(267, 25);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(43, 17);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblSubCode
            // 
            this.lblSubCode.AutoSize = true;
            this.lblSubCode.Location = new System.Drawing.Point(13, 25);
            this.lblSubCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubCode.Name = "lblSubCode";
            this.lblSubCode.Size = new System.Drawing.Size(74, 17);
            this.lblSubCode.TabIndex = 0;
            this.lblSubCode.Text = "Sub Code:";
            // 
            // bbsSource
            // 
            this.bbsSource.DataMember = "Books";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(516, 33);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(460, 277);
            this.dgvBooks.TabIndex = 4;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // errProviderTxt
            // 
            this.errProviderTxt.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 325);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.cbxSubjectCodes);
            this.Controls.Add(this.lblSubjectCodes);
            this.Controls.Add(this.mnsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "DB: Books";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bbsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_ClearAll;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_AddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_UpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_DeleteBook;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.Label lblSubjectCodes;
        private System.Windows.Forms.ComboBox cbxSubjectCodes;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblCopyDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblSubCode;
        //private Books_2010DataSet books_2010DataSet;
        private System.Windows.Forms.BindingSource bbsSource;
        //private Books_2010DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        public System.Windows.Forms.DataGridView dgvBooks;
        public System.Windows.Forms.TextBox txtPages;
        public System.Windows.Forms.TextBox txtPublisher;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.MaskedTextBox mbxSubCode;
        public System.Windows.Forms.MaskedTextBox mbxCopyDate;
        public System.Windows.Forms.ErrorProvider errProviderTxt;
    }
}

