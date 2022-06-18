using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryContractPlayer {
        bool AddContractPlayer(ContractPlayer contract);
        bool ChangeContractPlayer(ContractPlayer contract);
        bool DeleteContractPlayer(ContractPlayer contract);
        bool DeleteAllContractByTeamId(int id_team);
        List<Contract> GetAllContracts(int id_player);
        ContractPlayer GetActiveContract(int id_player);
        int NumberOfMainPlayerInTeam(int id_team);
        List<string> GetIdPlayerByTeamId(int id_team);
        bool CheckContractByTeamId(int id_team);
    }
}
