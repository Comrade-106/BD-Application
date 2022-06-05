using System;

namespace BD_Application.Domain {
    internal abstract class Person {
        private string nickName;
        private string name;
        private DateTime birthDay;

        public string NickName { get { return nickName; } set { nickName = value; } }

        public string Name { get { return name; } set { name = value; } }

        public DateTime BirthDay { get { return birthDay; } set { birthDay = value; } }

        protected Person(string nickName, string name, DateTime birthDay) {
            this.nickName = nickName;
            this.name = name;
            this.birthDay = birthDay;
        }

    }
}
