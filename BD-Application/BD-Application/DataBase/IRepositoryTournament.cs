using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.DataBase {
    internal interface IRepositoryTournament {
        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
        List<Tournament> GetAllTournament();
        string GetTournamentTree();
    }
}
