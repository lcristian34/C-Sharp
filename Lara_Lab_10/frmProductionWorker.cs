using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    public partial class frmProductionWorker : Form
    {
        ProductionWorker pw = new ProductionWorker();
        
        public frmProductionWorker()
        {
            InitializeComponent();
        }

        public virtual void Display(int listIndex)
        {//sets the textboxes to the current value of the variables in the production worker
            ProductionWorker pw = new ProductionWorker();
            pw.setData();
            txtEmpID.Text = pw._EmpID;
            txtName.Text = pw._Name;
            txtPayRate.Text = pw._Payrate;
            txtShift.Text = pw._shift;
        }

        private void frmProductionWorker_Load(object sender, EventArgs e)
        {//sets the next and buttons to true of false depending of the counter and kist count
            ProductionWorker p = new ProductionWorker();
            if(p.PWcounter == 0)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Enabled = true;
            }
            if(p.PWcounter == Print_File._lstProduWor.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //closes the crurrent form
            this.Close();
            //shows the from
            Application.OpenForms[0].Show();
        }

        
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //check if the current number is one
            if (pw.PWcounter <= 1)
            {
                //disables previouys
                btnPrevious.Enabled = false;
            }
            else if (pw.PWcounter != Print_File._lstProduWor.Count)
            {//renables next button
                btnNext.Enabled = true;
            }
            //lesses the current people count
            pw.PWcounter--;
            //dislpays current person
            Display(pw.PWcounter);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //adds one to current person index
            pw.PWcounter++;
            //checks if the person on the list have runed out
            if (pw.PWcounter == Print_File._lstProduWor.Count - 1)
            {//disables the next button 
                btnNext.Enabled = false;
            }
            //reenables the previus button
            else if (pw.PWcounter != 0)
            {
                btnPrevious.Enabled = true;
            }
            //displays current person
            Display(pw.PWcounter);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {//the ok button changes to add or to update accordenly to the for it is been used on
            ProductionWorker p = new ProductionWorker();
            
            if (btnOk.Text == "Add" && this.Text == "Add Production Worker")
            {//if the ok vutton is add and the form is productiuon worker this runs
                if (txtName.Text == "" || txtPayRate.Text == "" || txtShift.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes");
                }
                else
                {
                    //creates a string array of all the fielsds entered and the blank spaces
                    string[] str = { "Production Worker", txtName.Text, txtEmpID.Text, txtShift.Text,
                    txtPayRate.Text, " ", " ", " ", " ", " " };
                    //adds the string to the lsut
                    Print_File._lstProduWor.Add(str);
                    //tells user about the action then clears textboxes
                    MessageBox.Show(txtName.Text + " With id " + txtEmpID.Text + " has been added to the list");
                    txtName.Text = "";
                    txtEmpID.Text = "";
                    txtPayRate.Text = "";
                    txtShift.Text = "";
                }
            }
            else if (btnOk.Text == "Update" && this.Text == "Update Production Worker")
            {//if ok is update and on production worker form
                //the puts all the input and blanks in a string array
                string[] str = { "Production Worker", txtName.Text, txtEmpID.Text, txtShift.Text,
                    txtPayRate.Text, " ", " ", " ", " ", " " };
                //removes the current list item to remplace it with the current string array
                Print_File._lstProduWor.RemoveAt(p.PWcounter);
                Print_File._lstProduWor.Insert(p.PWcounter,str);
                MessageBox.Show(txtName.Text + " has been Updated");
            }

        }

        //ignore this
        private void txtPayRate_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPayrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
