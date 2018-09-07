using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    class Print_File
    {
        string[] tokens;
        public static List<string[]> _lstProduWor = new List<string[]>();
        //stores the list of lines coming from file
        public static List<string[]> _lstShiftSup = new List<string[]>();
        //stores the list of lines coming from file
        public static List<string[]> _lstTeamLead = new List<string[]>();
        
        public void FileIn()
        {
            //this try catch is complete to read file and place information in list of structures
            try
            {
                
                StreamReader inputFile;     //to read the file
                string strLine;                //to hold the line from the file
                int intCountRecords = 0;       //individual records counter
                //create a delimiter array
                char[] delim = { ',' };
                //open the CSV file
                inputFile = File.OpenText(@"...\...\TextFiles\Employee.csv");
                //place data from file into _vbTeam
                while (!inputFile.EndOfStream)
                {
                    //Increment the individual records count
                    intCountRecords++;
                    //Read a line from the file
                    strLine = inputFile.ReadLine();
                    //get the information as tokens
                    tokens = strLine.Split(delim);
                    //put the tokens in the appropriate List of the Information structure
                    if(tokens[0] == "Production Worker")
                    {
                        _lstProduWor.Add(tokens);
                    }
                    else if(tokens[0] == "Shift Supervisor")
                    {
                        _lstShiftSup.Add(tokens);
                    }
                    else if (tokens[0] == "Team Leader")
                    {
                        _lstTeamLead.Add(tokens);
                    }
                }
                //closes inputFile
                inputFile.Close();
            }
            catch (Exception ex)
            {
                //displays an error message
                MessageBox.Show(ex.Message);
            }
        }

        public void FileOut()
        {
            //writing data back to existing file.
            try
            {
                //count the number of time going thru while loop with list
                int pwcount = 0;
                int sscount = 0;
                int tlcount = 0;
                //create a delimiter
                string delim = ",";
                // using StringBuilder to build the data to go to the file
                //creates an intance of StringBuilder
                StringBuilder outputStr = new StringBuilder();
                //creates an information line about what data is in the .csv file
                outputStr.AppendLine("typeWorker,empNumb,shiftNumb,hrlyPayRt,annualSalary,annualProdBonus,monthlyBonus,ReqTrainHrs,AttndTrainhrs");
                //while used to get all data in from the List
                while (_lstProduWor.Count != pwcount)
                {
                    //sets the string up to append to the file.  unable to do file write because it would 
                    //not erase previous information and replace with new data.
                    outputStr.AppendLine(_lstProduWor[pwcount][0] 
                        + delim + _lstProduWor[pwcount][1] 
                        + delim + _lstProduWor[pwcount][2]
                        + delim + _lstProduWor[pwcount][3] 
                        + delim + _lstProduWor[pwcount][4] 
                        + delim + _lstProduWor[pwcount][5]
                        + delim + _lstProduWor[pwcount][6] 
                        + delim + _lstProduWor[pwcount][7] 
                        + delim + _lstProduWor[pwcount][8]
                        + delim + _lstProduWor[pwcount][9]);
                    pwcount++;
                }
                while (_lstShiftSup.Count != sscount)
                {
                    //sets the string up to append to the file.  unable to do file write because it would 
                    //not erase previous information and replace with new data.
                    outputStr.AppendLine(_lstShiftSup[sscount][0]
                        + delim + _lstShiftSup[sscount][1]
                        + delim + _lstShiftSup[sscount][2]
                        + delim + _lstShiftSup[sscount][3]
                        + delim + _lstShiftSup[sscount][4]
                        + delim + _lstShiftSup[sscount][5]
                        + delim + _lstShiftSup[sscount][6]
                        + delim + _lstShiftSup[sscount][7]
                        + delim + _lstShiftSup[sscount][8]
                        + delim + _lstShiftSup[sscount][9]);
                    sscount++;
                }
                while (_lstTeamLead.Count != tlcount)
                {
                    //sets the string up to append to the file.  unable to do file write because it would 
                    //not erase previous information and replace with new data.
                    outputStr.AppendLine(_lstTeamLead[tlcount][0]
                        + delim + _lstTeamLead[tlcount][1]
                        + delim + _lstTeamLead[tlcount][2]
                        + delim + _lstTeamLead[tlcount][3]
                        + delim + _lstTeamLead[tlcount][4]
                        + delim + _lstTeamLead[tlcount][5]
                        + delim + _lstTeamLead[tlcount][6]
                        + delim + _lstTeamLead[tlcount][7]
                        + delim + _lstTeamLead[tlcount][8]
                        + delim + _lstTeamLead[tlcount][9]);
                    tlcount++;
                }
                //creates the path for the file to be saved to
                string filePath = (@"...\...\TextFiles\Employee.csv");
                //This will actually write a new file with the text and closes it, then if 
                //the file already exist will overwrite the existing file. 
                File.WriteAllText(filePath, outputStr.ToString());
            }
            catch (Exception ex)
            {
                //displays an error message
                MessageBox.Show(ex.Message);
            }
            //closes the application
            Application.Exit();
        }

        //keeps up with the itemsPerPage-needed outside print event so won't reset to zero
        int intItemsPerPage = 0;
        //keeps up with the index of the list-needed outside the print event so won't reset to zero        
        int intCount1 = 0;
        public void Doc_PrintPagePW(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            strLine = "PRODUCTION WORKERS";
            e.Graphics.DrawString(strLine, printFontBig, Brushes.DarkOrange, 240, yPrnLocation);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            //Draw a horizontal diving line
            e.Graphics.DrawLine(blackPen, 60, 60, 760, 60);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            int intPgNm = 0;                //keeps up with page number
            //prints lines of data
            while (intCount1 < _lstProduWor.Count)
            {
                //if-else statement will help to determine if need multiple pages
                if (intItemsPerPage < 8)
                {
                    //assign the label and the data from the structure coming from the list
                    strLine = "NAME:\t\t\t" + _lstProduWor[intCount1][1];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontBold, Brushes.DarkOrange, 120, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Employee Number:\t" + _lstProduWor[intCount1][2];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Shift Number:\t\t" + _lstProduWor[intCount1][3];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Hourly Rate:\t\t" + _lstProduWor[intCount1][4];
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

        public void Doc_PrintPageSS(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            strLine = "SHIFT SUPERVISOR";
            e.Graphics.DrawString(strLine, printFontBig, Brushes.DarkOrange, 240, yPrnLocation);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            //Draw a horizontal diving line
            e.Graphics.DrawLine(blackPen, 60, 60, 760, 60);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            int intPgNm = 0;                //keeps up with page number
            //prints lines of data
            while (intCount1 < _lstShiftSup.Count)
            {
                //if-else statement will help to determine if need multiple pages
                if (intItemsPerPage < 8)
                {
                    //assign the label and the data from the structure coming from the list
                    strLine = "NAME:\t\t\t" + _lstShiftSup[intCount1][1];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontBold, Brushes.DarkOrange, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Employee Number:\t\t" + _lstShiftSup[intCount1][2];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Annual Salary:\t\t\t" + _lstShiftSup[intCount1][5];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Annual Production Bonus:\t" + _lstShiftSup[intCount1][6];
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

        public void Doc_PrintPageTL(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
            strLine = "TEAM LEADERS";
            e.Graphics.DrawString(strLine, printFontBig, Brushes.DarkOrange, 240, yPrnLocation);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            //Draw a horizontal diving line
            e.Graphics.DrawLine(blackPen, 60, 60, 760, 60);
            //adjust vertical position
            yPrnLocation += lineHeight * 2;
            int intPgNm = 0;                //keeps up with page number
            //prints lines of data
            while (intCount1 < _lstTeamLead.Count)
            {
                //if-else statement will help to determine if need multiple pages
                if (intItemsPerPage < 8)
                {
                    //assign the label and the data from the structure coming from the list
                    strLine = "NAME:\t\t\t\t" + _lstTeamLead[intCount1][1];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontBold, Brushes.DarkOrange, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Employee Number:\t\t" + _lstTeamLead[intCount1][2];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Monthly Bonus:\t\t\t" + _lstTeamLead[intCount1][3];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Hourly Rate:\t\t\t" + _lstTeamLead[intCount1][4];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Montly Bonus:\t\t\t" + _lstTeamLead[intCount1][7];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Required Training Hours:\t" + _lstTeamLead[intCount1][8];
                    //prints the string int the page
                    e.Graphics.DrawString(strLine, printFontNorm, Brushes.Gray, 240, yPrnLocation);
                    //add lineheight to cursor location
                    yPrnLocation += lineHeight;
                    //assign the label and the data from the structure coming from the list
                    strLine = "Attended Training Hours:\t" + _lstTeamLead[intCount1][9];
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
    }
}
