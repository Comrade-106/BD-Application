namespace BD_Application.Domain {
    public class Team {
        private int id;
        private string name;
        private int worldRank;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public int WorldRank { get { return worldRank; } set { worldRank = value; } }

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
    }
}
