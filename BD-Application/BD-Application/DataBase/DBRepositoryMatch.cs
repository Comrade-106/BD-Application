using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_Application.Domain;
using MySql.Data.MySqlClient;

namespace BD_Application.DataBase {
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

        public bool AddMatch(Match match) {
            connection.Open();

            string sql = "INSERT INTO match VALUES(NULL, @id_tournament, @stage, @first_team, @second_team, @result);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_tournament", MySqlDbType.Int32).Value = match.TournamentID;
            cmd.Parameters.Add("@stage", MySqlDbType.Int32).Value = ((int)match.MatchStage);       ///???????
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

        public bool ChangeMatch(Match match) {
            connection.Open();

            string sql = "UPDATE match SET result = @result WHERE id_tournament = @id_t AND id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_tournament", MySqlDbType.Int32).Value = match.TournamentID;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = match.Id;
            cmd.Parameters.Add("@result", MySqlDbType.VarChar).Value = match.MatchResult;

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
