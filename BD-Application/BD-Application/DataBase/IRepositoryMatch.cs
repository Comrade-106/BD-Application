using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryMatch {
        bool AddMatch(Match match);
        bool ChangeMatch(Match match);
    }
}
