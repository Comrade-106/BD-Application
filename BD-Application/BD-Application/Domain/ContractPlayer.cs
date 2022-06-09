using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    internal class ContractPlayer : Contract {
        private int idPlayerContract;
        private int idPlayer;

        public ContractPlayer(int idPlayer, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) {
            this.idPlayer = idPlayer;
        }

    }
}
