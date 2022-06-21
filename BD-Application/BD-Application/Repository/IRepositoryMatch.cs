using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryMatch {
        bool AddMatch(Match match);
        bool AddMatches(List<Match> matches);
        bool ChangeMatch(Match match);
        List<Match> GetAllMatch(int id_tournament);
        Match GetMatch(int id, int idTournament);
    }
}
