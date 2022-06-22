
namespace BD_Application.Domain {
    public class ResultTournament {
        private int _tournamentId;
        private string _place;
        private int _idTeam;
        private double _prize;

        public int TournamentId { get => _tournamentId; set => _tournamentId = value; }
        public string Place { get => _place; set => _place = value; }
        public double Prize { get => _prize; set => _prize = value; }
        public int IdTeam { get => _idTeam; set => _idTeam = value; }

        public override string ToString() {
            return "TournamentId: " + _tournamentId.ToString() + "; Place: " + _place + "; TeamId: " + _idTeam.ToString() + "; Prize: " + _prize.ToString();
        }
    }
}
