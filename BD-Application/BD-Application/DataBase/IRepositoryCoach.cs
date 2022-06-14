﻿using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryCoach {
        bool AddCoach(Coach coach);
        bool ChangeCoach(Coach coach);
        bool DeleteCoach(Coach coach);
    }
}