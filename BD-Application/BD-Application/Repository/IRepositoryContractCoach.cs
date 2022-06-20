using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryContractCoach {
        bool AddContractCoach(ContractCoach contract);
        bool ChangeContractCoach(ContractCoach contract);
        bool DeleteContractCoach(ContractCoach contract);
        bool CheckContractByTeamId(int id_team);
        bool DeleteContractCoachByTeamId(int id_team);
        List<Contract> GetAllContracts(int id_coach);
        ContractCoach GetActiveContractByCoach(int id_coach);
        ContractCoach GetActiveContractByTeam(int id_team);
        bool HaveCoachInTheTeame(int id_team);
        int GetCoachIdByIdTeam(int id_team);
    }
}
