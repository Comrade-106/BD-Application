using MySql.Data.MySqlClient;
using System;
using BD_Application.Domain;

namespace BD_Application.DataBase {
    class DBRepository {
        private readonly string serverName = "localhost";
        private readonly int port = 3306;
        private readonly string userName = "root";
        private readonly string password = "root";
        private readonly string dataBase = "gsgo_events";

        private MySqlConnection connection = null;

        public DBRepository() {
            string connectionInfo = "server=" + serverName + ";port=" + port + ";username=" + userName + ";password=" + password + ";database=" + dataBase;

            if ((connection = new MySqlConnection(connectionInfo)) == null) {
                throw new Exception("Can`t set connection with server");
            }
        }

        public bool AddPlayer(Player player) {

            return true;
        }

        public bool ChangePlayer(Player player) {

            return true;
        }

        public bool DeletePlayer(Player player) {

            return true;
        }

        public bool AddCoach(Coach coach) {

            return true;
        }

        public bool ChangeCoach(Coach coach) {

            return true;
        }

        public bool DeleteCoach(Coach coach) {

            return true;
        }

        public bool AddTeam(Team team) {

            return true;
        }

        public bool ChangeTeam(Team team) {

            return true;
        }

        public bool DeleteTeam(Team team) {

            return true;
        }

        public bool AddOrganizer(Organizer organizer) {

            return true;
        }

        public bool ChangeOrganizer(Organizer organizer) {

            return true;
        }

        public bool DeleteOrganizer(Organizer organizer) {

            return true;
        }

        public bool AddTournament(Tournament tournament) {

            return true;
        }

        public bool ChangeTournament(Tournament tournament) {

            return true;
        }

        public bool DeleteTournament(Tournament tournament) {

            return true;
        }
    }
}
