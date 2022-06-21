using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryTournament : IRepositoryTournament {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryTournament() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public DataTable GetTournamentsToday() {
            DataTable data = new DataTable();
            connection.Open();

            string sql = "SELECT * FROM current_tournament;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public DataTable GetPastTournaments() {
            DataTable data = new DataTable();
            connection.Open();

            string sql = "SELECT * FROM past_tournament;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public DataTable GetFutureTournaments() {
            DataTable data = new DataTable();
            connection.Open();

            string sql = "SELECT * FROM `future_tournament`;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public DataTable TournamentsInPeriod(DateTime start, DateTime end) {
            DataTable data = new DataTable();
            connection.Open();

            string sql = "SELECT" +
	                        "`tournament_name` 	AS `Tournament`," + 
	                        "`organizer` 		AS `Organizer`," +
	                        "`start_date` 		AS `Date start`," +
	                        "`end_date` 			AS `Date end`," +
	                        "`prize_pool` 		AS `Prize pool`" +
                        "FROM `tournament_with_organizer`" + 
	                        "WHERE((`isDelete` = 0) AND(@start <= `start_date` AND `end_date` <= @end));";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("end", end);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public List<Tournament> GetAllTournament() {

            List<Tournament> list = new List<Tournament>();
            connection.Open();

            string sql = "SELECT * FROM tournament_with_organizer;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            var reader = cmd.ExecuteReader();

            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream ms;

            while (reader.Read()) {
                var tournament = new Tournament(
                    reader.GetInt32("id"),
                    reader.GetString("tournament_name"),
                    reader.GetDateTime("start_date"),
                    reader.GetDateTime("end_date"),
                    reader.GetDouble("prize_pool")
                    );
                tournament.Organizer = new Organizer(reader.GetInt32("id_organizer"), reader.GetString("organizer"));

                if (reader.GetInt32("isDelete") == 1) {
                    tournament.IsDelete = true;
                    continue;
                }

                //var col = reader.GetOrdinal("tournament_tree");

                byte[] buf = ReadBlobData(reader);
                //var len = (int)reader.GetBytes(col, 0, buf, 0, 0);
                //buf = new byte[len];
                //reader.GetBytes(6, 0, buf, 0, len);
                if (buf != null) {
                    ms = new MemoryStream(buf);
                    ms.Seek(0, SeekOrigin.Begin);
                    tournament.TournamentTree = (string)formatter.Deserialize(ms);
                } else {
                    tournament.TournamentTree = null;
                }

                list.Add(tournament);
            }

            connection.Close();
            return list;
        }

        public List<Tournament> GetTournaments(string nameOrLetterFromName) {
            List<Tournament> list = new List<Tournament>();
            connection.Open();

            string sql = "SELECT * FROM tournament_with_organizer WHERE LEFT(`tournament_name`, @n) = @name;";
            
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@n", nameOrLetterFromName.Length);
            cmd.Parameters.AddWithValue("@name", nameOrLetterFromName);

            var reader = cmd.ExecuteReader();

            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream ms;

            while (reader.Read()) {
                var tournament = new Tournament(
                    reader.GetInt32("id"),
                    reader.GetString("tournament_name"),
                    reader.GetDateTime("start_date"),
                    reader.GetDateTime("end_date"),
                    reader.GetDouble("prize_pool")
                    );
                tournament.Organizer = new Organizer(reader.GetInt32("id_organizer"), reader.GetString("organizer"));

                if (reader.GetInt32("isDelete") == 1) {
                    tournament.IsDelete = true;
                    continue;
                }

                //var col = reader.GetOrdinal("tournament_tree");

                byte[] buf = ReadBlobData(reader);
                //var len = (int)reader.GetBytes(col, 0, buf, 0, 0);
                //buf = new byte[len];
                //reader.GetBytes(6, 0, buf, 0, len);
                if (buf != null) {
                    ms = new MemoryStream(buf);
                    ms.Seek(0, SeekOrigin.Begin);
                    tournament.TournamentTree = (string)formatter.Deserialize(ms);
                } else {
                    tournament.TournamentTree = null;
                }

                list.Add(tournament);
            }

            connection.Close();
            return list;
        }

        public Tournament GetTournament(int id) {
            connection.Open();

            string sql = "SELECT * FROM tournament_with_organizer WHERE id = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            var reader = cmd.ExecuteReader();

            Tournament tournament = null;

            try {
                while (reader.Read()) {
                    tournament = new Tournament(
                        reader.GetInt32("id"),
                        reader.GetString("tournament_name"),
                        reader.GetDateTime("start_date"),
                        reader.GetDateTime("end_date"),
                        reader.GetDouble("prize_pool")
                        );
                    tournament.Organizer = new Organizer(reader.GetInt32("id_organizer"), reader.GetString("organizer"));

                    if (reader.GetInt32("isDelete") == 1) {
                        tournament.IsDelete = true;
                    }

                    BinaryFormatter formatter = new BinaryFormatter();
                    MemoryStream ms;

                    byte[] buf = ReadBlobData(reader);
                    if (buf != null) {
                        ms = new MemoryStream(buf);
                        ms.Seek(0, SeekOrigin.Begin);
                        tournament.TournamentTree = (string)formatter.Deserialize(ms);
                    } else {
                        tournament.TournamentTree = null;
                    }
                }
            } catch { }

            connection.Close();
            return tournament;
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
            cmd.Parameters.Add("@tournament_tree", MySqlDbType.Binary).Value = null;
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

            string sql = "UPDATE tournament SET organizer = @organizer, tournament_name = @tournament_name, start_date = @start_date, " +
                "end_date = @end_date, prize_pool = @prize_pool, tournament_tree = @tournament_tree WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@organizer", MySqlDbType.Int16).Value = tournament.Organizer.Id;
            cmd.Parameters.Add("@tournament_name", MySqlDbType.VarChar).Value = tournament.Name;
            cmd.Parameters.Add("@start_date", MySqlDbType.Date).Value = tournament.DateStart.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@end_date", MySqlDbType.Date).Value = tournament.DateEnd.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@prize_pool", MySqlDbType.Double).Value = tournament.PrizePool;

            if (string.IsNullOrEmpty(tournament.TournamentTree)) {
                cmd.Parameters.Add("@tournament_tree", MySqlDbType.Byte).Value = null;
            } else {
                BinaryFormatter formatter = new BinaryFormatter();
                byte[] array;

                using (MemoryStream ms = new MemoryStream()) {
                    formatter.Serialize(ms, tournament.TournamentTree);
                    array = ms.ToArray();
                }

                cmd.Parameters.Add("@tournament_tree", MySqlDbType.Binary).Value = array;
            }     
            
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = tournament.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        //public bool DeleteTournament(Tournament tournament) {
        //    connection.Open();

        //    string sql = "UPDATE tournament SET isDelete = @isDelete WHERE id = @id;";

        //    MySqlCommand cmd = new MySqlCommand(sql, connection);
        //    cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
        //    cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = tournament.Id;

        //    int res = cmd.ExecuteNonQuery();

        //    if (res != 1) {
        //        connection.Close();
        //        return false;
        //    }

        //    connection.Close();
        //    return true;
        //}

        public bool DeleteTournament(Tournament tournament) {
            connection.Open();

            string sql = "UPDATE tournament SET isDelete = @isDelete WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@isDelete", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = tournament.Id;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public string GetTournamentTree() {
            connection.Open();

            string sql = "SELECT tournament_tree FROM tournament WHERE id = @id;";

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
        public byte[] ReadBlobData(MySqlDataReader reader) {
            var colIndex = reader.GetOrdinal("tournament_tree");
            if (reader.IsDBNull(colIndex)) return null;

            // Size of the BLOB buffer.
            int bufferSize = 1024;
            // The BLOB byte[] buffer to be filled by GetBytes.
            byte[] outByte = new byte[bufferSize];
            byte[] overallOutByte = null;
            // The bytes returned from GetBytes.
            long retval;
            // The starting position in the BLOB output.
            long startIndex = 0;

            // Reset the starting byte for the new BLOB.
            startIndex = 0;

            // Read bytes into outByte[] and retain the number of bytes returned.
            retval = reader.GetBytes(colIndex, startIndex, outByte, 0, bufferSize);

            overallOutByte = new byte[bufferSize];
            outByte.CopyTo(overallOutByte, 0);

            // Continue while there are bytes beyond the size of the buffer.
            while (retval == bufferSize) {
                startIndex += bufferSize;
                retval = reader.GetBytes(colIndex, startIndex, outByte, 0, bufferSize);
                byte[] tmpArr = new byte[overallOutByte.Length];
                overallOutByte.CopyTo(tmpArr, 0);
                overallOutByte = new byte[bufferSize + tmpArr.Length];
                tmpArr.CopyTo(overallOutByte, 0);
                outByte.CopyTo(overallOutByte, tmpArr.Length);
            }

            return overallOutByte;
        }
    }

}
