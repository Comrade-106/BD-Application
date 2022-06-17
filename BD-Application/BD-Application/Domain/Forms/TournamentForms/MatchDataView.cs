using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    class MatchDataView {
        private TextBox _firstTeam, _secondTeam;
        private int _matchID;
        private Button _infoButton;

        public MatchDataView(TextBox firstMatch, TextBox secondMatch) {
            _firstTeam = firstMatch;
            _secondTeam = secondMatch;
        }

        public TextBox FirstMatch { get => _firstTeam; set => _firstTeam = value; }
        public TextBox SecondMatch { get => _secondTeam; set => _secondTeam = value; }
        public int MatchID { get => _matchID; set => _matchID = value; }
        public Button InfoButton { get => _infoButton; set => _infoButton = value; }
    }
}
