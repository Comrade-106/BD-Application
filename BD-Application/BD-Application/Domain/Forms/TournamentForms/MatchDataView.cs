using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    class MatchDataView {
        TextBox _firstTeam, _secondTeam;

        public MatchDataView(TextBox firstMatch, TextBox secondMatch) {
            _firstTeam = firstMatch;
            _secondTeam = secondMatch;
        }

        public TextBox FirstMatch { get => _firstTeam; set => _firstTeam = value; }
        public TextBox SecondMatch { get => _secondTeam; set => _secondTeam = value; }
    }
}
