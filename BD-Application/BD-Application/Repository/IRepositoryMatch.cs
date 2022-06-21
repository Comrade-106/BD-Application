using BD_Application.Domain;
using System;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.Repository {
    public interface IRepositoryMatch {
        bool AddMatch(Match match);
        bool AddMatches(List<Match> matches);
        bool ChangeMatch(Match match);
        List<Match> GetAllMatch(int id_tournament);
        DataTable GetAllMatchToday();
        DataTable MatchesInPeriod(DateTime start, DateTime end);
        Match GetMatch(int id, int idTournament);
    }
}
