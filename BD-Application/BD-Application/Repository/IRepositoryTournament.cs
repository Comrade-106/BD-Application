using BD_Application.Domain;
using System.Collections.Generic;
using System.Data;
using System;

namespace BD_Application.Repository {
    public interface IRepositoryTournament {
        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
        List<Tournament> GetAllTournament();
        DataTable GetTournamentsToday();
        DataTable GetPastTournaments();
        DataTable GetFutureTournaments();
        DataTable TournamentsInPeriod(DateTime start, DateTime end);
        List<Tournament> GetTournaments(string nameOrLetterFromName);
        Tournament GetTournament(int id);
        string GetTournamentTree();
    }
}
