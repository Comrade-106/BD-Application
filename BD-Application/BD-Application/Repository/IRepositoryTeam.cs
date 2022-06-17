using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryTeam {
        bool AddTeam(Team team);
        bool ChangeTeam(Team team);
        bool DeleteTeam(Team team);
        List<Team> GetAllTeams();
        Team GetTeam(int id_team);
        List<Team> GetTeams(string letterInName);
    }
}
