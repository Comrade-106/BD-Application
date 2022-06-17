using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryTeam : IRepositoryTeam {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryTeam() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Team> GetAllTeams() {
            List<Team> list = new List<Team>();
            connection.Open();

            string sql = "SELECT * FROM team;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var team = new Team(
                    reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetInt32("world_rank")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(team);
            }

            connection.Close();
            return list;
        }

        public List<Team> GetTeams(string letterInName) {
            List<Team> list = new List<Team>();
            connection.Open();

            string sql = "SELECT * FROM team WHERE LEFT(name, @n) = @name";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@n", letterInName.Length);
            cmd.Parameters.AddWithValue("@name", letterInName);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var team = new Team(
                    reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetInt32("world_rank")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(team);
            }

            connection.Close();
            return list;
        }

        public Team GetTeam(int id_team) {
            Team team = null;
            connection.Open();

            string sql = "SELECT * FROM team WHERE id = @id;";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_team;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                    team = new Team(
                    reader.GetInt32("id"),
                    reader.GetString("name"),
                    reader.GetInt32("world_rank")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    team.IsDelete = true;
                }
            }

            connection.Close();
            return team;
        }

        public bool AddTeam(Team team) {
            connection.Open();

            string sql = "INSERT INTO team VALUES(NULL, @name, @world_rank, @isDelete);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = team.Name;
            cmd.Parameters.Add("@world_rank", MySqlDbType.Int16).Value = team.WorldRank;
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 0;

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

            MySqlCommand cmd = new MySqlCommand(sql, connection);
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

            string sql = "UPDATE team SET isDelete = @isDelete WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = team.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
