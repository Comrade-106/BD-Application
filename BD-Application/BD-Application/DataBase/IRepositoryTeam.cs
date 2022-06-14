using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryTeam {
        bool AddTeam(Team team);
        bool ChangeTeam(Team team);
        bool DeleteTeam(Team team);
    }
}
