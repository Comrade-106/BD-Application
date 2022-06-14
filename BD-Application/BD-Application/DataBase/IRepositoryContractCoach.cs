using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryContractCoach {
        bool AddContractCoach(ContractCoach contract);
        bool ChangeContractCoach(ContractCoach contract);
    }
}
