using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.DataBase {
    internal interface IRepositoryContractCoach {
        bool AddContractCoach(ContractCoach contract);
        bool ChangeContractCoach(ContractCoach contract);
        bool DeleteContractCoach(ContractCoach contract);
        List<Contract> GetAllContracts(int id_coach);
    }
}
