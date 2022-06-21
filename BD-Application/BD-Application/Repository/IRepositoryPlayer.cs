using BD_Application.Domain;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.Repository {
    public interface IRepositoryPlayer {
        bool AddPlayer(Player player);
        bool ChangePlayer(Player player);
        bool DeletePlayer(Player player);
        List<Player> GetAllPlayers();
        List<Player> GetPlayers(string letterInName);
        DataTable GetPlayersWithoutContract();
        Player GetPlayerById(int id_player);
    }
}
