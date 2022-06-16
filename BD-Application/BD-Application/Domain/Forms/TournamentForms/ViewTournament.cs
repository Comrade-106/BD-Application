using BD_Application.Domain.TournamentTree;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ViewTournament : Form {
        private Dictionary<Stage, int[]> _stages = new Dictionary<Stage, int[]> {
                { Stage.EighthFinals, new int[]{ 1, 3, 5, 7, 9, 11, 13, 15 }},
                { Stage.QuaterFinals, new int[] { 2, 6, 10, 14 } },
                { Stage.Semifinals, new int[] { 4, 12 } },
                { Stage.Final, new int[] { 8 } }
            };

        private Dictionary<int, MatchDataView> _matchesView;

        public ViewTournament(int tournamentID) {
            InitializeComponent();
            GetDataFields();
            FillForm(tournamentID);
        }

        private void GetDataFields() {
            _matchesView = new Dictionary<int, MatchDataView> {
                { 1, new MatchDataView(_match1_team1, _match1_team2) },
                { 2, new MatchDataView(_match2_team1, _match2_team2) },
                { 3, new MatchDataView(_match3_team1, _match3_team2) },
                { 4, new MatchDataView(_match4_team1, _match4_team2) },
                { 5, new MatchDataView(_match5_team1, _match5_team2) },
                { 6, new MatchDataView(_match6_team1, _match6_team2) },
                { 7, new MatchDataView(_match7_team1, _match7_team2) },
                { 8, new MatchDataView(_match8_team1, _match8_team2) },
                { 9, new MatchDataView(_match9_team1, _match9_team2) },
                { 10, new MatchDataView(_match10_team1, _match10_team2) },
                { 11, new MatchDataView(_match11_team1, _match11_team2) },
                { 12, new MatchDataView(_match12_team1, _match12_team2) },
                { 13, new MatchDataView(_match13_team1, _match13_team2) },
                { 14, new MatchDataView(_match14_team1, _match14_team2) },
                { 15, new MatchDataView(_match15_team1, _match15_team2) }
            };
        }

        private void FillForm(int id) {
                                                    //Получаем строку из базы данных
            BinaryTree tree = new BinaryTree();     //Создаем из нее дерево

            foreach (var item in _stages) {
                int i = 0; // посмотреть индексы
                foreach (var index in item.Value) {
                    var node = tree.FindNode(index);

                    //Из узла берем айди матча и находим в таблице
                    Match temp = new Match(); // = ...

                    //_matchesView[i].FirstMatch.Text = temp.IdFirstTeam; - заполняем первое поле матча
                    // второе поле матча
                    i++;
                }
            }
        }
    }
}
