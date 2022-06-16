using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    internal class ContractCoach : Contract {
        private int idCoachContract;
        private int idCoach;

        public int IdCoachContract { get { return idCoachContract; } set { idCoachContract = value; } }
        public int IdCoach { get { return idCoach; } set { idCoach = value; } }

        public ContractCoach(int idCoach, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) { 
            this.idCoach = idCoach;
        }

        public ContractCoach(int id, int idCoach, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) {
            this.idCoachContract = id;
            this.idCoach = idCoach;
        }
    }
}
