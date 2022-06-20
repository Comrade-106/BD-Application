using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryCoach {
        bool AddCoach(Coach coach);
        bool ChangeCoach(Coach coach);
        bool DeleteCoach(Coach coach);
        List<Coach> GetAllCoaches();
        List<Coach> GetCoaches(string nicnameOrSomeFirsSymbol);
        Coach GetCoache(int id);
    }
}
