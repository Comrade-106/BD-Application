using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryTournanent {

        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
        List<Tournament> GetAllTournament();
        Tournament GetTournament(int id);
        string GetTournamentTree();
    }
}
