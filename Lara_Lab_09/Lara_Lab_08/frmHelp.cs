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
    public partial class frmHelp : Form
    {
        public frmHelp()
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

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }
    }
}
