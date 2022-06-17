using System;

namespace BD_Application.Domain {
    public class Tournament {
        private int id;
        private string name;
        private Organizer organizer;
        private DateTime dateStart;
        private DateTime dateEnd;
        private double prizePool;
<<<<<<< HEAD
        //private List<Team> teams;
=======
>>>>>>> 3ed72ddae051a80ffcb40739e22094e815e1482a
        private string tournamentTree;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public Organizer Organizer { get { return organizer; } set { organizer = value; } }

        public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }

        public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }

        public double PrizePool { get { return prizePool; } set { prizePool = value; } }

        public string TournamentTree { get { return tournamentTree; } set { tournamentTree = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        public Tournament(string name, Organizer organizer, DateTime dateStart, DateTime dateEnd, double prizePool) {
            this.name = name;
            this.organizer = organizer;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.prizePool = prizePool;
            this.isDelete = false;
        }
        public Tournament(int id, string name, DateTime dateStart, DateTime dateEnd, double prizePool) {
            this.name = name;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.prizePool = prizePool;
            this.isDelete = false;
        }
    }
}
