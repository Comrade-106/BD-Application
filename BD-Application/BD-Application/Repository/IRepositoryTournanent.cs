using BD_Application.Domain;
using System.Collections.Generic;

<<<<<<<< HEAD:BD-Application/BD-Application/Repository/IRepositoryTournanent.cs
namespace BD_Application.Repository {
    internal interface IRepositoryTournanent {
========
namespace BD_Application.DataBase {
    internal interface IRepositoryTournament {
>>>>>>>> 041aacee7062167b2892ef722db3e04a26cfffd5:BD-Application/BD-Application/DataBase/IRepositoryTournament.cs
        bool AddTournament(Tournament tournament);
        bool ChangeTournament(Tournament tournament);
        bool DeleteTournament(Tournament tournament);
        List<Tournament> GetAllTournament();
        Tournament GetTournament(int id);
        string GetTournamentTree();
    }
}
