using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryStage : IRepositoryStage {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryStage() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public Stage1 GetStage(int id) {
            connection.Open();

            string sql = "SELECT name FROM stage WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            var reader = cmd.ExecuteReader();

            Stage1 stage = null;
            while (reader.Read()) {
                stage.Id = id;
                stage.StageName = reader.GetString(0);
            }
            return stage;
        }

        public Stage1 GetStage(string name) {
            connection.Open();

            string sql = "SELECT id FROM stage WHERE stage = @name;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@name", MySqlDbType.Int32).Value = name;

            var reader = cmd.ExecuteReader();

            Stage1 stage = null;
            while (reader.Read()) {
                stage.Id = reader.GetInt32(0);
                stage.StageName = name;
            }
            return stage;
        }
    }
}
