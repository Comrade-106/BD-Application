using BD_Application.Domain;

namespace BD_Application.Repository {
    internal interface IRepositoryStage {
        Stage1 GetStage(int id);
    }
}
