using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    internal interface IRepositoryPlayer {
        bool AddPlayer(Player player);
        bool ChangePlayer(Player player);
        bool DeletePlayer(Player player);
        List<Player> GetAllPlayers();
        List<Player> GetPlayersWithoutContract();
    }
}
