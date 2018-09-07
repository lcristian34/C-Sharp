using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lara_Lab_10
{
    class TeamLeader : ProductionWorker
    {
        //declares three variables used in the team leader form
        public string _MontlyBonus { get; set; } = "";
        public string _RecTrainingHrs { get; set; } = "";
        public string _AttTrainingHrs { get; set; } = "";

        //uses inherited variables from production workers
        public override void setData()
        {//sets the data on the current list item to the variables used to set the textboxes 
            TeamLeader t = new TeamLeader();
            _typeWorker = Print_File._lstTeamLead[t.TLCounter][0];
            _Name = Print_File._lstTeamLead[t.TLCounter][1];
            _EmpID = Print_File._lstTeamLead[t.TLCounter][2];
            _shift = Print_File._lstProduWor[t.PWcounter][3];
            _Payrate = Print_File._lstProduWor[t.PWcounter][4];
            _MontlyBonus = Print_File._lstTeamLead[t.TLCounter][7];
            _RecTrainingHrs = Print_File._lstTeamLead[t.TLCounter][8];
            _AttTrainingHrs = Print_File._lstTeamLead[t.TLCounter][9];
        }
    }
}
