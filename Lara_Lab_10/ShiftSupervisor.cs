using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lara_Lab_10
{
    class ShiftSupervisor : Employee
    {
        //declares two variables used in the shiftsupervisor form
        public string _AnnualSalary { get; set; } = "";
        public string _AnnualProductionBonus { get; set; } = "";


        //uses inherited variables from employee
        public void setData()
        {//sets the data on the current list item to the variables used to set the textboxes 
            ShiftSupervisor s = new ShiftSupervisor();
            _typeWorker = Print_File._lstShiftSup[s.SSCounter][0];
            _Name = Print_File._lstShiftSup[s.SSCounter][1];
            _EmpID = Print_File._lstShiftSup[s.SSCounter][2];
            _AnnualSalary = Print_File._lstShiftSup[s.SSCounter][5];
            _AnnualProductionBonus = Print_File._lstShiftSup[s.SSCounter][6];
        }
    }
}
