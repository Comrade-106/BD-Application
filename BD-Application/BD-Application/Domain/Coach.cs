﻿using System;

namespace BD_Application.Domain {
    internal class Coach : Person {
        private int id;
        private bool isDelete;

        public int Id { get { return id; } set { id = value; } }

        public bool IsDelete { get { return isDelete; } set { isDelete = value; } } 

        public Coach(string nickName, string name, DateTime birthDay) : base(nickName, name, birthDay) {
            isDelete = false;
        }
    }
}
