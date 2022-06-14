using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.DataBase {
    class DBRepository : IRepositoryPlayer {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private MySqlConnection connection = null;

        public DBRepository() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Player> GetAllPlayers() {
            List<Player> list = new List<Player>();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            connection.Open();

            string sql = "SELECT * FROM player;";
            MySqlCommand cmd = new MySqlCommand(sql);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {

            }

            connection.Close();

            return list;
        }

        public bool AddPlayer(Player player) {
            connection.Open();

            string sql = "INSERT INTO TABLE player VALUES(NULL, @nickname, @full_name, @birthday, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = player.NickName;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = player.Name;
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

            string sql = "UPDATE player SET nickname = @nickname, full_name = @full_name, birthday = @birthday, WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = player.NickName;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = player.Name;
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

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = player.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddCoach(Coach coach) {
            connection.Open();

            string sql = "INSERT INTO TABLE coach VALUES(NULL, @nickname, @full_name, @birthday, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = coach.NickName;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = coach.Name;
            cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = coach.BirthDay.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@isDeleted", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool ChangeCoach(Coach coach) {
            connection.Open();

            string sql = "UPDATE coach SET nickname = @nickname, full_name = @full_name, birthday = @birthday, WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = coach.NickName;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = coach.Name;
            cmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = coach.BirthDay.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = coach.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteCoach(Coach coach) {
            connection.Open();

            string sql = "UPDATE coach SET idDelete = @idDelete WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = coach.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddTeam(Team team) {
            connection.Open();

            string sql = "INSERT INTO TABLE team VALUES(NULL, @name, @world_rank, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = team.Name;
            cmd.Parameters.Add("@world_rank", MySqlDbType.Int16).Value = team.WorldRank;
            cmd.Parameters.Add("@isDeleted", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool ChangeTeam(Team team) {
            connection.Open();

            string sql = "UPDATE team SET name = @name, world_rank = @world_rank WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = team.Name;
            cmd.Parameters.Add("@world_rank", MySqlDbType.Int16).Value = team.WorldRank;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = team.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteTeam(Team team) {
            connection.Open();

            string sql = "UPDATE team SET name = @name, world_rank = @world_rank WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = team.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddOrganizer(Organizer organizer) {
            connection.Open();

            string sql = "INSERT INTO TABLE organizer VALUES(NULL, @name, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = organizer.Name;
            cmd.Parameters.Add("@isDeleted", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool ChangeOrganizer(Organizer organizer) {
            connection.Open();

            string sql = "UPDATE organizer SET name = @name  WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = organizer.Name;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = organizer.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteOrganizer(Organizer organizer) {
            connection.Open();

            string sql = "UPDATE organizer SET isDelete = @isDelete  WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = organizer.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddTournament(Tournament tournament) {
            connection.Open();

            string sql = "INSERT INTO tournament VALUES (NULL, @organizer, @name_tournament, @start_date, @end_date, @prize_pool, @tournament_tree, @isDelete);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@organizer", MySqlDbType.Int16).Value = tournament.Organizer.Id;
            cmd.Parameters.Add("@name_tournament", MySqlDbType.VarChar).Value = tournament.Name;
            cmd.Parameters.Add("@start_date", MySqlDbType.Date).Value = tournament.DateStart.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@end_date", MySqlDbType.Date).Value = tournament.DateEnd.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@prize_pool", MySqlDbType.Double).Value = tournament.PrizePool;
            cmd.Parameters.Add("@tournament_tree", MySqlDbType.Byte).Value = null;
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool ChangeTournament(Tournament tournament) {
            connection.Open();

            string sql = "UPDATE tournament SET organizer = @organizer, name_tournament = @name_tournament, start_date = @start_date, " +
                "end_date = @end_date, prize_pool = @prize_pool, tournament_tree = @tournament_tree WHERE id = @id);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@organizer", MySqlDbType.Int16).Value = tournament.Organizer.Id;
            cmd.Parameters.Add("@name_tournament", MySqlDbType.VarChar).Value = tournament.Name;
            cmd.Parameters.Add("@start_date", MySqlDbType.Date).Value = tournament.DateStart.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@end_date", MySqlDbType.Date).Value = tournament.DateEnd.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@prize_pool", MySqlDbType.Double).Value = tournament.PrizePool;
            cmd.Parameters.Add("@tournament_tree", MySqlDbType.Byte).Value = null;              //serialisible tree
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteTournament(Tournament tournament) {
            connection.Open();

            string sql = "UPDATE tournament SET isDelete = @isDelete WHERE id = @id);";

            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
