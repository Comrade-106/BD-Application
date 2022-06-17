using BD_Application.DataBase;
using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.MatchForms {
    public partial class ChangeMatchForm : Form {
        private IRepositoryTeam teamRepository;
        private IRepositoryMatch matchRepository;

        public ChangeMatchForm(Match match, Tournament tournament) {
            InitializeComponent();

            teamRepository = new DBRepositoryTeam();
            matchRepository = new DBRepositoryMatch();

            FillData(match, tournament);
        }

        private void FillData(Match match, Tournament tournament) {
            //var team1 = teamRepository.Get

            _dataBox.Value = match.DateTimeMatch;
            _team1Box.Text = match.IdFirstTeam.ToString();
            _team2Box.Text = match.IdSecondTeam.ToString();
            _stageBox.Text = "Empty";
            _tournamentBox.Text = tournament.Name;

            if (!string.IsNullOrEmpty(match.MatchResult)) {
                var score = match.MatchResult.Split(':');
                _score1Box.Text = score[0];
                _score2Box.Text = score[1];
            }
        }
    }
}
