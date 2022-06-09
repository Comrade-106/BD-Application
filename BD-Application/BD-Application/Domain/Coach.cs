using System;

namespace BD_Application.Domain {
    internal class Coach : Person {
        private int id;

        public int Id { get { return id; } set { id = value; } }

        public Coach(string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) { }
    }
}
