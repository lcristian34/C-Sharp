namespace Lara_Lab_10
{
    partial class frmTeamLeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamLeader));
            this.lblMonBonus = new System.Windows.Forms.Label();
            this.lblRequTrainHrs = new System.Windows.Forms.Label();
            this.lblAttndTrainhrs = new System.Windows.Forms.Label();
            this.txtMonBonus = new System.Windows.Forms.TextBox();
            this.txtRequTrainHrs = new System.Windows.Forms.TextBox();
            this.txtAttndTrainhrs = new System.Windows.Forms.TextBox();
            this.grpPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPW
            // 
            this.grpPW.Controls.Add(this.txtAttndTrainhrs);
            this.grpPW.Controls.Add(this.txtRequTrainHrs);
            this.grpPW.Controls.Add(this.txtMonBonus);
            this.grpPW.Controls.Add(this.lblAttndTrainhrs);
            this.grpPW.Controls.Add(this.lblRequTrainHrs);
            this.grpPW.Controls.Add(this.lblMonBonus);
            this.grpPW.Size = new System.Drawing.Size(273, 249);
            this.grpPW.Controls.SetChildIndex(this.lblPayRate, 0);
            this.grpPW.Controls.SetChildIndex(this.lblShift, 0);
            this.grpPW.Controls.SetChildIndex(this.txtPayRate, 0);
            this.grpPW.Controls.SetChildIndex(this.txtShift, 0);
            this.grpPW.Controls.SetChildIndex(this.txtEmpID, 0);
            this.grpPW.Controls.SetChildIndex(this.txtName, 0);
            this.grpPW.Controls.SetChildIndex(this.lblMonBonus, 0);
            this.grpPW.Controls.SetChildIndex(this.lblRequTrainHrs, 0);
            this.grpPW.Controls.SetChildIndex(this.lblAttndTrainhrs, 0);
            this.grpPW.Controls.SetChildIndex(this.txtMonBonus, 0);
            this.grpPW.Controls.SetChildIndex(this.txtRequTrainHrs, 0);
            this.grpPW.Controls.SetChildIndex(this.txtAttndTrainhrs, 0);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(23, 303);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(123, 303);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(220, 303);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(220, 267);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMonBonus
            // 
            this.lblMonBonus.AutoSize = true;
            this.lblMonBonus.Location = new System.Drawing.Point(11, 151);
            this.lblMonBonus.Name = "lblMonBonus";
            this.lblMonBonus.Size = new System.Drawing.Size(74, 13);
            this.lblMonBonus.TabIndex = 9;
            this.lblMonBonus.Text = "Montly Bonus:";
            // 
            // lblRequTrainHrs
            // 
            this.lblRequTrainHrs.AutoSize = true;
            this.lblRequTrainHrs.Location = new System.Drawing.Point(11, 183);
            this.lblRequTrainHrs.Name = "lblRequTrainHrs";
            this.lblRequTrainHrs.Size = new System.Drawing.Size(125, 13);
            this.lblRequTrainHrs.TabIndex = 10;
            this.lblRequTrainHrs.Text = "Required Training Hours:";
            // 
            // lblAttndTrainhrs
            // 
            this.lblAttndTrainhrs.AutoSize = true;
            this.lblAttndTrainhrs.Location = new System.Drawing.Point(11, 212);
            this.lblAttndTrainhrs.Name = "lblAttndTrainhrs";
            this.lblAttndTrainhrs.Size = new System.Drawing.Size(125, 13);
            this.lblAttndTrainhrs.TabIndex = 11;
            this.lblAttndTrainhrs.Text = "Attended Training Hours:";
            // 
            // txtMonBonus
            // 
            this.txtMonBonus.Location = new System.Drawing.Point(145, 144);
            this.txtMonBonus.Name = "txtMonBonus";
            this.txtMonBonus.Size = new System.Drawing.Size(100, 20);
            this.txtMonBonus.TabIndex = 12;
            // 
            // txtRequTrainHrs
            // 
            this.txtRequTrainHrs.Location = new System.Drawing.Point(145, 176);
            this.txtRequTrainHrs.Name = "txtRequTrainHrs";
            this.txtRequTrainHrs.Size = new System.Drawing.Size(100, 20);
            this.txtRequTrainHrs.TabIndex = 13;
            // 
            // txtAttndTrainhrs
            // 
            this.txtAttndTrainhrs.Location = new System.Drawing.Point(145, 205);
            this.txtAttndTrainhrs.Name = "txtAttndTrainhrs";
            this.txtAttndTrainhrs.Size = new System.Drawing.Size(100, 20);
            this.txtAttndTrainhrs.TabIndex = 14;
            // 
            // frmTeamLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(297, 339);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeamLeader";
            this.Text = "Team Leader";
            this.Load += new System.EventHandler(this.frmTeamLeader_Load);
            this.grpPW.ResumeLayout(false);
            this.grpPW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAttndTrainhrs;
        private System.Windows.Forms.TextBox txtRequTrainHrs;
        private System.Windows.Forms.TextBox txtMonBonus;
        private System.Windows.Forms.Label lblAttndTrainhrs;
        private System.Windows.Forms.Label lblRequTrainHrs;
        private System.Windows.Forms.Label lblMonBonus;
    }
}
