using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_08
{
    public partial class frmMain : Form
    {
        //creates instance of data class
        Data dat = new Data();
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this event will open the teams file and display it on the listbox 
            try
            {
                
                StreamReader inputFile;
                string str;
                //clears list to avoid repited items 
                Data._lstPer.Clear();
                //opens file
                inputFile = File.OpenText("...\\...\\TextFiles\\AddressBook.csv");
                //reads file to end
                while (!inputFile.EndOfStream)
                {
                    //assigns a readline to str
                    str = inputFile.ReadLine();
                    //adds str to listbox
                    dat._setPersonL(str);
                }

            }
            //shows meesagebox in case that the file is not found
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                //count the number of time going thru while loop with list
                int intCount = 0;
                // using StringBuilder to build the data to go to the file
                //creates an intance of StringBuilder
                StringBuilder outputStr = new StringBuilder();
                //while used to get all data in from the List
                while (Data._lstPer.Count != intCount)
                {
                    //sets the string up to append to the file.  unable to do file write because it would 
                    //not erase previous information and replace with new data.
                    outputStr.AppendLine(Data._lstPer[intCount]);
                    intCount++;
                }
                //creates the path for the file to be saved to
                string filePath = ("...\\...\\TextFiles\\AddressBook.csv");
                //This will actually write a new file with the text and closes it, then if 
                //the file already exist will overwrite the existing file. 
                File.WriteAllText(filePath, outputStr.ToString());
            }
            catch (Exception ex)
            {
                //displays an error message
                MessageBox.Show(ex.Message);
            }
            //closes applivation
            Application.Exit();
        }

        /* Create a print preview */
        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            PrintDocument docPreview = new System.Drawing.Printing.PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            docPreview.PrintPage += new PrintPageEventHandler(Doc_PrintPage);
            previewDialog.Document = docPreview;
            previewDialog.ShowDialog();
        }
        //keeps up with the itemsPerPage-needed outside print event so won't reset to zero
        int intItemsPerPage = 0;
        //keeps up with the index of the list-needed outside the print event so won't reset to zero        
        int intCount1 = 0;                    
        private void Doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 6);
            //Font definitions
            Font printFontNorm = new Font("Lucida Sans", 14);
            Font printFontBig = new Font("Lithograph", 30, FontStyle.Italic);
            Font printFontBold = new Font("Lithograph", 16, FontStyle.Bold);
            //line height defintion
            float lineHeight = printFontNorm.GetHeight();
            //page margin defintion
            float xPrnLocation = e.MarginBounds.Left;
            float yPrnLocation = e.PageSettings.HardMarginY;
            float xPgNmLocation = e.MarginBounds.Bottom;
            float yPgNmLocation = e.PageSettings.HardMarginY;
            yPrnLocation += 4;

            //page text
            string strLine = null;
            //Print the title
            strLine = "ADDRESS BOOK";
            e.Graphics.DrawString(strLine, printFontBig, Brushes.DarkOrange, 240, yPrnLocation);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            //Draw a horizontal diving line
            e.Graphics.DrawLine(blackPen, 60, 60, 760, 60);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            int intPgNm = 0;                //keeps up with page number
            //prints lines of data
            while (intCount1 < dat._getPersonL().Count)
            {
                dat._setListToStru(intCount1);
                //if-else statement will help to determine if need multiple pages
                if (intItemsPerPage < 8)
                {
                    //assign the label and the data from the structure coming from the list
                    strLine = "NAME:\t\t\t" + dat._struPerson.fName + " " + dat._struPerson.lName;
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontBold, Brushes.DarkOrange, 180, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Address:\t" + dat._struPerson.street + dat._struPerson.city + " "
                        + dat._struPerson.state + " " + dat._struPerson.zip;
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Phone:\t\t" + dat._struPerson.phone;
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "E-mail:\t\t" + dat._struPerson.email;
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    lineHeight = printFontNorm.GetHeight();
                    //adjust vertical position
                    yPrnLocation += lineHeight * 2;
                    intCount1++;            //increments intCount that keeps ups with index of list
                    intItemsPerPage++;      //increments intIntemsPerPage
                    e.HasMorePages = false; //sets HasMorePages to false so it will not print any other pages
                }
                else
                {
                    //resets intItemsPerPage to zero
                    intItemsPerPage = 0;
                    //sets HasMorePages to false so it will print any other pages
                    e.HasMorePages = true;
                    //It will call the PrintPage event again 
                    return;     
                }
                //increases page number
                intPgNm += 1;
                //determines the location of the page number
                xPgNmLocation = 350;
                yPgNmLocation = e.MarginBounds.Bottom;
                //sets up the string for page number
                strLine = "Page Number:   " + intPgNm.ToString();
                //places page number on the printout.
                e.Graphics.DrawString(strLine, printFontNorm, Brushes.LightGray, xPgNmLocation, yPgNmLocation);
            }
        }


        private void mnuPrint_Click(object sender, EventArgs e)
        {
            //prints the document
            PrintDocument docPrint = new System.Drawing.Printing.PrintDocument();
            //add the parges
            docPrint.PrintPage += Doc_PrintPage;
            //prints
            docPrint.Print();
        }

        private void frmMain_Closing(object sender, FormClosingEventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void mnuView_Click(object sender, EventArgs e)
        {
            frmRecord rec = new frmRecord();
            //hides current form
            this.Hide();
            //displays the record form
            rec.Show();
            //disables textboxes
            rec.txtFirstName.Enabled = false;
            rec.txtLastName.Enabled = false;
            rec.txtStreet.Enabled = false;
            rec.txtCity.Enabled = false;
            rec.txtState.Enabled = false;
            rec.txtZip.Enabled = false;
            rec.txtPhone.Enabled = false;
            rec.txtEmail.Enabled = false;
            //disables the previous button
            rec.btnPrevious.Enabled = false;
            //hides ok button
            rec.btnOK.Hide();
            
            //calls display the data from the person to textboxes
            rec.display();
            //updates the label that countd the current person
            rec.lblRecordCounter.Text = Data._recCurrent + 1 + " of " + Data._lstPer.Count;
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            frmRecord rec = new frmRecord();
            //sets the title of the form
            rec.Text = "Add Data";
            //sets the number of the new person
            Data.newPerNum = Data._lstPer.Count + 1;
            //hides current form
            this.Hide();
            //displays the record form
            rec.Show();
            //hides previous button
            rec.btnPrevious.Hide();
            //hides ok button
            rec.btnOK.Hide();
            //changes the close button to Add
            rec.btnNext.Text = "Add";
            //sets the count label
            rec.lblRecordCounter.Text = Data.newPerNum + " of " + Data.newPerNum;
        }

        private void mnuUpdate_Click(object sender, EventArgs e)
        {
            frmRecord rec = new frmRecord();
            //sets form title
            rec.Text = "Update";
            //hides current form
            this.Hide();
            //displays the record form
            rec.Show();
            //change thje name of close button
            rec.btnOK.Text = "Update";
            //change close text to cancel
            rec.btnClose.Text = "Cancel";
            //updates the label that countd the current person
            rec.lblRecordCounter.Text = Data._recCurrent + 1 + " of " + Data._lstPer.Count;
            //calls display the data from the person to textboxes
            rec.display();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            frmRecord rec = new frmRecord();
            //sets form title
            rec.Text = "Delete";
            //hides current form
            this.Hide();
            //displays the record form
            rec.Show();
            //change thje name of close button
            rec.btnOK.Text = "Delete";
            //change close text to cancel
            rec.btnClose.Text = "Cancel";
            //updates the label that countd the current person
            rec.lblRecordCounter.Text = Data._recCurrent + 1 + " of " + Data._lstPer.Count;
            //calls display the data from the person to textboxes
            rec.display();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {//opens about help form and hides the main form
            frmHelp hel = new frmHelp();
            this.Hide();
            hel.Show();
        }

        private void mnuSearchFName_Click(object sender, EventArgs e)
        {//opens the serach form and hides the main form
            frmSearch ser = new frmSearch();
            this.Hide();
            ser.Show();
            //changes the title of the form
            ser.Text = "Search by First Name";
        }

        private void mnuSearchLName_Click(object sender, EventArgs e)
        {//opens the serach form and hides the main form
            frmSearch ser = new frmSearch();
            this.Hide();
            ser.Show();
            //changes title of the form
            ser.Text = "Search by Last Name";
        }
    }
}
