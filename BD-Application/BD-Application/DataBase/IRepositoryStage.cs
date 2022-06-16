using BD_Application.Domain;

namespace BD_Application.DataBase {
    internal interface IRepositoryStage {
        Stage1 GetStage(int id);
    }
}
