using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    public partial class frmMain : Form
    {
        Employee emp = new Employee();
        public frmMain()
        {
            InitializeComponent();
        }

        private void ResetTo0()
        {//this function rersets all list counters to 0
            emp.PWcounter = 0;
            emp.SSCounter = 0;
            emp.TLCounter = 0;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Print_File p = new Print_File();
            p.FileOut();
            //closes application
            Application.Exit();
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {//shows the about form and hides the main form
            frmAbout abo = new frmAbout();
            this.Hide();
            abo.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {//calls the file in dunction
            Print_File p = new Print_File();
            p.FileIn();
        }

        private void mnuView_PW_Click(object sender, EventArgs e)
        {//Calls the production worker form VIEW
            frmProductionWorker pw = new frmProductionWorker();
            this.Hide();
            pw.Text = "View Production Worker";
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            //calls the display function to populate the textbox in the form
            pw.Display(emp.PWcounter);
            pw.btnOk.Hide();
            pw.grpPW.Enabled = false;
            pw.Show();
        }

        private void mnuView_SS_Click(object sender, EventArgs e)
        {//call the shift super form VIEW and disables the textboxes and ok button
            frmShiftSupervisor ss = new frmShiftSupervisor();
            this.Hide();
            ss.Text = "View Shift Supervisor";
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            //calls the display function to populate the textbox in the form
            ss.Display(emp.SSCounter);
            ss.btnOk.Hide();
            ss.grpPW.Enabled = false;
            ss.Show();
        }

        private void mnuView_TL_Click(object sender, EventArgs e)
        {//call the TEAM LEADER form VIEW and disables the textboxes and ok button
            frmTeamLeader tl = new frmTeamLeader();
            this.Hide();
            tl.Text = "View Team Leader";
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            //calls the display function to populate the textbox in the form
            tl.Display(emp.TLCounter);
            tl.btnOk.Hide();
            tl.grpPW.Enabled = false;
            tl.Show();
        }

        private void mnuEdit_Add_PW_Click(object sender, EventArgs e)
        {//call the PRODUCTION WORKER form ADD and hides and changes labels to beeter suit the form
            frmProductionWorker pw = new frmProductionWorker();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            pw.txtEmpID.Enabled = false;
            int empID = int.Parse(Print_File._lstProduWor[Print_File._lstProduWor.Count-1][2]) + 2;
            pw.txtEmpID.Text = empID.ToString();
            pw.btnPrevious.Hide();
            pw.btnNext.Hide();
            pw.Text = "Add Production Worker";
            pw.btnOk.Text = "Add";
            pw.Show();
        }

        private void mnuEdit_Update_PW_Click(object sender, EventArgs e)
        {//call the PRODUCTION WORKER form UPDATE and hides and changes labels to beeter suit the form
            frmProductionWorker pw = new frmProductionWorker();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            pw.txtEmpID.Enabled = false;
            pw.Text = "Update Production Worker";
            pw.btnOk.Text = "Update";
            //calls the display function to populate the textbox in the form
            pw.Display(emp.PWcounter);
            pw.Show();
        }

        private void mnuEdit_Add_TL_Click(object sender, EventArgs e)
        {//call the TEAM LEADER form ADD and hides and changes labels to beeter suit the form
            frmTeamLeader frmTL = new frmTeamLeader();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            frmTL.txtEmpID.Enabled = false;
            int empID = int.Parse(Print_File._lstTeamLead[Print_File._lstTeamLead.Count - 1][2]) + 2;
            frmTL.txtEmpID.Text = empID.ToString();
            frmTL.btnPrevious.Hide();
            frmTL.btnNext.Hide();
            frmTL.Text = "Add Team Leader";
            frmTL.btnOk.Text = "Add";
            frmTL.Show();
        }

        private void mnuEdit_Update_TL_Click(object sender, EventArgs e)
        {//call the TEAM LEADERR form UPDATE and hides and changes labels to beeter suit the form
            frmTeamLeader frmTL = new frmTeamLeader();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            frmTL.txtEmpID.Enabled = false;
            frmTL.Text = "Update Team Leader";
            frmTL.btnOk.Text = "Update";
            //calls the display function to populate the textbox in the form
            frmTL.Display(emp.TLCounter);
            frmTL.Show();
        }

        private void mnuEdit_Add_SS_Click(object sender, EventArgs e)
        {//call the SHIFT SUPERVISOR form ADD and hides and changes labels to better suit the form
            frmShiftSupervisor ss = new frmShiftSupervisor();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            ss.txtEmpID.Enabled = false;
            int empID = int.Parse(Print_File._lstShiftSup[Print_File._lstShiftSup.Count - 1][2]) + 2;
            ss.txtEmpID.Text = empID.ToString();
            ss.btnPrevious.Hide();
            ss.btnPrevious.Hide();
            ss.btnNext.Hide();
            ss.Text = "Add Shift Supervisor";
            ss.btnOk.Text = "Add";
            ss.Show();
        }

        private void mnuEdit_Update_SS_Click(object sender, EventArgs e)
        {//call the SHIFT SUPERVI form UPDATE and hides and changes labels to beeter suit the form
            frmShiftSupervisor ss = new frmShiftSupervisor();
            //reset all the counters to 0 because I was havbing problems with next and previous button
            ResetTo0();
            this.Hide();
            ss.txtEmpID.Enabled = false;
            ss.Text = "Update Shift Supervisor";
            ss.btnOk.Text = "Update";
            //calls the display function to populate the textbox in the form
            ss.Display(emp.SSCounter);
            ss.Show();
        }

        //IGNORE THIS I MISSCLICKED A MENU
        private void mnuFile_PrintPreview_Click(object sender, EventArgs e)
        {

        }



        //DO NOT IGNORE THIS 
        //creates an instance of the print class
        Print_File pf = new Print_File();

        private void mnuFile_PrintPreview_PW_Click(object sender, EventArgs e)
        {//calls the print preview for the production worker
            PrintDocument docPreview = new System.Drawing.Printing.PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            docPreview.PrintPage += new PrintPageEventHandler(pf.Doc_PrintPagePW);
            previewDialog.Document = docPreview;
            previewDialog.ShowDialog();
        }

        private void mnuFile_PrintPreview_SS_Click(object sender, EventArgs e)
        {//calls the print preview for the shift supervisor
            PrintDocument docPreview = new System.Drawing.Printing.PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            docPreview.PrintPage += new PrintPageEventHandler(pf.Doc_PrintPageSS);
            previewDialog.Document = docPreview;
            previewDialog.ShowDialog();
        }

        private void mnuFile_PrintPreview_TL_Click(object sender, EventArgs e)
        {//calls the print preview for the team leader
            PrintDocument docPreview = new System.Drawing.Printing.PrintDocument();
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            docPreview.PrintPage += new PrintPageEventHandler(pf.Doc_PrintPageTL);
            previewDialog.Document = docPreview;
            previewDialog.ShowDialog();
        }

        private void mnuFIle_Print_PW_Click(object sender, EventArgs e)
        {
            //prints the document
            PrintDocument docPrint = new System.Drawing.Printing.PrintDocument();
            //add the parges
            docPrint.PrintPage += pf.Doc_PrintPagePW;
            //prints
            docPrint.Print();
        }

        private void mnuFIle_Print_SS_Click(object sender, EventArgs e)
        {
            //prints the document
            PrintDocument docPrint = new System.Drawing.Printing.PrintDocument();
            //add the parges
            docPrint.PrintPage += pf.Doc_PrintPageSS;
            //prints
            docPrint.Print();
        }

        private void mnuFIle_Print_TL_Click(object sender, EventArgs e)
        {
            //prints the document
            PrintDocument docPrint = new System.Drawing.Printing.PrintDocument();
            //add the parges
            docPrint.PrintPage += pf.Doc_PrintPageTL;
            //prints
            docPrint.Print();
        }
    }
}
