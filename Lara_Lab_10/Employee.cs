using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lara_Lab_10
{
    class Employee
    {
        //cretes an intance of the print class
        Print_File pFile = new Print_File();

        //declaring the three varibles all workers have in common
        public string _typeWorker { get; set; }
        public string _Name { get; set; }
        public string _EmpID { get; set; }
        //declaring counters for each list type
        private static int _PWcounter;
        private static int _SSCounter;
        private static int _TLCounter;

        
        //setting upt setters and getters for counters
        public int PWcounter
        {
            get{ return _PWcounter; }
            set{ _PWcounter = value; }
        }
        public int SSCounter
        {
            get { return _SSCounter; }
            set { _SSCounter = value; }
        }
        public int TLCounter
        {
            get { return _TLCounter; }
            set { _TLCounter = value; }
        }

        
    }
}
