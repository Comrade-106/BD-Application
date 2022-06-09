using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    internal class ContractCoach : Contract {
        private int idCoachContract;
        private int idCoach;

        public ContractCoach(int idCoach, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) { 
            this.idCoach = idCoach;
        }
    }
}
