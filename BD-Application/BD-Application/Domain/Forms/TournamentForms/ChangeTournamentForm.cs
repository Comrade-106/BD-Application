using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Domain.TournamentTree;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ChangeTournamentForm : Form {
        private List<Tournament> tournaments;
        private List<Organizer> organizers;
        private Tournament currentTournament = null;
        private List<Team> teams;
        private List<Team> selectedTeams;
        private int count;
        private int[] firstStageIndexes = new int[]{ 1, 3, 5, 7, 9, 11, 13, 15 };

        private readonly IRepositoryTournament repositoryTournanent;
        private readonly IRepositoryOrganizer repositoryOrganizer;
        private readonly IRepositoryTeam repositoryTeam;
        private readonly IRepositoryMatch matchRepository;

        public ChangeTournamentForm() {
            InitializeComponent();
            repositoryTournanent = new DBRepositoryTournament();
            repositoryOrganizer = new DBRepositoryOrganizer();
            repositoryTeam = new DBRepositoryTeam();
            matchRepository = new DBRepositoryMatch();
            selectedTeams = new List<Team>();

            if ((teams = repositoryTeam.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info about teams from DB", "Error!");
                return;
            }
        }

        private void FillTournamentBox() {
            TournamentBox.DataSource = null;
            TournamentBox.DataSource = tournaments;
            TournamentBox.DisplayMember = "name";
            TournamentBox.ValueMember = "id";
        }

        private void FillOraganizerBox() {
            OrganizerBox.DataSource = null;
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void FillTeamsBox() {
            _teamsList.DataSource = null;
            _teamsList.DataSource = teams;
            _teamsList.DisplayMember = "name";
            _teamsList.ValueMember = "id";
        }

        private void TournamentBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TournamentBox.SelectedItem != null) {
                currentTournament = (Tournament) TournamentBox.SelectedItem;

                if (currentTournament != null && (organizers = repositoryOrganizer.GetAllOrganizers()) != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTournament.Name;
                    _teamsGridView.Rows.Clear();

                    FillOraganizerBox();
                    OrganizerBox.SelectedValue = currentTournament.Organizer.Id;

                    DateStartBox.Value = currentTournament.DateStart;
                    DateEndBox.Value = currentTournament.DateEnd;
                    PrizePoolBox.Text = Convert.ToString(currentTournament.PrizePool);

                    foreach (var team in selectedTeams) {
                        teams.Add(team);
                    }
                    selectedTeams.Clear();

                    if (!string.IsNullOrEmpty(currentTournament.TournamentTree)) {
                        NameBox.ReadOnly = true;
                        OrganizerBox.Enabled = false;
                        DateStartBox.Enabled = false;
                        DateEndBox.Enabled = false;
                        PrizePoolBox.ReadOnly = true;
                        ChangeButton.Enabled = false;
                        AddTeamButton.Enabled = false;
                        RemoveButton.Enabled = false;
                        _teamsList.Enabled = false;

                        var teams = new List<Team>();
                        var matches = matchRepository.GetAllMatch(currentTournament.Id);

                        foreach (var index in firstStageIndexes) {
                            var match = matches.Find(x => x.Id == index);
                            teams.Add(repositoryTeam.GetTeam(match.IdFirstTeam));
                            teams.Add(repositoryTeam.GetTeam(match.IdSecondTeam));
                        }

                        foreach (var team in teams) {
                            _teamsGridView.Rows.Add(new object[] { team.WorldRank, team.Name });
                        }
                    } else {
                        NameBox.ReadOnly = false;
                        OrganizerBox.Enabled = true;
                        DateStartBox.Enabled = true;
                        DateEndBox.Enabled = true;
                        PrizePoolBox.ReadOnly = false;
                        ChangeButton.Enabled = true;
                        AddTeamButton.Enabled = true;
                        RemoveButton.Enabled = true;
                        _teamsList.Enabled = true;
                    }

                    FillTeamsBox();
                } else {
                    MessageBox.Show("Can`t get info about this tournament", "Error!");
                }

            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (currentTournament != null) {
                repositoryTournanent.DeleteTournament(currentTournament);
                tournaments.Remove(currentTournament);
            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            MessageBox.Show(count.ToString());
            if (currentTournament != null) {
                if (NameBox.Text != String.Empty && OrganizerBox.SelectedItem != null &&
                    DateStartBox.Value != null && DateEndBox.Value != null && PrizePoolBox.Text != String.Empty) {
                    if (double.TryParse(PrizePoolBox.Text, out double prize)) {
                        if (prize >= 0.0) {
                            if (count == 16 || count == 0) {
                                if (DateEndBox.Value > DateStartBox.Value) {
                                    currentTournament.Name = NameBox.Text;
                                    currentTournament.Organizer = organizers.Find(x => x.Id == Convert.ToInt32(OrganizerBox.SelectedValue));
                                    currentTournament.DateStart = DateStartBox.Value;
                                    currentTournament.DateEnd = DateEndBox.Value;
                                    currentTournament.PrizePool = prize;

                                    if (count == 16) {
                                        var tournamentGenerator = new TournamentGenerator(currentTournament.Id);
                                        var tree = tournamentGenerator.GenerateTournamentTree(selectedTeams.Count, selectedTeams);
                                    
                                        currentTournament.TournamentTree = BinaryTree.Serialize(tree.RootNode);
                                    }


                                    if (repositoryTournanent.ChangeTournament(currentTournament)) {
                                        MessageBox.Show("Tournament`s info changed successfull", "Message!");
                                    } else {
                                        MessageBox.Show("Tournament`s info didn`t change", "Message!");
                                    }
                                } else {
                                    MessageBox.Show("End date can`t be less than start date", "Message!");
                                }
                            } else {
                                MessageBox.Show("The number of commands in the list is not enough", "Message!");
                            }
                        } else {
                            MessageBox.Show("Prize pool can`t be less than 0", "Message!");
                        }
                    } else {
                        MessageBox.Show("Prize pool is a number with comma", "Message!");
                    }

                } else {
                    MessageBox.Show("You entered not all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void ChangeTournamentForm_Load(object sender, EventArgs e) {
            if ((tournaments = repositoryTournanent.GetAllTournament()) == null) {
                MessageBox.Show("Can`t get info about tournament", "Error!");
                return;
            }

            if ((teams = repositoryTeam.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info about teams from DB", "Error!");
                return;
            }

            FillTournamentBox();
        }

        private void AddTeamButton_Click(object sender, EventArgs e) {
            if (teams.Count == 0) return;

            count++;

            Team temp = teams.Find(x => x.Id == Convert.ToInt32(_teamsList.SelectedValue));
            selectedTeams.Add(temp);
            teams.Remove(temp);

            _teamsGridView.Rows.Add(new object[] { temp.WorldRank, temp.Name });

            _teamsList.DataSource = null;
            FillTeamsBox();

            if (count >= 16) AddTeamButton.Enabled = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            if (count <= 0) return;

            _teamsGridView.Rows.RemoveAt(_teamsGridView.RowCount - 1);
            count--;

            var temp = selectedTeams[selectedTeams.Count - 1];
            selectedTeams.Remove(temp);
            teams.Add(temp);

            AddTeamButton.Enabled = true;
            FillTeamsBox();
        }
    }
}
