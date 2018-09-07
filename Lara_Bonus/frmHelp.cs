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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            if (this.Text == "About")
            {//if the form title is about this is shown
                lblTitle.Text = "Programmed By Christian Lara";
                lblDescription.Text = "This application will get data from a database\n" +
                "of book titles and its authors. The data will be\n" +
                "displayed on the data view grid then you can\n" +
                "click a book to access more info about it.";
            }
            else if (this.Text == "Instructions")
            {//if the form title is Instructions this is shown
                lblTitle.Text = "Students Database";
                lblDescription.Text = "*Press a record from the data grid view\n" +
                "*You can view additional info on the textboxes\n" +
                "*You can update, add or delete rocorrds using \n   the edit menu.\n";
            }
        }

        
    }
}
