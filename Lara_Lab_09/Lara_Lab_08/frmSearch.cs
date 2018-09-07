using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_08
{
    public partial class frmSearch : Form
    {
        //creates instance of data class
        Data dat = new Data();
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {//closes this form then shows the main form
            //closes the crurrent form
            this.Close();
            //shows the from
            Application.OpenForms[0].Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //keeps the count of the records read
            int intCount = 0;
            //holds the input
            string strInput = txtlblEnterSearch.Text;
            //loops until end of tthe end of the list has been reached
            while (Data._lstPer.Count != intCount)
            {
                //calls the list with the index
                dat._setListToStru(intCount);
                //if the text of form is for first name this runs
                if(this.Text == "Search by First Name")
                {
                    //changes the labes to acomodate for curret form title
                    lblEnterSearch.Text = "Enter First Name";
                    //if the input is equal to a last name on the list 
                    if (strInput == dat._struPerson.fName)
                    {
                        //the record number first name and last name are dialpayed
                        lstRecordNum.Items.Add(intCount+1);
                        lstFName.Items.Add(dat._struPerson.fName);
                        lstLName.Items.Add(dat._struPerson.lName);
                    }
                }

                //if the text of form is for last name this runs
                if (this.Text == "Search by Lara Name")
                {
                    //changes the labes to acomodate for curret form title
                    lblEnterSearch.Text = "Enter Last Name";
                    //if the input is equal to a last name on the list 
                    if (strInput == dat._struPerson.lName)
                    {//the record number first name and last name are dialpayed
                        lstRecordNum.Items.Add(intCount + 1);
                        lstFName.Items.Add(dat._struPerson.fName);
                        lstLName.Items.Add(dat._struPerson.lName);
                    }
                }
                //increments the count
                intCount++;
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
