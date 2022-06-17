﻿using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryCoach {
        bool AddCoach(Coach coach);
        bool ChangeCoach(Coach coach);
        bool DeleteCoach(Coach coach);
        List<Coach> GetAllCoaches();
    }
}