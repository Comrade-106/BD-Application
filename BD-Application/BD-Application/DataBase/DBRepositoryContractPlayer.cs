using System;
using MySql.Data.MySqlClient;
using BD_Application.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Application.DataBase {
    internal class DBRepositoryContractPlayer : IRepositoryContractPlayer {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryContractPlayer() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public List<Contract> GetAllContracts(int id_player) {
            List<Contract> list = new List<Contract>();

            connection.Open();
            string sql = "SELECT * FROM contract_player_team WHERE id_player = @id_player;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = id_player;
            
            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var contract = new ContractPlayer(
                    reader.GetInt32("id"),
                    reader.GetInt32("id_player"),
                    reader.GetInt32("id_team"),
                    reader.GetDateTime("date_start"),
                    reader.GetDateTime("date_end"),
                    reader.GetDouble("salary")
                    );
                list.Add(contract);
            }

            return list;
        }

        public bool AddContractPlayer(ContractPlayer contract) {
            connection.Open();
            string sql = "INSERT INTO contract_player_team VALUES(NULL, @id_player, @id_team, @date_start, @date_end, @isActive);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = contract.IdPlayer;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
            cmd.Parameters.Add("@date_start", MySqlDbType.Date).Value = contract.DateFrom.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@date_end", MySqlDbType.Date).Value = contract.DateTo.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@isActive", MySqlDbType.Int32).Value = 1;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool ChangeContractPlayer(ContractPlayer contract) {
            connection.Open();
            string sql = "UPDATE contract_player_team SET id_player = @id_player, id_team = @id_team,  " +
                "date_start = @date_start, date_end = @date_end WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdPlayerContract;
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = contract.IdPlayer;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
            cmd.Parameters.Add("@date_start", MySqlDbType.Date).Value = contract.DateFrom.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@date_end", MySqlDbType.Date).Value = contract.DateTo.ToString("yyyy-MM-dd");

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteContractPlayer(ContractPlayer contract) {
            connection.Open();
            string sql = "UPDATE contract_player_team SET isActive = @isActive WHERE id = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdPlayerContract;
            cmd.Parameters.Add("@isActive", MySqlDbType.Int32).Value = 0;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
