using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.Repository.DataBaseRepository {
    public interface IRepositoryTournamentResult {
        bool AddTournamentResult(List<ResultTournament> list);
        DataTable GetResultTournamen(int id_tournament);
    }
}
