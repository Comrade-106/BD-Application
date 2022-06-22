using BD_Application.Domain.Forms.TournamentForms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.MatchForms {
    public partial class ChangeMatchForm : Form {
        private IRepositoryTeam teamRepository;
        private Match _match;
        private Tournament _tournament;

        public ChangeMatchForm(Match match, Tournament tournament) {
            InitializeComponent();

            teamRepository = new DBRepositoryTeam();

            _match = match;
            _tournament = tournament;
            FillData(match, tournament);
        }

        private void FillData(Match match, Tournament tournament) {
            var team1 = teamRepository.GetTeam(match.IdFirstTeam);
            var team2 = teamRepository.GetTeam(match.IdSecondTeam);

            //MessageBox.Show(match.DateTimeMatch.ToString());
            if (match.DateTimeMatch == default)
                _dateBox.Value = _dateBox.MinDate;
            else
                _dateBox.Value = match.DateTimeMatch;

            _team1Box.Text = team1?.Name ?? null;
            _team2Box.Text = team2?.Name ?? null;
            _stageBox.Text = match.MatchStage.ToString();
            _tournamentBox.Text = tournament.Name;

            if(team1 == null || team2 == null || match.DateTimeMatch == default) {
                _score1Box.ReadOnly = true;
                _score2Box.ReadOnly = true;
            }

            if (!string.IsNullOrEmpty(match.MatchResult)) {
                var score = match.MatchResult.Split(':');
                _score1Box.Text = score[0];
                _score2Box.Text = score[1];

                _dateBox.Enabled = false;
                _score1Box.ReadOnly = true;
                _score2Box.ReadOnly = true;
                _saveButton.Enabled = false;
            }
        }

        private void _saveButton_Click(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(_score1Box.Text) && string.IsNullOrEmpty(_score2Box.Text) && _match.DateTimeMatch == _dateBox.Value) return;

            if((!string.IsNullOrEmpty(_score1Box.Text) && string.IsNullOrEmpty(_score2Box.Text)) ||
                (string.IsNullOrEmpty(_score1Box.Text) && !string.IsNullOrEmpty(_score2Box.Text))) {
                MessageBox.Show("You have not filled in the Score field!");
                return;
            }
            
            if ((!string.IsNullOrEmpty(_score1Box.Text) && !Int32.TryParse(_score1Box.Text, out int r1)) ||
                (!string.IsNullOrEmpty(_score2Box.Text) && !Int32.TryParse(_score2Box.Text, out int r2))) {
                MessageBox.Show("Incorrect input in the Score field!");
                return;
            }

            if (_dateBox.Value < _tournament.DateStart || _dateBox.Value > _tournament.DateEnd) {
                MessageBox.Show("You input incorrect date!");
                return;
            }

            _match.DateTimeMatch = _dateBox.Value;


            if (!string.IsNullOrEmpty(_score1Box.Text) && !string.IsNullOrEmpty(_score2Box.Text)) {
                _match.MatchResult = _score1Box.Text + ":" + _score2Box.Text;

                var res = MessageBox.Show("Are you sure? \nThe following changes will not be removed", "Warning", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return;
            }

            if ((Owner as ViewTournament).UpdateMatch(_match))
                MessageBox.Show("Изменения успешно внесены!");
            else
                MessageBox.Show("Не удалось внести изменения");

            Hide();
        }
    }
}
