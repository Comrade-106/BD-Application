namespace BD_Application.Domain {
    internal class Organizer {
        private int id;
        private string name;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        public Organizer(string name) {
            this.name = name;
            isDelete = false;
        }
        public Organizer(int id, string name) {
            this.id = id;
            this.name = name;
            isDelete = false;
        }
    }
}
