using BD_Application.Domain;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.Repository {
    public interface IRepositoryCoach {
        bool AddCoach(Coach coach);
        bool ChangeCoach(Coach coach);
        bool DeleteCoach(Coach coach);
        List<Coach> GetAllCoaches();
        DataTable GetCoachesWithoutContract();
        List<Coach> GetCoaches(string nicnameOrSomeFirsSymbol);
        Coach GetCoach(int id);
    }
}
