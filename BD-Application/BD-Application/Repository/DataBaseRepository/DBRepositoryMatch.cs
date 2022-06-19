using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryMatch : IRepositoryMatch {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryMatch() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Match> GetAllMatch(int id_tournament) {
            List<Match> list = new List<Match>();
            connection.Open();

            string sql = "SELECT * FROM match WHERE id_tournament = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_tournament;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Match match = new Match(
                    reader.GetInt32("id_match"),
                    reader.GetInt32("id_tournament"),
                    reader.GetDateTime("date"),
                    reader.GetInt32("first_team"),
                    reader.GetInt32("second_team"),
                    reader.GetString("result")
                    );
                list.Add(match);
            }

            connection.Close();
            return list;
        }

        public bool AddMatch(Match match) {
            connection.Open();

            string sql = "INSERT INTO `match` VALUES(@id, @id_tournament, @stage, @date, @first_team, @second_team, @result);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", match.Id);
            cmd.Parameters.AddWithValue("@id_tournament", match.TournamentID);
            cmd.Parameters.AddWithValue("@stage", match.MatchStage);
            cmd.Parameters.AddWithValue("@date", match.DateTimeMatch);
            cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);
            cmd.Parameters.AddWithValue("@second_team", match.IdSecondTeam);
            cmd.Parameters.AddWithValue("@result", match.MatchResult);

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddMatches(List<Match> matches) {
            connection.Open();

            foreach (Match match in matches) {
                string sql = "INSERT INTO `match` VALUES(@id, @id_tournament, @stage, @date, @first_team, @second_team, @result);";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", match.Id);
                cmd.Parameters.AddWithValue("@id_tournament", match.TournamentID);
                cmd.Parameters.AddWithValue("@stage", match.MatchStage);
                cmd.Parameters.AddWithValue("@date", match.DateTimeMatch);
                cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);
                cmd.Parameters.AddWithValue("@second_team", match.IdSecondTeam);
                cmd.Parameters.AddWithValue("@result", match.MatchResult);

                if (cmd.ExecuteNonQuery() != 1) {
                    connection.Close();
                    return false;
                }
            }

            connection.Close();
            return true;
        }

        public bool ChangeMatch(Match match) {
            connection.Open();

            string sql = "UPDATE match SET first_team = @first_team, second_team = @second_team, result = @result WHERE id_tournament = @id_t AND id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id_tournament", match.TournamentID);
            cmd.Parameters.AddWithValue("@id", match.Id);
            cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);
            cmd.Parameters.AddWithValue("@second_team", match.IdSecondTeam);
            cmd.Parameters.AddWithValue("@result", match.MatchResult);

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public Match GetMatch(int id, int idTournament) {
            connection.Open();

            string sql = "SELECT * FROM match WHERE id_tournament = @id_t AND id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_tournament", MySqlDbType.Int32).Value = idTournament;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            var reader = cmd.ExecuteReader();

            Match match = null;
            while (reader.Read()) {
                match.Id = reader.GetInt32("id");
                match.TournamentID = reader.GetInt32("id_tournament");
                match.DateTimeMatch = reader.GetDateTime("date");
                //match.MatchStage = reader.GetInt32("stage");
                match.IdFirstTeam = reader.GetInt32("first_team");
                match.IdSecondTeam = reader.GetInt32("second_team");
                match.MatchResult = reader.GetString("result");
            }

            connection.Close();
            return match;
        }
    }
}
