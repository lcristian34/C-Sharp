using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Bonus
{
    //Programmed by Christian Lara on 6/26/2017
    //C# Database Dev With Ado.Net (ITSE-2338-1031)
    //This program collects basic information from students such as the phone number email 
    //names and addresses, the program then stores the information ina local database. 
    //The records can be edited, added and deleted.
    //Bonus
    public partial class frmMain : Form
    {
        DataClass d = new DataClass();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {//runs creates the dataset and view mode
            DataClass.GetClassifications("Select DISTINCT Classification FROM Student", this);
            //adds a all subcodes menu to the combo box
            cbxClassification.Items.Add("All");
            //addds all the other sub codes to the combo box from the subs dataset
            for (int i = 0; i < DataClass.ds_Students.Tables[DataClass.dt_Class].Rows.Count; i++)
            {
                cbxClassification.Items.Add(DataClass.ds_Students.Tables[DataClass.dt_Class].Rows[i][0]);
            }
            //resets the dataset to have all fields
            DataClass.CreateStudDataSet("SELECT * FROM Student", this);
            d.ViewMode(this);
        }

        private void cbxClassification_SelectedIndexChanged(object sender, EventArgs e)
        {//if the combo box selected item is changed this runs

            if (cbxClassification.SelectedIndex == 0)
            {//if the index is 0 that means the first option, this query i runned and displayed on the data grid view
                DataClass.CreateStudDataSet("SELECT * FROM Student", this);
            }
            else
            {//else the data grid view will only show those record with the selected sub code
                DataClass.CreateStudDataSet("SELECT * FROM Student WHERE Classification = "
                + cbxClassification.SelectedItem.ToString(), this);
            }
        }

        private void mnuFile_ClearAll_Click(object sender, EventArgs e)
        {//clears all textboxes and refocus on the combo box
            d.TextBoxes(grpInfo, "Clear");
            cbxClassification.Focus();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {//application exit
            Application.Exit();
        }

        private void mnuEdit_Add_Click(object sender, EventArgs e)
        {//enables textboxes and clears them to add new data and the button to add
            btnOk.Text = "Add";
            btnOk.Enabled = true;
            btnOk.Show();
            d.TextBoxes(grpInfo, "Enabled");
            d.TextBoxes(grpInfo, "Clear");
            //the textboe=xesfunction enables all textboxes so we have to disabled the student id again
            txtStudentID.Enabled = false;
            int temp = (int)DataClass.ds_Students.Tables[DataClass.dt_Students].Rows[dgvStudents.RowCount - 1][0] + 1;
            txtStudentID.Text = temp.ToString();
        }

        private void mnuEdit_Update_Click(object sender, EventArgs e)
        {//enables text boxes to edit and the button to update them
            btnOk.Text = "Update";
            btnOk.Enabled = true;
            btnOk.Show();
            d.TextBoxes(grpInfo, "Enabled");
            //the textboe=xesfunction enables all textboxes so we have to disabled the student id again
            txtStudentID.Enabled = false;
        }

        private void mnuEdit_Delete_Click(object sender, EventArgs e)
        {//delets the current record collected and the button to delete
            btnOk.Text = "Delete";
            btnOk.Enabled = true;
            btnOk.Show();
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {//opens the help form and titles it About
            frmHelp h = new frmHelp();
            h.Text = "About";
            h.ShowDialog();
        }

        private void mnuHelp_Instructions_Click(object sender, EventArgs e)
        {//opens the help form and and titles is instructions
            frmHelp h = new frmHelp();
            h.Text = "Instructions";
            h.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {//adds, delets or updates the currentr selected row
            
            if (btnOk.Text == "Delete")
            {//if the button text is delete. we delete the current row with the current selected student id
                DataClass.CreateStudDataSet("DELETE FROM Student WHERE Student_ID = " + txtStudentID.Text, this);
            }
            if (d.EmptyTxt(this, grpInfo) == 0)
            {//if invalud function is false this runs
                if (btnOk.Text == "Update")
                {//if the button text is update. we update the current row with the current selected student id
                    DataClass.CreateStudDataSet("UPDATE Student SET First_Name = '" + txtFName.Text
                        + "',Middle_Name = '" + txtMName.Text + "',Last_Name = '" + txtLName.Text + "',Street_Address = '" + txtStreetAddress.Text + "',City = '" + txtCity.Text
                        + "',State = '" + txtState.Text + "',Zipcode = " + txtZIpCode.Text + ",Stu_Phone = '" + txtStuPhone.Text + "',Classification = " + txtClass.Text
                        + ",Guardian1 = '" + txtGuardian1.Text + "',Guardian1_Phone = '" + txtGuardian1_Phone.Text + "',Guardian2 = '" + txtGuardian2.Text
                        + "',Guardian2_Phone = '" + txtGuardian2_Phone.Text + "',Emergency_Contact = '" + txtEmergency_Contact.Text 
                        + "',Emer_Cont_Phone = '" + txtEmer_Cont_Phone.Text + "' WHERE Student_ID = " + txtStudentID.Text + ";", this);
                }
                else if (btnOk.Text == "Add")
                {//if the button is add . the program adds the values in the textboxes to the dataset
                    DataClass.CreateStudDataSet("INSERT INTO Student Values(" + txtStudentID.Text + ",'" + txtFName.Text + "','"
                        + txtMName.Text + "','" + txtLName.Text + "','" + txtStreetAddress.Text + "','" + txtCity.Text 
                        + "','" + txtState.Text + "'," + txtZIpCode.Text + ",'" + txtStuPhone.Text + "'," + txtClass.Text 
                        + ",'" + txtGuardian1.Text + "','" + txtGuardian1_Phone.Text + "','" + txtGuardian2.Text 
                        + "','" + txtGuardian2_Phone.Text + "','" + txtEmergency_Contact.Text + "','" + txtEmer_Cont_Phone.Text + "');", this);
                }
                //this updates the current tables
                DataClass.CreateStudDataSet("SELECT * FROM Student", this);
                //clears textboxes
                d.TextBoxes(grpInfo, "Clear");
                //switches to view mode
                d.ViewMode(this);
                //changes focus to combo box
                cbxClassification.Focus();
            }
        }

        private void dgvStudents_MouseClick(object sender, MouseEventArgs e)
        {//displays the selected item info from the data grid view to the textboxes
            d.ViewMode(this);
            d.DisplayTo_txt(this);
            //eneables the edit button s and clear all
            mnuEdit_Delete.Enabled = true;
            mnuEdit_Update.Enabled = true;
            mnuFile_ClearAll.Enabled = true;
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {//makes sure the application closes correctly
            Application.Exit();
        }
        
    }//END OF CLASS
}// END OF NAMESPACE
