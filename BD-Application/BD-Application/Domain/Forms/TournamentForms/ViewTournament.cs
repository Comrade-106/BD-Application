using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using BD_Application.Domain.TournamentTree;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Domain.Forms.MatchForms;
using System.Drawing;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ViewTournament : Form {
        private Dictionary<Stage, int[]> _stages = new Dictionary<Stage, int[]> {
                { Stage.EighthFinals, new int[]{ 1, 3, 5, 7, 9, 11, 13, 15 }},
                { Stage.QuaterFinals, new int[] { 2, 6, 10, 14 } },
                { Stage.Semifinals, new int[] { 4, 12 } },
                { Stage.Final, new int[] { 8 } }
            };

        private Dictionary<int, MatchDataView> _matchesView;
        private List<Match> _matches;
        private Tournament _tournament;
        private int _tournamentID;

        private IRepositoryMatch matchRepository;
        private IRepositoryTournanent tournamentRepository;
        private IRepositoryTeam teamRepository;

        public ViewTournament(int tournamentID) {
            InitializeComponent();
            GetDataFields();

            matchRepository = new DBRepositoryMatch();
            tournamentRepository = new DBRepositoryTournament();
            teamRepository = new DBRepositoryTeam();

            _matches = matchRepository.GetAllMatch(tournamentID);
            _tournament = tournamentRepository.GetTournament(tournamentID);

            _tournamentID = tournamentID;
            FillForm(tournamentID);
        }

        private void GetDataFields() {
            _matchesView = new Dictionary<int, MatchDataView> {
                { 1, new MatchDataView(_match1_team1, _match1_team2){ InfoButton = _match1InfoButton } },
                { 2, new MatchDataView(_match2_team1, _match2_team2){ InfoButton = _match2InfoButton } },
                { 3, new MatchDataView(_match3_team1, _match3_team2){ InfoButton = _match3InfoButton } },
                { 4, new MatchDataView(_match4_team1, _match4_team2){ InfoButton = _match4InfoButton } },
                { 5, new MatchDataView(_match5_team1, _match5_team2){ InfoButton = _match5InfoButton } },
                { 6, new MatchDataView(_match6_team1, _match6_team2){ InfoButton = _match6InfoButton } },
                { 7, new MatchDataView(_match7_team1, _match7_team2){ InfoButton = _match7InfoButton } },
                { 8, new MatchDataView(_match8_team1, _match8_team2){ InfoButton = _match8InfoButton } },
                { 9, new MatchDataView(_match9_team1, _match9_team2){ InfoButton = _match9InfoButton } },
                { 10, new MatchDataView(_match10_team1, _match10_team2){ InfoButton = _match10InfoButton } },
                { 11, new MatchDataView(_match11_team1, _match11_team2){ InfoButton = _match11InfoButton } },
                { 12, new MatchDataView(_match12_team1, _match12_team2){ InfoButton = _match12InfoButton } },
                { 13, new MatchDataView(_match13_team1, _match13_team2){ InfoButton = _match13InfoButton } },
                { 14, new MatchDataView(_match14_team1, _match14_team2){ InfoButton = _match14InfoButton } },
                { 15, new MatchDataView(_match15_team1, _match15_team2){ InfoButton = _match15InfoButton } }
            };
        }

        private void FillForm(int id) {
            var tree = BinaryTree.Deserialize(_tournament.TournamentTree);
            int i = 1; // посмотреть индексы

            foreach (var item in _stages) {
                foreach (var index in item.Value) {

                    Match temp = _matches.Find(x => x.Id == index);

                    _matchesView[i].MatchID = temp.Id;

                    if (temp.IdFirstTeam != -1)
                        _matchesView[i].FirstTeam.Text = teamRepository.GetTeam(temp.IdFirstTeam).Name;

                    if (temp.IdSecondTeam != -1)
                        _matchesView[i].SecondTeam.Text = teamRepository.GetTeam(temp.IdSecondTeam).Name;

                    if (IsMatchComplited(temp, out int winner)) {
                        if(winner == temp.IdFirstTeam) {
                            _matchesView[i].SecondTeam.BackColor = SystemColors.ControlDark;
                        } else {
                            _matchesView[i].FirstTeam.BackColor = SystemColors.ControlDark;
                        }
                    }
                    
                    i++;
                }
            }
        }

        private bool IsMatchComplited(Match match, out int winner) {
            winner = -1;
            if (!string.IsNullOrEmpty(match.MatchResult)) {
                if(DefineWinner(match.MatchResult) == 1) {
                    winner = match.IdFirstTeam;
                } else {
                    winner = match.IdSecondTeam;
                }

                return true;
            }

            return false;
        }

        private int DefineWinner(string matchResult) {
            var res = matchResult.Split(':');

            if (Convert.ToInt32(res[0]) > Convert.ToInt32(res[1])) {
                return 1;
            } else {
                return 2;
            }
        }

        private void OnShowMatchButtonClick(object sender, EventArgs e) {
            var button = sender as Button;

            foreach (var item in _matchesView) {
                if (item.Value.InfoButton.Equals(button)) {
                    var match = _matches.Find(x => x.Id == item.Value.MatchID);
                    
                    var form = new ChangeMatchForm(match, _tournament);
                    form.Owner = this;
                    form.ShowDialog();

                    FillForm(_tournamentID);

                    break;
                }
            }
        }

        public bool UpdateMatch(Match match) {
            var tree = BinaryTree.Deserialize(_tournament.TournamentTree);

            var temp = tree.FindNode(match.Id);

            //MessageBox.Show("\nNode: " + temp.Data + "\nParent: " + (temp.ParentNode == null).ToString() + "\nParent Data: " + temp.ParentNode?.Data);

            var nextMatchNode = tree.FindNode(match.Id).ParentNode;

            if(nextMatchNode == null) {


                return true;
            }

            var nextMatch = _matches.Find(x => x.Id == nextMatchNode.Data);

            if (!string.IsNullOrEmpty(match.MatchResult)) {
                int winnerId;
                if (DefineWinner(match.MatchResult) == 1)
                    winnerId = match.IdFirstTeam;
                else
                    winnerId = match.IdSecondTeam;               

                if (nextMatch.IdFirstTeam == -1)
                    nextMatch.IdFirstTeam = winnerId;
                else
                    nextMatch.IdSecondTeam = winnerId;
            }

            return matchRepository.ChangeMatch(match) && matchRepository.ChangeMatch(nextMatch);
        }
    }
}
