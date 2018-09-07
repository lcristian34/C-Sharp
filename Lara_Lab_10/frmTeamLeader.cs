using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    public partial class frmTeamLeader : Lara_Lab_10.frmProductionWorker
    {
        TeamLeader tl = new TeamLeader();
        public frmTeamLeader()
        {
            InitializeComponent();
        }

        private void frmTeamLeader_Load(object sender, EventArgs e)
        {// disable or enables the next and previous buttons depending on the counters
            if (tl.TLCounter == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }
            if (tl.TLCounter == Print_File._lstTeamLead.Count - 1)
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
            tl.setData();
            //the variables are used to fill the textboxes
            txtEmpID.Text = tl._EmpID;
            txtName.Text = tl._Name;
            txtPayRate.Text = tl._Payrate;
            txtShift.Text = tl._shift;
            txtMonBonus.Text = tl._MontlyBonus;
            txtRequTrainHrs.Text = tl._RecTrainingHrs;
            txtAttndTrainhrs.Text = tl._AttTrainingHrs;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //check if the current number is one
            if (tl.TLCounter == 1)
            {
                //disables previouys
                btnPrevious.Enabled = false;
            }
            else if (tl.TLCounter != Print_File._lstTeamLead.Count)
            {//renables next button
                btnNext.Enabled = true;
            }
            //lesses the current people count
            tl.TLCounter--;
            //dislpays current person
            Display(tl.TLCounter);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //adds one to current person index
            tl.TLCounter++;
            //checks if the person on the list have runed out
            if (tl.TLCounter == Print_File._lstTeamLead.Count - 1)
            {//disables the next button 
                btnNext.Enabled = false;
            }
            //reenables the previus button
            else if (tl.TLCounter != 0)
            {
                btnPrevious.Enabled = true;
            }
            //displays current person
            Display(tl.TLCounter);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {// changes the ok button to add or update
            //sets a string array = to the current values on the textboxes 
            string[] str = { "Team Leader", txtName.Text, txtEmpID.Text, txtShift.Text, txtPayRate.Text
                    , " ", " ", txtMonBonus.Text, txtRequTrainHrs.Text, txtAttndTrainhrs.Text };
            if (btnOk.Text == "Add" && this.Text == "Add Team Leader")
            {//if ok is add and form is team leader
                if (txtName.Text == "" || txtPayRate.Text == "" || txtShift.Text == "" || txtMonBonus.Text == "" || txtRequTrainHrs.Text == "" || txtAttndTrainhrs.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes");
                }
                else
                {

                    //adds the string to the string to the list
                    Print_File._lstTeamLead.Add(str);
                    //tells user about action then clears textboxes
                    MessageBox.Show(txtName.Text + " has been added to the list");
                    txtName.Text = "";
                    txtEmpID.Text = "";
                    txtPayRate.Text = "";
                    txtShift.Text = "";
                    txtMonBonus.Text = "";
                    txtRequTrainHrs.Text = "";
                    txtAttndTrainhrs.Text = "";
                }
            }
            else if (btnOk.Text == "Update" && this.Text == "Update Team Leader")
            {//remplaces the old string with the current one then tells user about it
                Print_File._lstTeamLead.RemoveAt(tl.TLCounter);
                Print_File._lstTeamLead.Insert(tl.TLCounter, str);
                MessageBox.Show(txtName.Text + " has been Updated");
            }
        }
    }
}
