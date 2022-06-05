using System.Collections.Generic;

namespace BD_Application.Domain {
    internal class Team {
        private int id;
        private string name;
        private int worldRank;
        private Coach coach;
        private List<Tournament> achievement;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public int WorldRank { get { return worldRank; } set { worldRank = value; } }

        public Coach Coach { get { return coach; } set { coach = value; } }

        public List<Tournament> Achievement { get { return achievement; } set { achievement = value; } }

        public Team(string name, int worldRank, Coach coach) {
            this.name = name;
            this.worldRank = worldRank;
            this.coach = coach;
        }

        public Team(string name, int worldRank, Coach coach, List<Tournament> achievement) {
            this.name = name;
            this.worldRank = worldRank;
            this.coach = coach;
            this.achievement = achievement;
        }
    }
}
