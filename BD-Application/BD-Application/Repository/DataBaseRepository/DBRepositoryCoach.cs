using BD_Application.Domain;
using BD_Application.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryCoach : IRepositoryCoach {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryCoach() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Coach> GetAllCoaches() {
            List<Coach> list = new List<Coach>();
            connection.Open();

            string sql = "SELECT * FROM coach;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var coach = new Coach(
                    reader.GetInt32("id"),
                    reader.GetString("nickname"),
                    reader.GetString("full_name"),
                    reader.GetDateTime("birthday")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(coach);
            }

            connection.Close();
            return list;
        }

        public DataTable GetCoachesWithoutContract() {
            DataTable data = new DataTable();

            connection.Open();

            string sql = "SELECT * FROM coach_without_contract;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public List<Coach> GetCoaches(string nicknameOrSomeFirsSymbol) {
            List<Coach> list = new List<Coach>();
            connection.Open();

            string sql = "SELECT * FROM coach WHERE LEFT(nickname, @n) = @nickname;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@n", nicknameOrSomeFirsSymbol.Length);
            cmd.Parameters.AddWithValue("@nickname", nicknameOrSomeFirsSymbol);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var coach = new Coach(
                    reader.GetInt32("id"),
                    reader.GetString("nickname"),
                    reader.GetString("full_name"),
                    reader.GetDateTime("birthday")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    continue;
                }
                list.Add(coach);
            }

            connection.Close();
            return list;
        }

        public Coach GetCoach(int id) {
            Coach coach = null;
            connection.Open();

            string sql = "SELECT * FROM coach WHERE id = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("id", id);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                    coach = new Coach(
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
            return coach;
        }

        public bool AddCoach(Coach coach) {
            connection.Open();

            string sql = "INSERT INTO coach VALUES(NULL, @nickname, @full_name, @birthday, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = coach.NickName;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = coach.Name;
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

            string sql = "UPDATE coach SET nickname = @nickname, full_name = @full_name, birthday = @birthday WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = coach.NickName;
            cmd.Parameters.Add("@full_name", MySqlDbType.VarChar).Value = coach.Name;
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

            string sql = "UPDATE coach SET isDelete = @isDelete WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = coach.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

    }
}
