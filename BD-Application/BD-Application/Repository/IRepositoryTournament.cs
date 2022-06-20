using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryTournament {
        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
        List<Tournament> GetAllTournament();
        List<Tournament> GetTournaments(string nameOrLetterFromName);
        Tournament GetTournament(int id);
        string GetTournamentTree();
    }
}
