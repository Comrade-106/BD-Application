using BD_Application.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.Repository.DataBaseRepository {
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

        public ContractPlayer GetActiveContract(int id_player) {
            ContractPlayer contract = null;
            connection.Open();

            string sql = "SELECT * FROM contract_player_team WHERE id_player = @id_player AND isActive = 1";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = id_player;

            var reader = cmd.ExecuteReader();

            while(reader.Read()) {
                    contract = new ContractPlayer(
                    reader.GetInt32("id_contract"),
                    reader.GetInt32("id_player"),
                    reader.GetInt32("id_team"),
                    reader.GetDateTime("date_start"),
                    reader.GetDateTime("date_end"),
                    reader.GetDouble("salary")
                    );
                if (reader.GetInt32("isMain") == 1) {
                    contract.IsMain = true;
                } else {
                    contract.IsMain = false;
                }
            }

            connection.Close();
            return contract;
        }

        public int NumberOfMainPlayerInTeam(int id_team) {
            int number = 0;
            connection.Open();

            string sql = "SELECT COUNT(id_contract) FROM contract_player_team WHERE id_team = @id_team AND isActive = 1";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = id_team;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                number++;
            }
            
            connection.Close();
            return number;
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
                    reader.GetInt32("id_contract"),
                    reader.GetInt32("id_player"),
                    reader.GetInt32("id_team"),
                    reader.GetDateTime("date_start"),
                    reader.GetDateTime("date_end"),
                    reader.GetDouble("salary")
                    );
                if (reader.GetInt32("isMain") == 0) {
                    contract.IsMain = false;
                }
                list.Add(contract);
            }

            return list;
        }

        public bool AddContractPlayer(ContractPlayer contract) {
            connection.Open();
            string sql = "INSERT INTO contract_player_team VALUES(NULL, @id_player, @id_team, @isMain, @date_start, @date_end, @salary, @isActive);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = contract.IdPlayer;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
            if (contract.IsMain) {
                cmd.Parameters.Add("@isMain", MySqlDbType.Int32).Value = 1;
            } else {
                cmd.Parameters.Add("@isMain", MySqlDbType.Int32).Value = 0;
            }
            cmd.Parameters.Add("@date_start", MySqlDbType.Date).Value = contract.DateFrom.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@date_end", MySqlDbType.Date).Value = contract.DateTo.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@salary", MySqlDbType.Double).Value = contract.Salary;
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
                "isMain = @isMain, date_start = @date_start, date_end = @date_end, salary = @salary WHERE id_contract = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdPlayerContract;
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = contract.IdPlayer;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
            if (contract.IsMain) {
                cmd.Parameters.Add("@isMain", MySqlDbType.Int32).Value = 1;
            } else {
                cmd.Parameters.Add("@isMain", MySqlDbType.Int32).Value = 0;
            }
            cmd.Parameters.Add("@date_start", MySqlDbType.Date).Value = contract.DateFrom.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@date_end", MySqlDbType.Date).Value = contract.DateTo.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("@salary", MySqlDbType.Double).Value = contract.Salary;

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteContractPlayer(ContractPlayer contract) {
            connection.Open();
            string sql = "UPDATE contract_player_team SET isActive = @isActive, date_end = @date_end WHERE id_contract = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdPlayerContract;
            cmd.Parameters.Add("@isActive", MySqlDbType.Int32).Value = 0;
            cmd.Parameters.Add("@date_end", MySqlDbType.Date).Value = DateTime.Now.ToString("yyyy-MM-dd");

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
