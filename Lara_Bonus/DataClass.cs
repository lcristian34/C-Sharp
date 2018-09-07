using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Lara_Bonus
{
    public class DataClass
    {
        // Declare a CONSTANT CONNECTION STRING to Access Database "KarateMembers.mdb"
        private const string CONNECT_STRING = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = |DataDirectory|\DbFiles\Bonus_Access.mdb; Persist Security Info=True";

        // Declare ADO objects  using OleDb to make a connection
        private static OleDbConnection cntStudents = new OleDbConnection(CONNECT_STRING);
        //using OleDB to make DataAdapter
        private static OleDbDataAdapter daStudents = new OleDbDataAdapter();
        //create a OleDb command
        private static OleDbCommand sqlCommand = new OleDbCommand();

        //creates a subs table dataset
        public static DataSet ds_Students { get; set; } = new DataSet();
        //creates a data table of subs tables
        public static string dt_Students { get; set; } = "Student";
        //creates a subs table dataset
        public static string dt_Class { get; set; } = "Class";

        public static void GetClassifications(string query, frmMain m)
        {
            // Setup data connection, dataset, data adapter, and data table.
            try
            {
                //first thing open database
                cntStudents.Open();
                //clear dataset
                ds_Students.Clear();
                // SQL statement to query all records for a single table.
                sqlCommand.CommandText = query;
                //runs command to the datatable 
                daStudents.SelectCommand = sqlCommand;
                //runs command with the connection on the db
                sqlCommand.Connection = cntStudents;
                // Open data connection           
                daStudents.Fill(ds_Students, dt_Class);
                // Close the data connection
                cntStudents.Close();
            }
            catch (Exception ex)
            {//cathces an execption if the sql query is wrong and displays the error
                //closes the connection
                cntStudents.Close();
                MessageBox.Show("Students DB Table Access Failed\n\n" + ex.Message);
            }

        }

        public static void CreateStudDataSet(string query, frmMain m)
        {
            // Setup data connection, dataset, data adapter, and data table.
            try
            {
                //first thing open database
                cntStudents.Open();
                //clear dataset
                ds_Students.Clear();
                // SQL statement to query all records for a single table.
                sqlCommand.CommandText = query;
                //runs command to the datatable 
                daStudents.SelectCommand = sqlCommand;
                //runs command with the connection on the db
                sqlCommand.Connection = cntStudents;
                // Open data connection           
                daStudents.Fill(ds_Students, dt_Students);
                // Close the data connection
                cntStudents.Close();
                //Bind the dgvMembers data rrid view to the dataset / data table
                m.dgvStudents.DataSource = ds_Students.Tables[dt_Students];
                //Clear any selected row in data grid view
                m.dgvStudents.ClearSelection();
                //runs the format data grid function
                FormatDataGrid(m.dgvStudents);
            }
            catch (Exception ex)
            {//cathces an execption if the sql query is wrong and displays the error
                //closes the connection
                cntStudents.Close();
                MessageBox.Show("Students DB Table Access Failed\n\n" + ex.Message);
            }

        }

        //// Format the data grid to allow easy viewing of column data.
        public static void FormatDataGrid(DataGridView dgvBooks)
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
            dgvBooks.Columns["Student_ID"].Visible = true;
            dgvBooks.Columns["Student_ID"].Width = 40;
            dgvBooks.Columns["Student_ID"].HeaderText = "ID";
            dgvBooks.Columns["First_Name"].Visible = true;
            dgvBooks.Columns["First_Name"].Width = 80;
            dgvBooks.Columns["Middle_Name"].Visible = true;
            dgvBooks.Columns["Middle_Name"].Width = 80;
            dgvBooks.Columns["Last_Name"].Visible = true;
            dgvBooks.Columns["Last_Name"].Width = 80;
            dgvBooks.Columns["Street_Address"].Visible = false;
            dgvBooks.Columns["City"].Visible = false;
            dgvBooks.Columns["State"].Visible = false;
            dgvBooks.Columns["Zipcode"].Visible = false;
            dgvBooks.Columns["Stu_Phone"].Visible = false;
            dgvBooks.Columns["Classification"].Visible = false;
            dgvBooks.Columns["Guardian1"].Visible = false;
            dgvBooks.Columns["Guardian1_Phone"].Visible = false;
            dgvBooks.Columns["Guardian2"].Visible = false;
            dgvBooks.Columns["Guardian2_Phone"].Visible = false;
            dgvBooks.Columns["Emergency_Contact"].Visible = false;
            dgvBooks.Columns["Emer_Cont_Phone"].Visible = false;
            //sets scrolers to vertical only
            dgvBooks.ScrollBars = ScrollBars.Vertical;
        }

        public void TextBoxes(GroupBox grp, string Action)
        {//manages all textboxes and masked boxes on the form
            foreach (Control control in grp.Controls)
                if (control is TextBox)
                {
                    if (Action == "Clear")
                    {
                        (control as TextBox).Clear();
                    }
                    else if (Action == "Hide")
                    {
                        (control as TextBox).Hide();
                    }
                    else if (Action == "Enabled")
                    {
                        (control as TextBox).Enabled = true;
                    }
                    else if (Action == "Disabled")
                    {
                        (control as TextBox).Enabled = false;
                    }
                }
                else if (control is MaskedTextBox)
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
        }


        public void ViewMode(frmMain m)
        {//this functions resets the for to view mode after an edit is made and when the form loads
            TextBoxes(m.grpInfo,"Disabled");
            m.btnOk.Hide();
            m.mnuEdit_Delete.Enabled = false;
            m.mnuEdit_Update.Enabled = false;
            m.mnuFile_ClearAll.Enabled = false;
            m.cbxClassification.Focus();
        }

        public void DisplayTo_txt(frmMain m)
        {
            // Get row clicked on in dgvMembers and display the row number
            int selectedRow = m.dgvStudents.CurrentRow.Index;
            // Display record clicked message
            m.txtStudentID.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][0].ToString();
            m.txtFName.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][1].ToString();
            m.txtMName.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][2].ToString();
            m.txtLName.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][3].ToString();
            m.txtStreetAddress.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][4].ToString();
            m.txtCity.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][5].ToString();
            m.txtState.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][6].ToString();
            m.txtZIpCode.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][7].ToString();
            m.txtStuPhone.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][8].ToString();
            m.txtClass.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][9].ToString();
            m.txtGuardian1.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][10].ToString();
            m.txtGuardian1_Phone.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][11].ToString();
            m.txtGuardian2.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][12].ToString();
            m.txtGuardian2_Phone.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][13].ToString();
            m.txtEmergency_Contact.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][14].ToString();
            m.txtEmer_Cont_Phone.Text = ds_Students.Tables[dt_Students].Rows[selectedRow][15].ToString();
        }

        public int EmptyTxt(frmMain m,GroupBox grp)
        {//validates all textboxes to have content
            int invalCount = 0;
            foreach (Control control in grp.Controls)
            {//loops for each control on the group box
                if (control is TextBox)
                {//if the control is a textbox this runs
                    if ((control as TextBox).Text == "")
                    {//if control is empty the error provider is called
                        m.errProviderTxt.SetError(control, "Fill The textbox");
                        invalCount++;
                    }
                    else
                    {//else erros provider is tuened off
                        m.errProviderTxt.SetError(control, "");
                    }
                }
                if (control is MaskedTextBox)
                {//if controll is a maked textbox this runs
                    if ((control as MaskedTextBox).Text == "")
                    {//if textxbox,text is empty, the error provider is called
                        m.errProviderTxt.SetError(control, "Fill The textbox");
                        invalCount++;
                    }
                    else
                    {//else error provider is set
                        m.errProviderTxt.SetError(control, "");
                    }
                    if ((control as MaskedTextBox).Tag == "phone" && (control as MaskedTextBox).Text.Length < 12)
                    {//if the phone field does not have all the digits this runs
                        m.errProviderTxt.SetError(control, "Enter a 10 digit phone number");
                        invalCount++;
                    }
                    else
                    {//else error provider is set off
                        m.errProviderTxt.SetError(control, "");
                    }
                }
            }

            bool valState = false;
            int i = 0;
            //stores acceptable names for all us states
            string[] states = {"AL","AK","AZ","AR","CA","CO","CT","DE","FL","GA","HI","ID","IL","IN"
                    ,"IA","KS","KY","LA","ME","MD","MA","MI","MN","MS","MO","MT","NE","NV","NH","NJ"
                    ,"NM","NY","NC","ND","OH","OK","OR","PA","RI","SC","SD","TN","TX","UT","VT","VA"
                    ,"WA","WV","WI","WY"};
            foreach(string element in states)
            {//compares each string from states to the user input 
                if(states[i] == m.txtState.Text)
                {
                    valState = true;
                }
                i++;
            }
            //validates for correct state
            if (m.txtState.Text.Length < 2 || valState == false)
            {
                m.errProviderTxt.SetError(m.txtState, "Enter a valid two letter US State(Ex. TX)");
                invalCount++;
            }
            else
            {
                m.errProviderTxt.SetError(m.txtState, "");
            }
            //validates for correct zipcode text lenght
            if (m.txtZIpCode.Text.Length < 5)
            {
                m.errProviderTxt.SetError(m.txtZIpCode, "Enter a 5 digit zip");
                invalCount++;
            }
            else
            {
                m.errProviderTxt.SetError(m.txtZIpCode, "");
            }

            return invalCount;
        }

        
    }
}
