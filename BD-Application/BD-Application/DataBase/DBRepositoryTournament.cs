using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.DataBase {
    internal class DBRepositoryTournament : IRepositoryTournanent {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly DBRepositoryOrganizer organizerRepository = new DBRepositoryOrganizer();

        private readonly MySqlConnection connection = null;

        public DBRepositoryTournament() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Tournament> GetAllTournament() {

            List<Tournament> list = new List<Tournament>();
            connection.Open();

            string sql = "SELECT * FROM tournament;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var tournament = new Tournament(
                    reader.GetInt32("id"),
                    reader.GetString("tournament_name"),
                    reader.GetString("location"),
                    reader.GetDateTime("start_date"),
                    reader.GetDateTime("end_date"),
                    reader.GetDouble("prize_pool")
                    );

                tournament.Organizer = organizerRepository.GetOrganizer(reader.GetInt32("organizer"));

                if (reader.GetInt32("isDelete") == 1) {
                    tournament.IsDelete = true;
                }
                list.Add(tournament);
            }

            connection.Close();
            return list;
        }

        public bool AddTournament(Tournament tournament) {
            connection.Open();

            string sql = "INSERT INTO tournament VALUES (NULL, @organizer, @name_tournament, @start_date, @end_date, @prize_pool, @tournament_tree, @isDelete);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
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

            MySqlCommand cmd = new MySqlCommand(sql, connection);
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

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public string GetTournamentTree() {
            connection.Open();

            string sql = "SELECT tournament_tree FROM tournament WHERE id = @id);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = 0;

            var reader = cmd.ExecuteReader();

            if (reader.Read()) {
                connection.Close();
                return reader.GetString(0);
            }

            connection.Close();
            return null;
        }
    }
}
