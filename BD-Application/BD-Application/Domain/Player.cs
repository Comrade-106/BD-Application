using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Domain {
    public class Player : Person {
        private int id;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } }

        public Player(string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) {
            isDelete = false;
        }
        public Player(int id, string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) {
            this.Id = id;
            isDelete = false;
        }
    }
}
