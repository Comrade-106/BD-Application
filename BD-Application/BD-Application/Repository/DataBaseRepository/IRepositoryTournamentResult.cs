using BD_Application.Domain;
using System.Collections.Generic;
using System.Data;


namespace BD_Application.Repository.DataBaseRepository {
    public interface IRepositoryTournamentResult {
        bool AddTournamentResult(List<ResultTournament> list);
        DataTable GetResultTournamen(int id_tournament);
    }
}
