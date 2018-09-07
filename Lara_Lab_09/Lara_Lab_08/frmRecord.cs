using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_08
{
   
    public partial class frmRecord : Form
    {
        //creates an instance of the data class
        Data dat = new Data();
        public frmRecord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the crurrent form
            this.Close();
            //shows the from
            Application.OpenForms[0].Show();
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {//loads the view form

         //calls the set list to structure function from data class
            dat._setListToStru(Data._recCurrent);
            //check if the current number is one
            if (Data._recCurrent == 0)
            {
                //disables previouys
                btnPrevious.Enabled = false;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {//moves the person been displayen on textbox to the next
            if (btnNext.Text == "Next")
            {
                //adds one to current person index
                Data._recCurrent++;
                //checks if the person on the list have runed out
                if (Data._recCurrent == Data._lstPer.Count - 1)
                {//disables the next button 
                    btnNext.Enabled = false;
                }
                //reenables the previus button
                else if (Data._recCurrent != 0)
                {
                    btnPrevious.Enabled = true;
                }
                //updates the count label
                lblRecordCounter.Text = Data._recCurrent + 1 + " of " + Data._lstPer.Count;
                //calls the set ist to structure function
                dat._setListToStru(Data._recCurrent);
                //displays current person
                display();
            }
            else if (btnNext.Text == "Add")
            {//if the btn text is add, ths runs..
                //holds the string to be added to the list
                string strNewPer;
                //assigns all the values in the form to the string variable with the commas
                strNewPer = txtFirstName.Text + "," + txtLastName.Text + "," 
                    + txtStreet.Text + "," + txtCity.Text + "," + txtState.Text
                    + "," + txtZip.Text + "," + txtPhone.Text + "," + txtEmail.Text;
                //calls the set person list function to pass the string to the end of the list
                dat._setPersonL(strNewPer);
                //lest user know the form has been added
                MessageBox.Show("A new person has been added");
                //clears all textboxes
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtStreet.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtState.Text = string.Empty;
                txtZip.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                //adds one to count
                Data.newPerNum += 1;
                //sets the count label
                lblRecordCounter.Text = Data.newPerNum + " of " + Data.newPerNum;

            }
        }

        public void display()
        {//displays the current person to the textboxes
            txtFirstName.Text = dat._struPerson.fName;
            txtLastName.Text = dat._struPerson.lName;
            txtStreet.Text = dat._struPerson.street;
            txtCity.Text = dat._struPerson.city;
            txtState.Text = dat._struPerson.state;
            txtZip.Text = dat._struPerson.zip;
            txtPhone.Text = dat._struPerson.phone;
            txtEmail.Text = dat._struPerson.email;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {//moves the person been displayen on textbox to the previous
            //check if the current number is one
            if (Data._recCurrent == 1)
            {
                //disables previouys
                btnPrevious.Enabled = false;
            }
            else if (Data._recCurrent != Data._lstPer.Count)
            {//renables next button
                btnNext.Enabled = true;
            }
            //lesses the current people count
            Data._recCurrent--;
            //updates count label
            lblRecordCounter.Text = Data._recCurrent + 1 + " of " + Data._lstPer.Count;
            //sets the list to structure function
            dat._setListToStru(Data._recCurrent);
            //dislpays current person
            display();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.Text == "Update")
            {//updates a record
                //removes the current list selected
                dat._removeAt_listPer(Data._recCurrent);
                //informs the user about the removal
                MessageBox.Show("The Info on the " + Data._recCurrent + 1 + " Person has been Updated");
                //gets all the textboxes with the commas into one string
                string strNewPer;
                strNewPer = txtFirstName.Text + "," + txtLastName.Text + ","
                    + txtStreet.Text + "," + txtCity.Text + "," + txtState.Text
                    + "," + txtZip.Text + "," + txtPhone.Text + "," + txtEmail.Text;
                //adds the new data to the current record
                dat._insertAt_listPer(Data._recCurrent, strNewPer);
                //change cancel text to close
                btnClose.Text = "Close";
            }
            else if (this.Text == "Delete")
            {
                //change cancel text to close
                btnClose.Text = "Close";
                dat._removeAt_listPer(Data._recCurrent);
                MessageBox.Show("The Info on the Person has been Deleted");
                
            }
        }
    }
}
