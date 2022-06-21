using BD_Application.Domain;
using BD_Application.Domain.TournamentTree;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

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

        public DataTable GetAllMatchToday() {
            DataTable dt = new DataTable();
            connection.Open();

            string sql = "SELECT * FROM `match_today`;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            
            adapter.Fill(dt);

            connection.Close();
            return dt;
        }

        public DataTable MatchesInPeriod(DateTime start, DateTime end) {
            DataTable dt = new DataTable();
            connection.Open();

            string sql = "SELECT * FROM `match_with_team` WHERE @start <= `date` AND `date` <= @end;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("end", end);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(dt);

            connection.Close();
            return dt;
        }

        public List<Match> GetAllMatch(int id_tournament) {
            List<Match> list = new List<Match>();
            connection.Open();

            string sql = "SELECT * FROM `match` WHERE id_tournament = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id_tournament;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Match match = new Match();
                match.Id = reader.GetInt32("id_match");
                match.TournamentID = reader.GetInt32("id_tournament");
                match.DateTimeMatch = reader.GetDateTime("date");
                match.MatchStage = (Stage)reader.GetInt32("stage");

                if (reader.IsDBNull(reader.GetOrdinal("first_team")))
                    match.IdFirstTeam = -1;
                else
                    match.IdFirstTeam = reader.GetInt32("first_team");

                if (reader.IsDBNull(reader.GetOrdinal("second_team")))
                    match.IdSecondTeam = -1;
                else
                    match.IdSecondTeam = reader.GetInt32("second_team");

                if (reader.IsDBNull(reader.GetOrdinal("result")))
                    match.MatchResult = null;
                else
                    match.MatchResult = reader.GetString("result");

                //Match match = new Match(
                //    reader.GetInt32("id_match"),
                //    reader.GetInt32("id_tournament"),
                //    reader.GetDateTime("date"),
                //    reader.GetInt32("first_team"),
                //    reader.GetInt32("second_team"),
                //    reader.GetString("result")
                //    );
                list.Add(match);
            }

            connection.Close();
            return list;
        }

        public bool AddMatch(Match match) {
            connection.Open();

            string sql = "INSERT INTO `match` VALUES(NULL, @id_tournament, @stage, @date, @first_team, @second_team, @result);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_tournament", MySqlDbType.Int32).Value = match.TournamentID;
            cmd.Parameters.Add("@date", MySqlDbType.Int32).Value = match.MatchStage;
            cmd.Parameters.Add("@stage", MySqlDbType.DateTime).Value = match.DateTimeMatch;
            cmd.Parameters.Add("@first_team", MySqlDbType.Int32).Value = match.IdFirstTeam;
            cmd.Parameters.Add("@second_team", MySqlDbType.Int32).Value = match.IdSecondTeam;
            cmd.Parameters.Add("@second_team", MySqlDbType.Int32).Value = match.IdSecondTeam;
            cmd.Parameters.Add("@result", MySqlDbType.VarChar).Value = match.MatchResult;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        //public bool AddMatch(Match match) {
        //    connection.Open();

        //    string sql = "INSERT INTO match VALUES(@id, @id_tournament, @stage, @date, @first_team, @second_team, @result);";

        //    MySqlCommand cmd = new MySqlCommand(sql, connection);
        //    cmd.Parameters.AddWithValue("@id_tournament", match.Id);
        //    cmd.Parameters.AddWithValue("@id_tournament", match.TournamentID);
        //    cmd.Parameters.AddWithValue("@stage", match.MatchStage);
        //    cmd.Parameters.AddWithValue("@date", match.DateTimeMatch);
        //    cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);
        //    cmd.Parameters.AddWithValue("@second_team", match.IdSecondTeam);
        //    cmd.Parameters.AddWithValue("@result", match.MatchResult);

        //    if (cmd.ExecuteNonQuery() != 1) {
        //        connection.Close();
        //        return false;
        //    }

        //    connection.Close();
        //    return true;
        //}

        public bool AddMatches(List<Match> matches) {
            connection.Open();

            foreach (Match match in matches) {
                string sql = "INSERT INTO `match` VALUES(@id, @id_tournament, @stage, @date, @first_team, @second_team, @result);";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@id", match.Id);
                cmd.Parameters.AddWithValue("@id_tournament", match.TournamentID);
                cmd.Parameters.AddWithValue("@stage", (int)match.MatchStage);
                cmd.Parameters.AddWithValue("@date", match.DateTimeMatch);
                
                if(match.IdFirstTeam == -1)
                    cmd.Parameters.AddWithValue("@first_team", null);
                else
                    cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);

                if (match.IdSecondTeam == -1)
                    cmd.Parameters.AddWithValue("@second_team", null);
                else
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

            string sql = "UPDATE `match` SET first_team = @first_team, second_team = @second_team, result = @result, date = @date WHERE id_tournament = @id_t AND id_match = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id_t", match.TournamentID);
            cmd.Parameters.AddWithValue("@id", match.Id);
            cmd.Parameters.AddWithValue("@date", match.DateTimeMatch);

            if (match.IdFirstTeam == -1)
                cmd.Parameters.AddWithValue("@first_team", null);
            else
                cmd.Parameters.AddWithValue("@first_team", match.IdFirstTeam);

            if (match.IdSecondTeam == -1)
                cmd.Parameters.AddWithValue("@second_team", null);
            else
                cmd.Parameters.AddWithValue("@second_team", match.IdSecondTeam);

            cmd.Parameters.AddWithValue("@result", match.MatchResult);

            var res = cmd.ExecuteNonQuery();

            if (res != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public Match GetMatch(int id, int idTournament) {
            connection.Open();

            string sql = "SELECT * FROM `match` WHERE id_tournament = @id_t AND id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_tournament", MySqlDbType.Int32).Value = idTournament;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            var reader = cmd.ExecuteReader();

            Match match = null;
            while (reader.Read()) {
                match.Id = reader.GetInt32("id");
                match.TournamentID = reader.GetInt32("id_tournament");
                match.DateTimeMatch = reader.GetDateTime("date");
                match.MatchStage = (Stage)reader.GetInt32("stage");
                match.IdFirstTeam = reader.GetInt32("first_team");
                match.IdSecondTeam = reader.GetInt32("second_team");
                match.MatchResult = reader.GetString("result");
            }

            connection.Close();
            return match;
        }
    }
}
