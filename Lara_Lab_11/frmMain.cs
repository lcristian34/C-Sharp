using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_11
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void TextBoxes(string Action)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                    {
                        if (Action == "Clear")
                        {
                            (control as TextBox).Clear();
                        }
                        else if(Action == "Hide")
                        {
                            (control as TextBox).Hide();
                        }
                        else if(Action == "Enabled")
                        {
                            (control as TextBox).Enabled = true;
                        }
                        else if(Action == "Disabled")
                        {
                            (control as TextBox).Enabled = false;
                        }
                    }
                else if(control is MaskedTextBox)
                    {
                        if (Action == "Clear")
                        {
                            (control as MaskedTextBox).Clear();
                        }
                        else if (Action == "Hide")
                        {
                            (control as MaskedTextBox).Hide();
                        }
                        else if (Action == "Enabled")
                        {
                            (control as MaskedTextBox).Enabled = true;
                        }
                        else if (Action == "Disabled")
                        {
                            (control as MaskedTextBox).Enabled = false;
                        }
                    }
                    else
                    {
                        func(control.Controls);
                    }
                
            };

            func(Controls);
        }
        
        // Create the connection, data adapter, data set, AND load DataGrid. 
        private void LoadDataGrid(string str)
        {
            DbBooksClass.CreateBooksDataSet(str);
            //Bind the dgvMembers data rrid view to the dataset / data table
            dgvBooks.DataSource = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT];
            //Clear any selected row in data grid view
            dgvBooks.ClearSelection();
            FormatDataGrid();
        }
        
        //// Format the data grid to allow easy viewing of column data.
        public void FormatDataGrid()
        {
            // Assign Overall DataGrid Properties changed from DEFAULT values.
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.Cursor = Cursors.Hand;
            dgvBooks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AllowUserToAddRows = false;
            // Assign width, text, visibility, etc to DataGrid column(s)
            dgvBooks.Columns["Title"].Visible = true;
            dgvBooks.Columns["Title"].Width = 180;
            dgvBooks.Columns["Title"].HeaderText = "Title";
            dgvBooks.Columns["Author"].Visible = true;
            dgvBooks.Columns["Author"].Width = 120;
            dgvBooks.Columns["Author"].HeaderText = "Author Name";
            dgvBooks.Columns["ISBN"].Visible = false;
            dgvBooks.Columns["CopyDate"].Visible = false;
            dgvBooks.Columns["Publisher"].Visible = false;
            dgvBooks.Columns["Pages"].Visible = false;
            dgvBooks.Columns["SubCode"].Visible = false;
            dgvBooks.ScrollBars = ScrollBars.Vertical;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'books_2010DataSet.Books' table. 
            //You can move, or remove it, as needed.
            ViewMode();
            //database bruh
            LoadDataGrid("SELECT * FROM Books");
            DbBooksClass.CreateSubsDataSet();
            //adds a all subcodes menu to the combo box
            cbxSubjectCodes.Items.Add("All Sub Codes");
            //addds all the other sub codes to the combo box from the subs dataset
            for (int i = 0; i < DbBooksClass.ds_Subs.Tables[DbBooksClass.dt_Subs].Rows.Count; i++)
            {
                cbxSubjectCodes.Items.Add(DbBooksClass.ds_Subs.Tables[DbBooksClass.dt_Subs].Rows[i][0]);
            }
        }

        private void mnuFile_ClearAll_Click(object sender, EventArgs e)
        {//clears all textboxes and resets focus
            TextBoxes("Clear");
            cbxSubjectCodes.SelectedIndex = -1;
            cbxSubjectCodes.Focus();
        }

        private void mnuFile_Exit_Click(object sender, EventArgs e)
        {//closes application
            Application.Exit();
        }

        private void mnuEdit_AddBook_Click(object sender, EventArgs e)
        {//enables textboxes and clears them to add new data
            btnOk.Text = "Add";
            btnOk.Enabled = true;
            btnOk.Show();
            TextBoxes("Enabled");
            TextBoxes("Clear");

        }

        private void mnuEdit_UpdateBook_Click(object sender, EventArgs e)
        {//enables text boxes to edit
            btnOk.Text = "Update";
            btnOk.Enabled = true;
            btnOk.Show();
            TextBoxes("Enabled");
        }

        private void mnuEdit_DeleteBook_Click(object sender, EventArgs e)
        {//delets the current record collected
            btnOk.Text = "Delete";
            btnOk.Enabled = true;
            btnOk.Show();
        }

        private void mnuHelp_About_Click(object sender, EventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }

        private void frmMain_FormClosing(Object sender, FormClosingEventArgs e)
        {//handles the exit on the form
            Application.Exit();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//displays the selected item info from the data grid view to the textboxes
            DisplayTo_txt();
            //eneables the edit button s and clear all
            mnuEdit_DeleteBook.Enabled = true;
            mnuEdit_UpdateBook.Enabled = true;
            mnuFile_ClearAll.Enabled = true;
        }

        private void cbxSubjectCodes_SelectedIndexChanged(object sender, EventArgs e)
        {//if the combo box selected item is changed this runs
            
            if (cbxSubjectCodes.SelectedIndex == 0)
            {//if the index is 0 that means the first option, this query i runned and displayed on the data grid view
                LoadDataGrid("SELECT * FROM Books");
            }
            else
            {//else the data grid view will only show those record with the selected sub code
                LoadDataGrid("SELECT * FROM Books WHERE SubCode = '"
                + cbxSubjectCodes.SelectedItem.ToString() + "'");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Invalid() == false)
            {
                if (btnOk.Text == "Delete")
                {
                    LoadDataGrid("DELETE FROM Books WHERE ISBN = '" + txtISBN.Text + "';");
                }
                else if (btnOk.Text == "Update")
                {
                    LoadDataGrid("UPDATE Books SET ISBN = '" + txtISBN.Text + "',Title = '" + txtTitle.Text
                        + "',CopyDate = " + mbxCopyDate.Text + ",Author = '" + txtAuthor.Text + "',Publisher = '"
                        + txtPublisher.Text + "',Pages = " + txtPages.Text + ",SubCode = '" + mbxSubCode.Text
                        + "' WHERE ISBN = '" + txtISBN.Text + "';");
                }
                else if (btnOk.Text == "Add")
                {
                    btnOk.Enabled = false;
                    LoadDataGrid("INSERT INTO Books Values('" + txtISBN.Text + "','" + txtTitle.Text + "',"
                        + mbxCopyDate.Text + ",'" + txtAuthor.Text + "','" + txtPublisher.Text + "',"
                        + txtPages.Text + ",'" + mbxSubCode.Text + "');");
                }
                else
                {
                    MessageBox.Show("Wrong button text");
                }
                //this updates the current tables
                LoadDataGrid("SELECT * FROM Books");
                DisplayTo_txt();
                TextBoxes("Clear");
                btnOk.Enabled = false;
                ViewMode();
            }
        }

        public void DisplayTo_txt()
        {
            // Get row clicked on in dgvMembers and display the row number
            int selectedRow = dgvBooks.CurrentRow.Index;
            // Display record clicked message
            mbxSubCode.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][6].ToString();
            txtISBN.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][0].ToString();
            txtTitle.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][1].ToString();
            mbxCopyDate.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][2].ToString();
            txtAuthor.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][3].ToString();
            txtPublisher.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][4].ToString();
            txtPages.Text = DbBooksClass.BooksDS.Tables[DbBooksClass.BooksDT].Rows[selectedRow][5].ToString();
        }

        public void ViewMode()
        {//this functions resets the for to view mode after an edit is made and when the form loads
            TextBoxes("Disabled");
            btnOk.Hide();
            mnuEdit_DeleteBook.Enabled = false;
            mnuEdit_UpdateBook.Enabled = false;
            mnuFile_ClearAll.Enabled = false;
            cbxSubjectCodes.Focus();
        }

        public bool Invalid()
        {//validates all textboxes to have content and the bub code to have 3 characters
            bool invalid = true;
            if (mbxSubCode.Text.Length < 3 || mbxSubCode.Text == "")
            {
                errProviderTxt.SetError(mbxSubCode, "input 3 initials of a subject");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(mbxSubCode, "");
                invalid = false;
            }

            if (txtISBN.Text == "")
            {
                errProviderTxt.SetError(txtISBN, "This textbox can't be NULL");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(txtISBN, "");
                invalid = false;
            }

            if (txtTitle.Text == "")
            {
                errProviderTxt.SetError(txtTitle, "This textbox can't be NULL");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(txtTitle, "");
                invalid = false;
            }

            if (txtAuthor.Text == "")
            {
                errProviderTxt.SetError(txtAuthor, "This textbox can't be NULL");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(txtAuthor, "");
                invalid = false;
            }


            if (mbxCopyDate.Text.Length < 4 || mbxCopyDate.Text == "")
            {
                errProviderTxt.SetError(mbxCopyDate, "input must be a year Ex. 2000");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(mbxCopyDate, "");
                invalid = false;
            }

            if (txtPublisher.Text == "")
            {
                errProviderTxt.SetError(txtPublisher, "This textbox can't be NULL");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(txtPublisher, "");
                invalid = false;
            }

            if (txtPages.Text == "")
            {
                errProviderTxt.SetError(txtPages, "This textbox can't be NULL");
                invalid = true;
            }
            else
            {
                errProviderTxt.SetError(txtPages, "");
                invalid = false;
            }
            return invalid;
        }


        //***************IGNORE THIS
        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {

        }

        private void mbxSubCode_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void txtISBN_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void mnsMainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
