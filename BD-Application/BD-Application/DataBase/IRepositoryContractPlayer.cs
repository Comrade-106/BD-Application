using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryContractPlayer {
        bool AddContractPlayer(ContractPlayer contract);
        bool ChangeContractPlayer(ContractPlayer contract);
    }
}
