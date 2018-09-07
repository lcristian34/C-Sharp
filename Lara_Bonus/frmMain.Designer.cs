namespace Lara_Bonus
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.MaskedTextBox();
            this.txtEmer_Cont_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txtGuardian2_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txtGuardian1_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txtStuPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtZIpCode = new System.Windows.Forms.MaskedTextBox();
            this.txtClass = new System.Windows.Forms.MaskedTextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblEmer_Cont_Phone = new System.Windows.Forms.Label();
            this.txtEmergency_Contact = new System.Windows.Forms.TextBox();
            this.lblEmergency_Contact = new System.Windows.Forms.Label();
            this.lblGuardian2_Phone = new System.Windows.Forms.Label();
            this.txtGuardian2 = new System.Windows.Forms.TextBox();
            this.lblGuardian2 = new System.Windows.Forms.Label();
            this.lblGuardian1_Phone = new System.Windows.Forms.Label();
            this.txtGuardian1 = new System.Windows.Forms.TextBox();
            this.lblGuardian1 = new System.Windows.Forms.Label();
            this.lblClassification = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblZIpCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblMName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.cbxClassification = new System.Windows.Forms.ComboBox();
            this.lblClassCodes = new System.Windows.Forms.Label();
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp_Instructions = new System.Windows.Forms.ToolStripMenuItem();
            this.errProviderTxt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.mnsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(72, 324);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(324, 156);
            this.dgvStudents.TabIndex = 9;
            this.dgvStudents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvStudents_MouseClick);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtState);
            this.grpInfo.Controls.Add(this.txtEmer_Cont_Phone);
            this.grpInfo.Controls.Add(this.txtGuardian2_Phone);
            this.grpInfo.Controls.Add(this.txtGuardian1_Phone);
            this.grpInfo.Controls.Add(this.txtStuPhone);
            this.grpInfo.Controls.Add(this.txtZIpCode);
            this.grpInfo.Controls.Add(this.txtClass);
            this.grpInfo.Controls.Add(this.txtStudentID);
            this.grpInfo.Controls.Add(this.lblEmer_Cont_Phone);
            this.grpInfo.Controls.Add(this.txtEmergency_Contact);
            this.grpInfo.Controls.Add(this.lblEmergency_Contact);
            this.grpInfo.Controls.Add(this.lblGuardian2_Phone);
            this.grpInfo.Controls.Add(this.txtGuardian2);
            this.grpInfo.Controls.Add(this.lblGuardian2);
            this.grpInfo.Controls.Add(this.lblGuardian1_Phone);
            this.grpInfo.Controls.Add(this.txtGuardian1);
            this.grpInfo.Controls.Add(this.lblGuardian1);
            this.grpInfo.Controls.Add(this.lblClassification);
            this.grpInfo.Controls.Add(this.lblStuPhone);
            this.grpInfo.Controls.Add(this.lblZIpCode);
            this.grpInfo.Controls.Add(this.lblState);
            this.grpInfo.Controls.Add(this.txtCity);
            this.grpInfo.Controls.Add(this.lblCity);
            this.grpInfo.Controls.Add(this.txtStreetAddress);
            this.grpInfo.Controls.Add(this.lblStreetAddress);
            this.grpInfo.Controls.Add(this.txtLName);
            this.grpInfo.Controls.Add(this.lblLName);
            this.grpInfo.Controls.Add(this.txtMName);
            this.grpInfo.Controls.Add(this.lblMName);
            this.grpInfo.Controls.Add(this.btnOk);
            this.grpInfo.Controls.Add(this.txtFName);
            this.grpInfo.Controls.Add(this.lblFName);
            this.grpInfo.Controls.Add(this.lblStudentID);
            this.grpInfo.Location = new System.Drawing.Point(13, 58);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(432, 262);
            this.grpInfo.TabIndex = 8;
            this.grpInfo.TabStop = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(76, 96);
            this.txtState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtState.Mask = ">LL";
            this.txtState.Name = "txtState";
            this.txtState.PromptChar = ' ';
            this.txtState.Size = new System.Drawing.Size(30, 20);
            this.txtState.TabIndex = 7;
            // 
            // txtEmer_Cont_Phone
            // 
            this.txtEmer_Cont_Phone.Location = new System.Drawing.Point(319, 191);
            this.txtEmer_Cont_Phone.Mask = "999-000-0000";
            this.txtEmer_Cont_Phone.Name = "txtEmer_Cont_Phone";
            this.txtEmer_Cont_Phone.PromptChar = ' ';
            this.txtEmer_Cont_Phone.Size = new System.Drawing.Size(100, 20);
            this.txtEmer_Cont_Phone.TabIndex = 15;
            this.txtEmer_Cont_Phone.Tag = "phone";
            // 
            // txtGuardian2_Phone
            // 
            this.txtGuardian2_Phone.Location = new System.Drawing.Point(319, 166);
            this.txtGuardian2_Phone.Mask = "999-000-0000";
            this.txtGuardian2_Phone.Name = "txtGuardian2_Phone";
            this.txtGuardian2_Phone.PromptChar = ' ';
            this.txtGuardian2_Phone.Size = new System.Drawing.Size(100, 20);
            this.txtGuardian2_Phone.TabIndex = 13;
            this.txtGuardian2_Phone.Tag = "phone";
            // 
            // txtGuardian1_Phone
            // 
            this.txtGuardian1_Phone.Location = new System.Drawing.Point(319, 143);
            this.txtGuardian1_Phone.Mask = "999-000-0000";
            this.txtGuardian1_Phone.Name = "txtGuardian1_Phone";
            this.txtGuardian1_Phone.PromptChar = ' ';
            this.txtGuardian1_Phone.Size = new System.Drawing.Size(100, 20);
            this.txtGuardian1_Phone.TabIndex = 11;
            this.txtGuardian1_Phone.Tag = "phone";
            // 
            // txtStuPhone
            // 
            this.txtStuPhone.Location = new System.Drawing.Point(319, 95);
            this.txtStuPhone.Mask = "999-000-0000";
            this.txtStuPhone.Name = "txtStuPhone";
            this.txtStuPhone.PromptChar = ' ';
            this.txtStuPhone.Size = new System.Drawing.Size(100, 20);
            this.txtStuPhone.TabIndex = 9;
            this.txtStuPhone.Tag = "phone";
            // 
            // txtZIpCode
            // 
            this.txtZIpCode.Location = new System.Drawing.Point(172, 95);
            this.txtZIpCode.Mask = "00000";
            this.txtZIpCode.Name = "txtZIpCode";
            this.txtZIpCode.PromptChar = ' ';
            this.txtZIpCode.Size = new System.Drawing.Size(57, 20);
            this.txtZIpCode.TabIndex = 8;
            this.txtZIpCode.ValidatingType = typeof(int);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(202, 17);
            this.txtClass.Mask = "000";
            this.txtClass.Name = "txtClass";
            this.txtClass.PromptChar = ' ';
            this.txtClass.Size = new System.Drawing.Size(27, 20);
            this.txtClass.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(77, 17);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(31, 20);
            this.txtStudentID.TabIndex = 0;
            // 
            // lblEmer_Cont_Phone
            // 
            this.lblEmer_Cont_Phone.AutoSize = true;
            this.lblEmer_Cont_Phone.Location = new System.Drawing.Point(222, 194);
            this.lblEmer_Cont_Phone.Name = "lblEmer_Cont_Phone";
            this.lblEmer_Cont_Phone.Size = new System.Drawing.Size(93, 13);
            this.lblEmer_Cont_Phone.TabIndex = 41;
            this.lblEmer_Cont_Phone.Text = "Emer Cont Phone:";
            // 
            // txtEmergency_Contact
            // 
            this.txtEmergency_Contact.Location = new System.Drawing.Point(110, 191);
            this.txtEmergency_Contact.Name = "txtEmergency_Contact";
            this.txtEmergency_Contact.Size = new System.Drawing.Size(100, 20);
            this.txtEmergency_Contact.TabIndex = 14;
            // 
            // lblEmergency_Contact
            // 
            this.lblEmergency_Contact.AutoSize = true;
            this.lblEmergency_Contact.Location = new System.Drawing.Point(1, 194);
            this.lblEmergency_Contact.Name = "lblEmergency_Contact";
            this.lblEmergency_Contact.Size = new System.Drawing.Size(103, 13);
            this.lblEmergency_Contact.TabIndex = 39;
            this.lblEmergency_Contact.Text = "Emergency Contact:";
            // 
            // lblGuardian2_Phone
            // 
            this.lblGuardian2_Phone.AutoSize = true;
            this.lblGuardian2_Phone.Location = new System.Drawing.Point(222, 170);
            this.lblGuardian2_Phone.Name = "lblGuardian2_Phone";
            this.lblGuardian2_Phone.Size = new System.Drawing.Size(93, 13);
            this.lblGuardian2_Phone.TabIndex = 37;
            this.lblGuardian2_Phone.Text = "Guardian2 Phone:";
            // 
            // txtGuardian2
            // 
            this.txtGuardian2.Location = new System.Drawing.Point(110, 166);
            this.txtGuardian2.Name = "txtGuardian2";
            this.txtGuardian2.Size = new System.Drawing.Size(100, 20);
            this.txtGuardian2.TabIndex = 12;
            // 
            // lblGuardian2
            // 
            this.lblGuardian2.AutoSize = true;
            this.lblGuardian2.Location = new System.Drawing.Point(45, 170);
            this.lblGuardian2.Name = "lblGuardian2";
            this.lblGuardian2.Size = new System.Drawing.Size(59, 13);
            this.lblGuardian2.TabIndex = 35;
            this.lblGuardian2.Text = "Guardian2:";
            // 
            // lblGuardian1_Phone
            // 
            this.lblGuardian1_Phone.AutoSize = true;
            this.lblGuardian1_Phone.Location = new System.Drawing.Point(222, 146);
            this.lblGuardian1_Phone.Name = "lblGuardian1_Phone";
            this.lblGuardian1_Phone.Size = new System.Drawing.Size(93, 13);
            this.lblGuardian1_Phone.TabIndex = 33;
            this.lblGuardian1_Phone.Text = "Guardian1 Phone:";
            // 
            // txtGuardian1
            // 
            this.txtGuardian1.Location = new System.Drawing.Point(110, 142);
            this.txtGuardian1.Name = "txtGuardian1";
            this.txtGuardian1.Size = new System.Drawing.Size(100, 20);
            this.txtGuardian1.TabIndex = 10;
            // 
            // lblGuardian1
            // 
            this.lblGuardian1.AutoSize = true;
            this.lblGuardian1.Location = new System.Drawing.Point(45, 145);
            this.lblGuardian1.Name = "lblGuardian1";
            this.lblGuardian1.Size = new System.Drawing.Size(59, 13);
            this.lblGuardian1.TabIndex = 31;
            this.lblGuardian1.Text = "Guardian1:";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Location = new System.Drawing.Point(127, 20);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(71, 13);
            this.lblClassification.TabIndex = 29;
            this.lblClassification.Text = "Classification:";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(239, 98);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(81, 13);
            this.lblStuPhone.TabIndex = 27;
            this.lblStuPhone.Text = "Student Phone:";
            // 
            // lblZIpCode
            // 
            this.lblZIpCode.AutoSize = true;
            this.lblZIpCode.Location = new System.Drawing.Point(123, 98);
            this.lblZIpCode.Name = "lblZIpCode";
            this.lblZIpCode.Size = new System.Drawing.Size(50, 13);
            this.lblZIpCode.TabIndex = 25;
            this.lblZIpCode.Text = "ZipCode:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(38, 98);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 23;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(319, 69);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 6;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(288, 72);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 21;
            this.lblCity.Text = "City:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(93, 69);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(172, 20);
            this.txtStreetAddress.TabIndex = 5;
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(8, 74);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAddress.TabIndex = 19;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(319, 43);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 4;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(254, 47);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 17;
            this.lblLName.Text = "Last Name:";
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(93, 45);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(100, 20);
            this.txtMName.TabIndex = 3;
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(14, 47);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(73, 13);
            this.lblMName.TabIndex = 15;
            this.lblMName.Text = "MIddle Name:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(344, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(301, 17);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(118, 20);
            this.txtFName.TabIndex = 2;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(239, 20);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(10, 20);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID:";
            // 
            // cbxClassification
            // 
            this.cbxClassification.FormattingEnabled = true;
            this.cbxClassification.Location = new System.Drawing.Point(149, 31);
            this.cbxClassification.Name = "cbxClassification";
            this.cbxClassification.Size = new System.Drawing.Size(121, 21);
            this.cbxClassification.TabIndex = 0;
            this.cbxClassification.Text = "All";
            this.cbxClassification.SelectedIndexChanged += new System.EventHandler(this.cbxClassification_SelectedIndexChanged);
            // 
            // lblClassCodes
            // 
            this.lblClassCodes.AutoSize = true;
            this.lblClassCodes.Location = new System.Drawing.Point(18, 34);
            this.lblClassCodes.Name = "lblClassCodes";
            this.lblClassCodes.Size = new System.Drawing.Size(117, 13);
            this.lblClassCodes.TabIndex = 6;
            this.lblClassCodes.Text = "Available Classification:";
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
            this.mnsMainMenu.Size = new System.Drawing.Size(457, 24);
            this.mnsMainMenu.TabIndex = 0;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_ClearAll,
            this.mnuFile_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_ClearAll
            // 
            this.mnuFile_ClearAll.Name = "mnuFile_ClearAll";
            this.mnuFile_ClearAll.Size = new System.Drawing.Size(118, 22);
            this.mnuFile_ClearAll.Text = "Clear All";
            this.mnuFile_ClearAll.Click += new System.EventHandler(this.mnuFile_ClearAll_Click);
            // 
            // mnuFile_Exit
            // 
            this.mnuFile_Exit.Name = "mnuFile_Exit";
            this.mnuFile_Exit.Size = new System.Drawing.Size(118, 22);
            this.mnuFile_Exit.Text = "Exit";
            this.mnuFile_Exit.Click += new System.EventHandler(this.mnuFile_Exit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit_Add,
            this.mnuEdit_Update,
            this.mnuEdit_Delete});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuEdit_Add
            // 
            this.mnuEdit_Add.Name = "mnuEdit_Add";
            this.mnuEdit_Add.Size = new System.Drawing.Size(142, 22);
            this.mnuEdit_Add.Text = "Add Book";
            this.mnuEdit_Add.Click += new System.EventHandler(this.mnuEdit_Add_Click);
            // 
            // mnuEdit_Update
            // 
            this.mnuEdit_Update.Name = "mnuEdit_Update";
            this.mnuEdit_Update.Size = new System.Drawing.Size(142, 22);
            this.mnuEdit_Update.Text = "Update Book";
            this.mnuEdit_Update.Click += new System.EventHandler(this.mnuEdit_Update_Click);
            // 
            // mnuEdit_Delete
            // 
            this.mnuEdit_Delete.Name = "mnuEdit_Delete";
            this.mnuEdit_Delete.Size = new System.Drawing.Size(142, 22);
            this.mnuEdit_Delete.Text = "Delete Book";
            this.mnuEdit_Delete.Click += new System.EventHandler(this.mnuEdit_Delete_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp_About,
            this.mnuHelp_Instructions});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelp_About
            // 
            this.mnuHelp_About.Name = "mnuHelp_About";
            this.mnuHelp_About.Size = new System.Drawing.Size(136, 22);
            this.mnuHelp_About.Text = "About";
            this.mnuHelp_About.Click += new System.EventHandler(this.mnuHelp_About_Click);
            // 
            // mnuHelp_Instructions
            // 
            this.mnuHelp_Instructions.Name = "mnuHelp_Instructions";
            this.mnuHelp_Instructions.Size = new System.Drawing.Size(136, 22);
            this.mnuHelp_Instructions.Text = "Instructions";
            this.mnuHelp_Instructions.Click += new System.EventHandler(this.mnuHelp_Instructions_Click);
            // 
            // errProviderTxt
            // 
            this.errProviderTxt.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 492);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.cbxClassification);
            this.Controls.Add(this.lblClassCodes);
            this.Controls.Add(this.mnsMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Students Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvStudents;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblClassCodes;
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_About;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblEmer_Cont_Phone;
        public System.Windows.Forms.TextBox txtEmergency_Contact;
        private System.Windows.Forms.Label lblEmergency_Contact;
        private System.Windows.Forms.Label lblGuardian2_Phone;
        public System.Windows.Forms.TextBox txtGuardian2;
        private System.Windows.Forms.Label lblGuardian2;
        private System.Windows.Forms.Label lblGuardian1_Phone;
        public System.Windows.Forms.TextBox txtGuardian1;
        private System.Windows.Forms.Label lblGuardian1;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblZIpCode;
        private System.Windows.Forms.Label lblState;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label lblStreetAddress;
        public System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        public System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp_Instructions;
        public System.Windows.Forms.ToolStripMenuItem mnuEdit_Add;
        public System.Windows.Forms.ToolStripMenuItem mnuEdit_Update;
        public System.Windows.Forms.ToolStripMenuItem mnuEdit_Delete;
        public System.Windows.Forms.GroupBox grpInfo;
        public System.Windows.Forms.ComboBox cbxClassification;
        public System.Windows.Forms.ToolStripMenuItem mnuFile_ClearAll;
        public System.Windows.Forms.TextBox txtStudentID;
        public System.Windows.Forms.MaskedTextBox txtZIpCode;
        public System.Windows.Forms.MaskedTextBox txtClass;
        public System.Windows.Forms.ErrorProvider errProviderTxt;
        public System.Windows.Forms.MaskedTextBox txtEmer_Cont_Phone;
        public System.Windows.Forms.MaskedTextBox txtGuardian2_Phone;
        public System.Windows.Forms.MaskedTextBox txtGuardian1_Phone;
        public System.Windows.Forms.MaskedTextBox txtStuPhone;
        public System.Windows.Forms.MaskedTextBox txtState;
    }
}

