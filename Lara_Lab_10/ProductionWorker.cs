using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Lab_10
{
    class ProductionWorker : Employee
    {
        
        //declares two variables used in the production worker form
        public string _shift { get; set; } = "";
        public string _Payrate { get; set; } = "";


        //uses inherited variables from employee
        public virtual void setData()
        {//sets the data on the current list item to the variables used to set the textboxes 
            ProductionWorker pw = new ProductionWorker();
            _typeWorker = Print_File._lstProduWor[pw.PWcounter][0];
            _Name = Print_File._lstProduWor[pw.PWcounter][1];
            _EmpID = Print_File._lstProduWor[pw.PWcounter][2];
            _shift = Print_File._lstProduWor[pw.PWcounter][3];
            _Payrate = Print_File._lstProduWor[pw.PWcounter][4];
        }

       

        
    }
}
