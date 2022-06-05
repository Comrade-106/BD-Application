﻿using System;

namespace BD_Application.Domain {
    internal class Player : Person {
        private int id;
        private Team currectTeam;

        public int Id { get { return id; } set { id = value; } }

        public Team Team { get { return currectTeam; } set { currectTeam = value; } }
        
        public Player(string nickName, string name, DateTime birthDay, Team team) : base(nickName, name, birthDay) {
            currectTeam = team;
        }
    }
}
