namespace BD_Application.Domain {
    internal class Organizer {
        private int id;
        private string name;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public Organizer(string name) {
            this.name = name;
        }
    }
}
