using BD_Application.Domain.TournamentTree;
using System;

namespace BD_Application.Domain {
    public class Match {
        private int _id;
        private DateTime _dateTimeMatch;
        private int _idFirstTeam, _idSecondTeam;
        private Stage _matchStage;
        private string _matchResult;
        private int _tournamentID;

        public int Id { get => _id; set => _id = value; }
        public DateTime DateTimeMatch { get => _dateTimeMatch; set => _dateTimeMatch = value; }
        public int IdFirstTeam { get => _idFirstTeam; set => _idFirstTeam = value; }
        public int IdSecondTeam { get => _idSecondTeam; set => _idSecondTeam = value; }
        public string MatchResult { get => _matchResult; set => _matchResult = value; }
        public int TournamentID { get => _tournamentID; set => _tournamentID = value; }
        internal Stage MatchStage { get => _matchStage; set => _matchStage = value; }
    }
}
