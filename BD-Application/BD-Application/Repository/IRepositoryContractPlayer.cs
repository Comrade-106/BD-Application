using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryContractPlayer {
        bool AddContractPlayer(ContractPlayer contract);
        bool ChangeContractPlayer(ContractPlayer contract);
        bool DeleteContractPlayer(ContractPlayer contract);
        List<Contract> GetAllContracts(int id_player);
        ContractPlayer GetActiveContract(int id_player);
        int NumberOfMainPlayerInTeam(int id_team);
    }
}
