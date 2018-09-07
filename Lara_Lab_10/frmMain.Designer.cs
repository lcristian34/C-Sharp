namespace Lara_Lab_10
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_PrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_PrintPreview_PW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_PrintPreview_SS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_PrintPreview_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFIle_Print_PW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFIle_Print_SS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFIle_Print_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Add_PW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Add_SS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Add_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Update_PW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Update_SS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Update_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_PW = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_SS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView_TL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuHelp});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnsMain.Size = new System.Drawing.Size(309, 24);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_PrintPreview,
            this.mnuFile_Print,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_PrintPreview
            // 
            this.mnuFile_PrintPreview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_PrintPreview_PW,
            this.mnuFile_PrintPreview_SS,
            this.mnuFile_PrintPreview_TL});
            this.mnuFile_PrintPreview.Name = "mnuFile_PrintPreview";
            this.mnuFile_PrintPreview.Size = new System.Drawing.Size(143, 22);
            this.mnuFile_PrintPreview.Text = "Print Preview";
            this.mnuFile_PrintPreview.Click += new System.EventHandler(this.mnuFile_PrintPreview_Click);
            // 
            // mnuFile_PrintPreview_PW
            // 
            this.mnuFile_PrintPreview_PW.Name = "mnuFile_PrintPreview_PW";
            this.mnuFile_PrintPreview_PW.Size = new System.Drawing.Size(174, 22);
            this.mnuFile_PrintPreview_PW.Text = "Production Worker";
            this.mnuFile_PrintPreview_PW.Click += new System.EventHandler(this.mnuFile_PrintPreview_PW_Click);
            // 
            // mnuFile_PrintPreview_SS
            // 
            this.mnuFile_PrintPreview_SS.Name = "mnuFile_PrintPreview_SS";
            this.mnuFile_PrintPreview_SS.Size = new System.Drawing.Size(174, 22);
            this.mnuFile_PrintPreview_SS.Text = "Shift Supervisor";
            this.mnuFile_PrintPreview_SS.Click += new System.EventHandler(this.mnuFile_PrintPreview_SS_Click);
            // 
            // mnuFile_PrintPreview_TL
            // 
            this.mnuFile_PrintPreview_TL.Name = "mnuFile_PrintPreview_TL";
            this.mnuFile_PrintPreview_TL.Size = new System.Drawing.Size(174, 22);
            this.mnuFile_PrintPreview_TL.Text = "Team Leader";
            this.mnuFile_PrintPreview_TL.Click += new System.EventHandler(this.mnuFile_PrintPreview_TL_Click);
            // 
            // mnuFile_Print
            // 
            this.mnuFile_Print.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFIle_Print_PW,
            this.mnuFIle_Print_SS,
            this.mnuFIle_Print_TL});
            this.mnuFile_Print.Name = "mnuFile_Print";
            this.mnuFile_Print.Size = new System.Drawing.Size(143, 22);
            this.mnuFile_Print.Text = "Print";
            // 
            // mnuFIle_Print_PW
            // 
            this.mnuFIle_Print_PW.Name = "mnuFIle_Print_PW";
            this.mnuFIle_Print_PW.Size = new System.Drawing.Size(174, 22);
            this.mnuFIle_Print_PW.Text = "Production Worker";
            this.mnuFIle_Print_PW.Click += new System.EventHandler(this.mnuFIle_Print_PW_Click);
            // 
            // mnuFIle_Print_SS
            // 
            this.mnuFIle_Print_SS.Name = "mnuFIle_Print_SS";
            this.mnuFIle_Print_SS.Size = new System.Drawing.Size(174, 22);
            this.mnuFIle_Print_SS.Text = "Shift Supervisor";
            this.mnuFIle_Print_SS.Click += new System.EventHandler(this.mnuFIle_Print_SS_Click);
            // 
            // mnuFIle_Print_TL
            // 
            this.mnuFIle_Print_TL.Name = "mnuFIle_Print_TL";
            this.mnuFIle_Print_TL.Size = new System.Drawing.Size(174, 22);
            this.mnuFIle_Print_TL.Text = "Team Leader";
            this.mnuFIle_Print_TL.Click += new System.EventHandler(this.mnuFIle_Print_TL_Click);
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
            this.mnuEdit_Add,
            this.mnuUpdate_Add});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEdit_Add
            // 
            this.mnuEdit_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Add_PW,
            this.mnuEdit_Add_SS,
            this.mnuEdit_Add_TL});
            this.mnuEdit_Add.Name = "mnuEdit_Add";
            this.mnuEdit_Add.Size = new System.Drawing.Size(112, 22);
            this.mnuEdit_Add.Text = "Add";
            // 
            // mnuEdit_Add_PW
            // 
            this.mnuEdit_Add_PW.Name = "mnuEdit_Add_PW";
            this.mnuEdit_Add_PW.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Add_PW.Text = "Production Worker";
            this.mnuEdit_Add_PW.Click += new System.EventHandler(this.mnuEdit_Add_PW_Click);
            // 
            // mnuEdit_Add_SS
            // 
            this.mnuEdit_Add_SS.Name = "mnuEdit_Add_SS";
            this.mnuEdit_Add_SS.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Add_SS.Text = "Shift Supervisor";
            this.mnuEdit_Add_SS.Click += new System.EventHandler(this.mnuEdit_Add_SS_Click);
            // 
            // mnuEdit_Add_TL
            // 
            this.mnuEdit_Add_TL.Name = "mnuEdit_Add_TL";
            this.mnuEdit_Add_TL.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Add_TL.Text = "Team Leader";
            this.mnuEdit_Add_TL.Click += new System.EventHandler(this.mnuEdit_Add_TL_Click);
            // 
            // mnuUpdate_Add
            // 
            this.mnuUpdate_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Update_PW,
            this.mnuEdit_Update_SS,
            this.mnuEdit_Update_TL});
            this.mnuUpdate_Add.Name = "mnuUpdate_Add";
            this.mnuUpdate_Add.Size = new System.Drawing.Size(112, 22);
            this.mnuUpdate_Add.Text = "Update";
            // 
            // mnuEdit_Update_PW
            // 
            this.mnuEdit_Update_PW.Name = "mnuEdit_Update_PW";
            this.mnuEdit_Update_PW.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Update_PW.Text = "Production Worker";
            this.mnuEdit_Update_PW.Click += new System.EventHandler(this.mnuEdit_Update_PW_Click);
            // 
            // mnuEdit_Update_SS
            // 
            this.mnuEdit_Update_SS.Name = "mnuEdit_Update_SS";
            this.mnuEdit_Update_SS.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Update_SS.Text = "Shift Supervisor";
            this.mnuEdit_Update_SS.Click += new System.EventHandler(this.mnuEdit_Update_SS_Click);
            // 
            // mnuEdit_Update_TL
            // 
            this.mnuEdit_Update_TL.Name = "mnuEdit_Update_TL";
            this.mnuEdit_Update_TL.Size = new System.Drawing.Size(174, 22);
            this.mnuEdit_Update_TL.Text = "Team Leader";
            this.mnuEdit_Update_TL.Click += new System.EventHandler(this.mnuEdit_Update_TL_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuView_PW,
            this.mnuView_SS,
            this.mnuView_TL});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            // 
            // mnuView_PW
            // 
            this.mnuView_PW.Name = "mnuView_PW";
            this.mnuView_PW.Size = new System.Drawing.Size(174, 22);
            this.mnuView_PW.Text = "Production Worker";
            this.mnuView_PW.Click += new System.EventHandler(this.mnuView_PW_Click);
            // 
            // mnuView_SS
            // 
            this.mnuView_SS.Name = "mnuView_SS";
            this.mnuView_SS.Size = new System.Drawing.Size(174, 22);
            this.mnuView_SS.Text = "Shift Supervisor";
            this.mnuView_SS.Click += new System.EventHandler(this.mnuView_SS_Click);
            // 
            // mnuView_TL
            // 
            this.mnuView_TL.Name = "mnuView_TL";
            this.mnuView_TL.Size = new System.Drawing.Size(174, 22);
            this.mnuView_TL.Text = "Team Leader";
            this.mnuView_TL.Click += new System.EventHandler(this.mnuView_TL_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(107, 22);
            this.mnuHelp_About.Text = "About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(32, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "EMPLOYEE INFORMATION SYSTEM\r\nDARBY ELECTRONICS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 272);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Main Menu Employee Info";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_PrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_PrintPreview_PW;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_PrintPreview_SS;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_PrintPreview_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Print;
        private System.Windows.Forms.ToolStripMenuItem mnuFIle_Print_PW;
        private System.Windows.Forms.ToolStripMenuItem mnuFIle_Print_SS;
        private System.Windows.Forms.ToolStripMenuItem mnuFIle_Print_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Add_PW;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Add_SS;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Add_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Update_PW;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Update_SS;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit_Update_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuView_PW;
        private System.Windows.Forms.ToolStripMenuItem mnuView_SS;
        private System.Windows.Forms.ToolStripMenuItem mnuView_TL;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.Label lblTitle;
    }
}

