using BD_Application.Domain;
using BD_Application.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BD_Application.Repository.DataBaseRepository {
    internal class DBRepositoryContractCoach : IRepositoryContractCoach {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "csgo_events";

        private readonly MySqlConnection connection = null;

        public DBRepositoryContractCoach() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public bool HaveCoachInTheTeame(int id_team) {
            connection.Open();

            string sql = "SELECT COUNT(id_contract) FROM contract_coach_team WHERE id_team = @id_team AND isActive = 1";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = id_team;

            var reader = cmd.ExecuteReader();

            if (reader.HasRows) {
                connection.Close();
                return true;
            }

            connection.Close();
            return false;
        }

        public ContractCoach GetActiveContract(int id_coach) {
            ContractCoach contract = null;
            connection.Open();

            string sql = "SELECT * FROM contract_coach_team WHERE id_coach = @id_coach AND isActive = 1";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_coach", MySqlDbType.Int32).Value = id_coach;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                contract = new ContractCoach(
                reader.GetInt32("id_contract"),
                reader.GetInt32("id_coach"),
                reader.GetInt32("id_team"),
                reader.GetDateTime("date_start"),
                reader.GetDateTime("date_end"),
                reader.GetDouble("salary")
                );
            }

            connection.Close();
            return contract;
        }

        public List<Contract> GetAllContracts(int id_coach) {
            List<Contract> list = new List<Contract>();

            connection.Open();
            string sql = "SELECT * FROM contract_coach_team WHERE id_coach = @id_coach;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_player", MySqlDbType.Int32).Value = id_coach;

            var reader = cmd.ExecuteReader();

            while (reader.Read()) {
                var contract = new ContractCoach(
                    reader.GetInt32("id"),
                    reader.GetInt32("id_coach"),
                    reader.GetInt32("id_team"),
                    reader.GetDateTime("date_start"),
                    reader.GetDateTime("date_end"),
                    reader.GetDouble("salary")
                    );
                list.Add(contract);
            }

            connection.Close();
            return list;
        }

        public bool AddContractCoach(ContractCoach contract) {
            connection.Open();
            string sql = "INSERT INTO contract_coach_team VALUES(NULL, @id_coach, @id_team, @date_start, @date_end, @salary, @isActive);";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id_coach", MySqlDbType.Int32).Value = contract.IdCoach;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
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

        public bool ChangeContractCoach(ContractCoach contract) {
            connection.Open();
            string sql = "UPDATE contract_coach_team SET id_coach = @id_coach, id_team = @id_team,  " +
                "date_start = @date_start, date_end = @date_end, salary = @salary WHERE id_contract = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdCoachContract;
            cmd.Parameters.Add("@id_coach", MySqlDbType.Int32).Value = contract.IdCoach;
            cmd.Parameters.Add("@id_team", MySqlDbType.Int32).Value = contract.IdTeam;
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

        public bool DeleteContractCoach(ContractCoach contract) {
            connection.Open();
            string sql = "UPDATE contract_coach_team SET isActive = @isActive, date_end = @date_end WHERE id_contract = @id;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = contract.IdCoachContract;
            cmd.Parameters.Add("@isActive", MySqlDbType.Int32).Value = 0;
            cmd.Parameters.Add("@date_end", MySqlDbType.DateTime).Value = DateTime.Now.ToString("yyyy-MM-dd");

            if (cmd.ExecuteNonQuery() != 1) {
                connection.Close();
                return false;
            }

            connection.Close();
            return true;
        }
    }
}
