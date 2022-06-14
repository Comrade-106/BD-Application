using System;

namespace BD_Application.Domain {
    internal class Player : Person {
        private int id;
        private bool isDeleted;
        //private List<Contract> contracts;
        //private Team currectTeam;

        public int Id { get { return id; } set { id = value; } }

        public bool IsDeleted { get { return isDeleted; } set { isDeleted = value; } } 
        
        public Player(string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) {
            isDeleted = false;
        }

        public Player(int id, string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) {
            this.Id = id;
            isDeleted = false;
        }
    }
}
