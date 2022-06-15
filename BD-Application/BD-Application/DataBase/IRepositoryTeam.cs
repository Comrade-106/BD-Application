using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.DataBase {
    internal interface IRepositoryTeam {
        bool AddTeam(Team team);
        bool ChangeTeam(Team team);
        bool DeleteTeam(Team team);
        List<Team> GetAllTeams();
    }
}
