using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace BD_Application.Repository.DataBaseRepository {
    public class DBRepositoryTournamentResult : IRepositoryTournamentResult {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryTournamentResult() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public bool AddTournamentResult(List<ResultTournament> list) {
            connection.Open();

            foreach (ResultTournament result in list) {
                string sql = "INSERT INTO tournament_result VALUES(NULL, @tournament, @place, @team, @prize);";

                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@tournament", result.TournamentId);
                cmd.Parameters.AddWithValue("@place", result.Place);
                cmd.Parameters.AddWithValue("@team", result.IdTeam);
                cmd.Parameters.AddWithValue("@prize", result.Prize);

                if (cmd.ExecuteNonQuery() != 1) {
                    connection.Close();
                    return false;
                }
            }

            connection.Close();
            return true;
        }

        public DataTable GetResultTournamen(int id_tournament) {
            DataTable data = new DataTable();
            connection.Open();

            string sql = "SELECT " +
                            "place          AS `Place`, " +
                            "`team`.name    AS `Team`," +
                            "prize          AS `Prize`" +
                         "FROM `tournament_result` " +
                            "INNER JOIN `team` ON team = id" +
                         " WHERE (id_tournament = @id)" +
                         " ORDER BY 1;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@id", id_tournament);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);

            connection.Close();
            return data;
        }
    }
}
