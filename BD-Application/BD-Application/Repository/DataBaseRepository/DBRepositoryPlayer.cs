using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryPlayer : IRepositoryPlayer {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryPlayer() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public Player GetPlayerById(int id_player) {
            Player player = null;
            connection.Open();

            string sql = "SELECT * FROM player WHERE id = @id_player";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id_player", id_player);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                player = new Player(
                    reader.GetInt32("id"),
                    reader.GetString("nickname"),
                    reader.GetString("full_name"),
                    reader.GetDateTime("birthday")
                );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                } 
            }

            connection.Close();
            return player;
        }

        public List<Player> GetPlayersWithoutContract() {
            List<Player> list = new List<Player>();

            connection.Open();

            string sql = "SELECT * FROM playerwithoutteam";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var player = new Player(
                    reader.GetInt32("id"),
                    reader.GetString("nickname"),
                    reader.GetString("full_name"),
                    reader.GetDateTime("birthday")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(player);
            }

            connection.Close();
            return list;
        }

        public List<Player> GetAllPlayers() {
            List<Player> list = new List<Player>();

            connection.Open();

            string sql = "SELECT * FROM player;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var player = new Player(
                    reader.GetInt32("id"),
                    reader.GetString("nickname"),
                    reader.GetString("full_name"),
                    reader.GetDateTime("birthday")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(player);
            }

            connection.Close();
            return list;
        }

        public bool AddPlayer(Player player) {
            connection.Open();
            string sql = "INSERT INTO player VALUES(NULL, @nickname, @full_name, @birthday, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = player.NickName;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = player.Name;
            cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = player.BirthDay.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@isDeleted", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();

            return true;
        }

        public bool ChangePlayer(Player player) {
            connection.Open();

            string sql = "UPDATE player SET nickname = @nickname, full_name = @full_name, birthday = @birthday WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = player.NickName;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = player.Name;
            cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = player.BirthDay.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = player.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeletePlayer(Player player) {
            connection.Open();

            string sql = "UPDATE player SET isDelete = @isDelete WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = player.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
