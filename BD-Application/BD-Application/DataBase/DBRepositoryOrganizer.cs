using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.DataBase {
    internal class DBRepositoryOrganizer : IRepositoryOrganizer {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryOrganizer() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Organizer> GetAllOrganizers() {
            List<Organizer> list = new List<Organizer>();
            connection.Open();

            string sql = "SELECT * FROM organizer;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var organizer = new Organizer(
                    reader.GetInt32("id"),
                    reader.GetString("name")
                    );
                if (reader.GetInt32("isDelete") == 1) {
                    organizer.IsDelete = true;
                }
                list.Add(organizer);
            }

            connection.Close();
            return list;
        }

        public Organizer GetOrganizer(int id) {
            connection.Open();

            string sql = "SELECT * FROM organizer WHERE id = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("id", MySqlDbType.Int16).Value = id;

            var reader = cmd.ExecuteReader();

            Organizer organizer = null;
            while (reader.Read()) {
                organizer.Id = reader.GetInt32("id");
                organizer.Name = reader.GetString("name");
                if (reader.GetInt32("isDelete") == 1) {
                    organizer.IsDelete = true;
                }
            }

            connection.Close();
            return organizer;
        }

        public bool AddOrganizer(Organizer organizer) {
            connection.Open();

            string sql = "INSERT INTO TABLE organizer VALUES(NULL, @name, @isDeleted);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
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

            MySqlCommand cmd = new MySqlCommand(sql, connection);
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

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = organizer.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
