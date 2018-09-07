using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    public partial class frmShiftSupervisor : Lara_Lab_10.frmProductionWorker
    {
        ShiftSupervisor ss = new ShiftSupervisor();
        public frmShiftSupervisor()
        {
            InitializeComponent();
        }

        private void frmShiftSupervisor_Load(object sender, EventArgs e)
        {//load shift supervisor
            //hides the textboxes and label not used 
            lblPayRate.Hide();
            lblShift.Hide();
            txtPayRate.Hide();
            txtShift.Hide();
            //disable or enables the next and previous buttons depending on the counters
            if (ss.SSCounter == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }
            if (ss.SSCounter == Print_File._lstShiftSup.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        public override void Display(int listIndex)
        {
            //calls the set dat function to set data to the variables 
            ss.setData();
            //the variables are used to fill the textboxes
            txtEmpID.Text = ss._EmpID;
            txtName.Text = ss._Name;
            txtAnnualSalary.Text = ss._AnnualSalary;
            txtAnnualProduBonus.Text = ss._AnnualProductionBonus;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //lesses the current people count
            ss.SSCounter--;
            //check if the current number is one
            if (ss.SSCounter == 1)
            {
                //disables previouys
                btnPrevious.Enabled = false;
            }
            else if (ss.SSCounter != Print_File._lstShiftSup.Count)
            {//renables next button
                btnNext.Enabled = true;
            }
            //dislpays current person
            Display(ss.SSCounter);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //adds one to current person index
            ss.SSCounter++;
            //checks if the person on the list have runed out
            if (ss.SSCounter == Print_File._lstShiftSup.Count - 1)
            {//disables the next button 
                btnNext.Enabled = false;
            }
            //reenables the previus button
            else if (ss.SSCounter != 0)
            {
                btnPrevious.Enabled = true;
            }
            //displays current person
            Display(ss.SSCounter);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {// changes the ok button to add or update
            //sets a string array = to the current values on the textboxes 
            string[] str = { "Shift Supervisor", txtName.Text, txtEmpID.Text, " ", " ",
                txtAnnualSalary.Text, txtAnnualProduBonus.Text, " ", " ", " " };
            if (btnOk.Text == "Add" && this.Text == "Add Shift Supervisor")
            {//if ok is add and form is shift worker
                if (txtName.Text == "" || txtPayRate.Text == "" || txtShift.Text == "" || txtAnnualSalary.Text == "" || txtAnnualProduBonus.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes");
                }
                else
                {
                    //adds the string to the string to the list
                    Print_File._lstShiftSup.Add(str);
                    //tells user about action then clears textboxes
                    MessageBox.Show(txtName.Text + " has been added to the list");
                    txtName.Text = "";
                    txtEmpID.Text = "";
                    txtAnnualSalary.Text = "";
                    txtAnnualProduBonus.Text = "";
                }
            }
            else if (btnOk.Text == "Update" && this.Text == "Update Shift Supervisor")
            {//remplaces the old string with the current one then tells user about it
                Print_File._lstShiftSup.RemoveAt(ss.SSCounter);
                Print_File._lstShiftSup.Insert(ss.SSCounter, str);
                MessageBox.Show(txtName.Text + " has been Updated");
            }
        }
    }
}
