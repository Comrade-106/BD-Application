using BD_Application.Domain;
using System.Collections.Generic;

namespace BD_Application.Repository {
    public interface IRepositoryPlayer {
        bool AddPlayer(Player player);
        bool ChangePlayer(Player player);
        bool DeletePlayer(Player player);
        List<Player> GetAllPlayers();
        List<Player> GetPlayers(string letterInName);
        List<Player> GetPlayersWithoutContract();
        Player GetPlayerById(int id_player);
    }
}
