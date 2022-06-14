using System;
using System.Collections.Generic;

namespace BD_Application.Domain {
    internal class Tournament {
        private int id;
        private string name;
        private Organizer organizer;
        private string location;
        private DateTime dateStart;
        private DateTime dateEnd;
        private double prizePool;
        private List<Team> teams;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public Organizer Organizer { get { return organizer; } set { organizer = value; } }

        public string Location { get { return location; } set { location = value; } }

        public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }

        public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }

        public double PrizePool { get { return prizePool; } set { prizePool = value; } }

        public List<Team> Teams { get { return teams; } set { teams = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        public Tournament(string name, Organizer organizer, string location, DateTime dateStart, DateTime dateEnd, double prizePool, List<Team> teams) {
            this.name = name;
            this.organizer = organizer;
            this.location = location;
            this.dateStart = dateStart;
            this.dateEnd = dateEnd;
            this.prizePool = prizePool;
            this.teams = teams;
            this.isDelete = false;
        }
    }
}
