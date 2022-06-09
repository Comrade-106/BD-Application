using System;

namespace BD_Application.Domain {
    internal class Player : Person {
        private int id;
        //private List<Contract> contracts;
        //private Team currectTeam;

        public int Id { get { return id; } set { id = value; } }
        
        public Player(string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) { }
    }
}
