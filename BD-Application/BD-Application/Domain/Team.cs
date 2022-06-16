using System.Collections.Generic;

namespace BD_Application.Domain {
    internal class Team {
        private int id;
        private string name;
        private int worldRank;
        private List<Tournament> achievement;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public int WorldRank { get { return worldRank; } set { worldRank = value; } }

        public List<Tournament> Achievement { get { return achievement; } set { achievement = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        public Team(string name, int worldRank) {
            this.name = name;
            this.worldRank = worldRank;
            isDelete = false;
        }

        public Team(int id, string name, int worldRank) {
            this.id = id;
            this.name = name;
            this.worldRank = worldRank;
            isDelete = false;
        }

        public Team(string name, int worldRank, List<Tournament> achievement) {
            this.name = name;
            this.worldRank = worldRank;
            this.achievement = achievement;
            isDelete = false;
        }
    }
}
