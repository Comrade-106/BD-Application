using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryTournanent {
        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
    }
}
