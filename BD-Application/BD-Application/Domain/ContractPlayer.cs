using System;

namespace BD_Application.Domain {
    internal class ContractPlayer : Contract {
        private int idPlayerContract;
        private int idPlayer;
        private bool isMain;

        public int IdPlayerContract { get { return idPlayerContract; } set { idPlayerContract = value; } }
        public int IdPlayer { get { return idPlayer; } set { idPlayer = value; } }

        public bool IsMain { get { return isMain; } set { isMain = value; } }

        public ContractPlayer(int idPlayer, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) {
            this.idPlayer = idPlayer;
            this.idPlayerContract = -1;
        }

        public ContractPlayer(int id, int idPlayer, int idTeam, DateTime dateFrom, DateTime dateTo, double salary) : base(idTeam, dateFrom, dateTo, salary) {
            this.idPlayerContract = id;
            this.idPlayer = idPlayer;
        }

    }
}
