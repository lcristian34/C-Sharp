namespace Lara_Lab_10
{
    partial class frmShiftSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftSupervisor));
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lblAnnualProduBonus = new System.Windows.Forms.Label();
            this.txtAnnualSalary = new System.Windows.Forms.TextBox();
            this.txtAnnualProduBonus = new System.Windows.Forms.TextBox();
            this.grpPW.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPW
            // 
            this.grpPW.Controls.Add(this.txtAnnualProduBonus);
            this.grpPW.Controls.Add(this.txtAnnualSalary);
            this.grpPW.Controls.Add(this.lblAnnualProduBonus);
            this.grpPW.Controls.Add(this.lblAnnualSalary);
            this.grpPW.Size = new System.Drawing.Size(273, 227);
            this.grpPW.Controls.SetChildIndex(this.lblPayRate, 0);
            this.grpPW.Controls.SetChildIndex(this.lblShift, 0);
            this.grpPW.Controls.SetChildIndex(this.txtPayRate, 0);
            this.grpPW.Controls.SetChildIndex(this.txtShift, 0);
            this.grpPW.Controls.SetChildIndex(this.txtEmpID, 0);
            this.grpPW.Controls.SetChildIndex(this.txtName, 0);
            this.grpPW.Controls.SetChildIndex(this.lblAnnualSalary, 0);
            this.grpPW.Controls.SetChildIndex(this.lblAnnualProduBonus, 0);
            this.grpPW.Controls.SetChildIndex(this.txtAnnualSalary, 0);
            this.grpPW.Controls.SetChildIndex(this.txtAnnualProduBonus, 0);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(21, 281);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(121, 281);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 281);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(218, 245);
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(14, 151);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(75, 13);
            this.lblAnnualSalary.TabIndex = 9;
            this.lblAnnualSalary.Text = "Annual Salary:";
            // 
            // lblAnnualProduBonus
            // 
            this.lblAnnualProduBonus.AutoSize = true;
            this.lblAnnualProduBonus.Location = new System.Drawing.Point(14, 187);
            this.lblAnnualProduBonus.Name = "lblAnnualProduBonus";
            this.lblAnnualProduBonus.Size = new System.Drawing.Size(130, 13);
            this.lblAnnualProduBonus.TabIndex = 10;
            this.lblAnnualProduBonus.Text = "Annual Production Bonus:";
            // 
            // txtAnnualSalary
            // 
            this.txtAnnualSalary.Location = new System.Drawing.Point(145, 148);
            this.txtAnnualSalary.Name = "txtAnnualSalary";
            this.txtAnnualSalary.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualSalary.TabIndex = 11;
            // 
            // txtAnnualProduBonus
            // 
            this.txtAnnualProduBonus.Location = new System.Drawing.Point(145, 184);
            this.txtAnnualProduBonus.Name = "txtAnnualProduBonus";
            this.txtAnnualProduBonus.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualProduBonus.TabIndex = 12;
            // 
            // frmShiftSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(297, 312);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShiftSupervisor";
            this.Text = "Shift Supervisor";
            this.Load += new System.EventHandler(this.frmShiftSupervisor_Load);
            this.grpPW.ResumeLayout(false);
            this.grpPW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnnualProduBonus;
        private System.Windows.Forms.TextBox txtAnnualSalary;
        private System.Windows.Forms.Label lblAnnualProduBonus;
        private System.Windows.Forms.Label lblAnnualSalary;
    }
}
