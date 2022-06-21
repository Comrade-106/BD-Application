using BD_Application.Domain.Forms.CoachForms;
using BD_Application.Domain.Forms.OrganizerForms;
using BD_Application.Domain.Forms.PlayerForms;
using BD_Application.Domain.Forms.TeamForms;
using BD_Application.Domain.Forms.TournamentForms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BD_Application.Domain.Forms {
    public partial class MainMenu : Form {
        private List<Player> players;
        private List<Coach> coaches;
        private List<Team> teams;
        private List<Organizer> organizers;
        private List<Tournament> tournaments;

        private readonly IRepositoryPlayer repositoryPlayer;
        private readonly IRepositoryContractPlayer contractPlayer;

        private readonly IRepositoryCoach repositoryCoach;
        private readonly IRepositoryContractCoach contractCoach;

        private readonly IRepositoryTeam repositoryTeam;
        private readonly IRepositoryOrganizer repositoryOrganizer;

        private readonly IRepositoryTournament repositoryTournament;
        private readonly IRepositoryMatch repositoryMatch;

        public MainMenu() {
            InitializeComponent();
            repositoryPlayer = new DBRepositoryPlayer();
            contractPlayer = new DBRepositoryContractPlayer();

            repositoryCoach = new DBRepositoryCoach();
            contractCoach = new DBRepositoryContractCoach();

            repositoryTeam = new DBRepositoryTeam();

            repositoryOrganizer = new DBRepositoryOrganizer();

            repositoryTournament = new DBRepositoryTournament();
            repositoryMatch = new DBRepositoryMatch();
        }

        private bool LoadData() {
            players = repositoryPlayer.GetAllPlayers();
            coaches = repositoryCoach.GetAllCoaches();
            teams = repositoryTeam.GetAllTeams();
            organizers = repositoryOrganizer.GetAllOrganizers();
            tournaments = repositoryTournament.GetAllTournament();

            if (players == null || coaches == null || teams == null || organizers == null || tournaments == null) {
                return false;
            }

            return true;
        }

        private void MainMenu_Load(object sender, EventArgs e) {
            if (!LoadData()) {
                MessageBox.Show("Can`t get info from repository", "Message!");
            }

            FillPlayerBox();
            PanelPlayer.Visible = false;
            PlayerInfo.Visible = false;
            PlayersTable.Visible = false;
        }

        private void Tabs_TabIndexChanged(object sender, EventArgs e) {
            switch (Tabs.SelectedIndex) {
                case 0:
                    if ((players = repositoryPlayer.GetAllPlayers()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Message!");
                    }
                    FillPlayerBox();
                    PanelPlayer.Visible = false;
                    PlayerInfo.Visible = false;
                    PlayersTable.Visible = false;
                    break;
                case 1:
                    if ((coaches = repositoryCoach.GetAllCoaches()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Message!");
                    }
                    FillCoachBox();
                    CoachInfoPanel.Visible = false;
                    CoachInfoLabel.Visible = false;
                    CoachesTable.Visible = false;
                    break;
                case 2:
                    if ((teams = repositoryTeam.GetAllTeams()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Message!");
                    }
                    FillTeamBox();
                    TeamInfoPanel.Visible = false;
                    TeamInfoLabel.Visible = false;
                    TeamInfoTable.Visible = false;
                    break;
                case 3:
                    if ((organizers = repositoryOrganizer.GetAllOrganizers()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Message!");
                    }
                    FillOrganizerBox();
                    OrganizerInfoPanel.Visible = false;
                    OrganizerInfoLabel.Visible = false;
                    OrganizerInfoTable.Visible = false;
                    break;
                case 4:
                    if ((tournaments = repositoryTournament.GetAllTournament()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Message!");
                    }
                    FillTournamentBox();
                    TournamentInfoPanel.Visible = false;
                    TournamentInfoLabel.Visible = false;
                    TournamentInfoTable.Visible = false;
                    break;
                default: return;
            }
        }

        private void FillPlayerBox() {
            PlayerBox.DataSource = null;
            PlayerBox.DataSource = players;
            PlayerBox.DisplayMember = "nickname";
            PlayerBox.ValueMember = "id";
        }

        private void FillCoachBox() {
            CoachBox.DataSource = null;
            CoachBox.DataSource = coaches;
            CoachBox.DisplayMember = "nickname";
            CoachBox.ValueMember = "id";
        }

        private void FillTeamBox() {
            TeamBox.DataSource = null;
            TeamBox.DataSource = teams;
            TeamBox.DisplayMember = "name";
            TeamBox.ValueMember = "id";
        }

        private void FillOrganizerBox() {
            OrganizerBox.DataSource = null;
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void FillTournamentBox() {
            TournamentBox.DataSource = null;
            TournamentBox.DataSource = tournaments;
            TournamentBox.DisplayMember = "name";
            TournamentBox.ValueMember = "id";
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            AddPlayerForm form = new AddPlayerForm();
            form.ShowDialog();
        }

        private void AddCoachButton_Click(object sender, EventArgs e) {
            AddCoachForm form = new AddCoachForm();
            form.ShowDialog();
        }

        private void AddTeamButton_Click(object sender, EventArgs e) {
            AddTeamForm form = new AddTeamForm();
            form.ShowDialog();
        }

        private void AddOrganizerButton_Click(object sender, EventArgs e) {
            AddOrganizerForm form = new AddOrganizerForm();
            form.ShowDialog();
        }

        private void AddTournamentButton_Click(object sender, EventArgs e) {
            //Call add Tournament form
            var form = new AddTournamentForm();
            form.ShowDialog();
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (PlayerBox.SelectedItem is Player player) {
                ChangePlayerForm form = new ChangePlayerForm(player, repositoryPlayer, contractPlayer);
                form.ShowDialog();
                if ((players = repositoryPlayer.GetAllPlayers()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
                FillPlayerBox();
                PlayerBox.SelectedItem = player;
            } else {
                MessageBox.Show("You didn`t choice a player", "Message");
            }
        }

        private void ChangeCoachButton_Click(object sender, EventArgs e) {
            if (CoachBox.SelectedItem is Coach coach) {
                ChangeCoachForm form = new ChangeCoachForm(coach, repositoryCoach, contractCoach);
                form.ShowDialog();
                if ((coaches = repositoryCoach.GetAllCoaches()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
                FillCoachBox();
                CoachBox.SelectedItem = coach;
            }
        }

        private void ChangeTeamButton_Click(object sender, EventArgs e) {
            if (TeamBox.SelectedItem is Team team) {
                ChangeTeamForm form = new ChangeTeamForm(team, repositoryTeam, contractPlayer, contractCoach);
                form.ShowDialog();
                if ((teams = repositoryTeam.GetAllTeams()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
                FillTeamBox();
                TeamBox.SelectedItem = team;
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (OrganizerBox.SelectedItem is Organizer organizer) {
                ChangeOrganizerForm form = new ChangeOrganizerForm(organizer, repositoryOrganizer);
                form.ShowDialog();
                if ((organizers = repositoryOrganizer.GetAllOrganizers()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
                FillOrganizerBox();
                OrganizerBox.SelectedItem = organizer;
            }
        }

        private void ChangeTournamentBox_Click(object sender, EventArgs e) {
            //Call change tournament form with parameter Tournament and repository tournament
            if(TournamentBox.SelectedItem is Tournament tournament) {
                var form = new ChangeTournamentForm(repositoryTournament, repositoryOrganizer, repositoryTeam, repositoryMatch);
                form.ShowDialog();
                if((tournaments = repositoryTournament.GetAllTournament()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
                FillTournamentBox();
                TournamentBox.SelectedItem = tournament;
            }
        }

        private void ViewPlayerButton_Click(object sender, EventArgs e) {
            if (PlayerBox.SelectedItem != null) {
                if (PlayerBox.SelectedItem is Player player) {

                    PanelPlayer.Visible = true;
                    PlayersTable.Visible = false;

                    PlayerInfo.Text =
                        "Nickname: " + player.NickName +
                        "\nName: " + player.Name +
                        "\nBirthday: " + player.BirthDay +
                        "\nTeam: ";
                    ContractPlayer contract;
                    if ((contract = contractPlayer.GetActiveContract(player.Id)) != null) {
                        Team team;
                        if ((team = repositoryTeam.GetTeam(contract.IdTeam)) != null) {
                            PlayerInfo.Text += team.Name;
                        }
                    }
                    PlayerInfo.Visible = true;

                }
            } else {
                MessageBox.Show("Message!");
            }
        }

        private void ViewCoachButton_Click(object sender, EventArgs e) {
            if (CoachBox.SelectedItem is Coach coach) {

                CoachInfoPanel.Visible = true;
                CoachesTable.Visible = false;

                CoachInfoLabel.Text =
                    "Nickname: " + coach.NickName +
                    "\nName: " + coach.Name +
                    "\nBirthday: " + coach.BirthDay +
                    "\nTeam: ";
                ContractCoach contract;
                if ((contract = contractCoach.GetActiveContractByCoach(coach.Id)) != null) {
                    Team team;
                    if ((team = repositoryTeam.GetTeam(contract.IdTeam)) != null) {
                        CoachInfoLabel.Text += team.Name;
                    }
                }
            }
        }

        private void ViewTeamInfo_Click(object sender, EventArgs e) {
            if (TeamBox.SelectedItem is Team team) {

                TeamInfoPanel.Visible = true;
                TeamInfoLabel.Visible = true;
                TeamInfoTable.Visible = false;

                TeamInfoLabel.Text =
                    "Name: " + team.Name +
                    "\nWorld rank: " + team.WorldRank;
                ContractCoach coachContract;
                if ((coachContract = contractCoach.GetActiveContractByTeam(team.Id)) != null) {
                    Coach coach;
                    if ((coach = repositoryCoach.GetCoache(coachContract.IdCoach)) != null) {
                        TeamInfoLabel.Text += "\nCoach: " + coach.NickName + " (" + coach.Name + ")";
                    }
                }

                List<ContractPlayer> playersContract;
                if ((playersContract = contractPlayer.GetPlayersByTeam(team.Id)) != null) {
                    string mainP = "\n  Main: ";
                    string reserveP = "\n  Reserve: ";
                    foreach (ContractPlayer c in playersContract) {
                        var player = repositoryPlayer.GetPlayerById(c.IdPlayer);
                        if (player != null) {
                            if (c.IsMain) {
                                mainP += player.NickName + "; ";
                            } else {
                                reserveP += player.NickName + "; ";
                            }
                        }
                    }
                    TeamInfoLabel.Text += "\nPlayers: " + mainP + reserveP;
                }

            }
        }

        private void ViewOrganizerButton_Click(object sender, EventArgs e) {
            if (OrganizerBox.SelectedItem is Organizer organizer) {

                OrganizerInfoPanel.Visible = true;
                OrganizerInfoLabel.Visible = true;
                OrganizerInfoTable.Visible = false;

                OrganizerInfoLabel.Text =
                    "Name: " + organizer.Name;
            }
        }

        private void ViewTournamentButton_Click(object sender, EventArgs e) {
            if (TournamentBox.SelectedItem is Tournament tournament) {

                TournamentInfoPanel.Visible = true;
                TournamentInfoLabel.Visible = true;
                TournamentInfoTable.Visible = false;

                TournamentInfoLabel.Text =
                    "Name: " + tournament.Name +
                    "\nOrganizer: " + tournament.Organizer.Name +
                    "\nTime period: " + tournament.DateStart.ToString("yyyy-MM-dd") + " - " + tournament.DateEnd.ToString("yyyy-MM-dd") +
                    "\nPrize pool: " + tournament.PrizePool;

                var form = new ViewTournament(tournament.Id, repositoryMatch, repositoryTournament, repositoryTeam);
                form.ShowDialog();
            }
        }

        private void ViewAllPlayerButton_Click(object sender, EventArgs e) {
            PanelPlayer.Visible = true;
            PlayerInfo.Visible = false;
            PlayersTable.Visible = true;

            PlayersTable.Rows.Clear();

            List<Player> list;
            if (FilterPlayerBox.Text == "Enter player nickname to filter info") {
                list = players;
            } else {
                if ((list = repositoryPlayer.GetPlayers(FilterPlayerBox.Text)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
            }

            for (int i = 0; i < list.Count; i++) {
                PlayersTable.Rows.Add();

                PlayersTable.Rows[i].Cells[0].Value = list[i].NickName;
                PlayersTable.Rows[i].Cells[1].Value = list[i].Name;
                PlayersTable.Rows[i].Cells[2].Value = list[i].BirthDay.ToString("yyyy-MM-dd");

                ContractPlayer contract;
                if ((contract = contractPlayer.GetActiveContract(list[i].Id)) != null) {
                    Team team;
                    if ((team = repositoryTeam.GetTeam(contract.IdTeam)) != null) {
                        PlayersTable.Rows[i].Cells[3].Value = team.Name;
                    } else {
                        PlayersTable.Rows[i].Cells[3].Value = String.Empty;
                    }
                } else {
                    PlayersTable.Rows[i].Cells[3].Value = String.Empty;
                }
            }
        }


        private void ViewAllCoachButon_Click(object sender, EventArgs e) {
            CoachInfoPanel.Visible = true;
            CoachInfoLabel.Visible = false;
            CoachesTable.Visible = true;

            CoachesTable.Rows.Clear();

            List<Coach> list;
            if (FilterCoachBox.Text == "Enter coach nickname to filter info") {
                list = coaches;
            } else {
                if ((list = repositoryCoach.GetCoaches(FilterCoachBox.Text)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
            }

            for (int i = 0; i < list.Count; i++) {
                CoachesTable.Rows.Add();

                CoachesTable.Rows[i].Cells[0].Value = list[i].NickName;
                CoachesTable.Rows[i].Cells[1].Value = list[i].Name;
                CoachesTable.Rows[i].Cells[2].Value = list[i].BirthDay;

                ContractCoach contract;
                if ((contract = contractCoach.GetActiveContractByCoach(list[i].Id)) != null) {
                    Team team;
                    if ((team = repositoryTeam.GetTeam(contract.IdTeam)) != null) {
                        CoachesTable.Rows[i].Cells[3].Value = team.Name;
                    }
                }
            }
        }

        private void ViewTeamsButton_Click(object sender, EventArgs e) {
            TeamInfoPanel.Visible = true;
            TeamInfoLabel.Visible = false;
            TeamInfoTable.Visible = true;

            TeamInfoTable.Rows.Clear();

            List<Team> list;
            if (FilterTeamBox.Text == "Enter team`s name to filter info") {
                list = teams;
            } else {
                if ((list = repositoryTeam.GetTeams(FilterTeamBox.Text)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
            }

            for (int i = 0; i < list.Count; i++) {
                TeamInfoTable.Rows.Add();
                TeamInfoTable.Rows[i].Cells[0].Value = list[i].Name;
                TeamInfoTable.Rows[i].Cells[1].Value = list[i].WorldRank;

                ContractCoach coachContract;
                if ((coachContract = contractCoach.GetActiveContractByTeam(list[i].Id)) != null) {
                    Coach coach;
                    if ((coach = repositoryCoach.GetCoache(coachContract.IdCoach)) != null) {
                        TeamInfoTable.Rows[i].Cells[2].Value = coach.NickName + " (" + coach.Name + ")";
                    }
                }

                List<ContractPlayer> playersContract;
                if ((playersContract = contractPlayer.GetPlayersByTeam(list[i].Id)) != null) {
                    string mainP = "\n  Main: ";
                    string reserveP = "\n  Reserve: ";
                    foreach (ContractPlayer c in playersContract) {
                        var player = repositoryPlayer.GetPlayerById(c.IdPlayer);
                        if (player != null) {
                            if (c.IsMain) {
                                mainP += player.NickName + "; ";
                            } else {
                                reserveP += player.NickName + "; ";
                            }
                        }
                    }
                    TeamInfoTable.Rows[i].Cells[3].Value = mainP + reserveP;
                }
            }
        }

        private void ViewOrganizersButton_Click(object sender, EventArgs e) {
            OrganizerInfoPanel.Visible = true;
            OrganizerInfoLabel.Visible = false;
            OrganizerInfoTable.Visible = true;

            OrganizerInfoTable.Rows.Clear();

            List<Organizer> list;
            if (FilterOrganizerBox.Text == "Enter organizer name to filter info") {
                list = organizers;
            } else {
                if ((list = repositoryOrganizer.GetOrganizers(FilterOrganizerBox.Text)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
            }

            for (int i = 0; i < list.Count; i++) {
                OrganizerInfoTable.Rows.Add();
                OrganizerInfoTable.Rows[i].Cells[0].Value = list[i].Name;
            }

        }

        private void ViewTournamentsButton_Click(object sender, EventArgs e) {
            TournamentInfoPanel.Visible = true;
            TournamentInfoLabel.Visible = false;
            TournamentInfoTable.Visible = true;

            TournamentInfoTable.Rows.Clear();

            List<Tournament> list;
            if (FilterTournamentBox.Text == "Enter tournament`s name to filter info") {
                list = tournaments;
            } else {
                if ((list = repositoryTournament.GetTournaments(FilterTournamentBox.Text)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Message!");
                }
            }

            for (int i = 0; i < list.Count; i++) {
                TournamentInfoTable.Rows.Add();

                TournamentInfoTable.Rows[i].Cells[0].Value = list[i].Name;
                TournamentInfoTable.Rows[i].Cells[1].Value = list[i].Organizer.Name;
                TournamentInfoTable.Rows[i].Cells[2].Value = list[i].DateStart.ToString("yyyy-MM-dd") + " - " + list[i].DateEnd.ToString("yyyy-MM-dd");
                TournamentInfoTable.Rows[i].Cells[3].Value = list[i].PrizePool;
            }
        }

        private void FilterPlayerBox_Click(object sender, EventArgs e) {
            FilterPlayerBox.Text = String.Empty;
            FilterPlayerBox.ForeColor = System.Drawing.Color.Black;
        }

        private void FilterPlayerBox_Leave(object sender, EventArgs e) {
            if (FilterPlayerBox.Text == String.Empty) {
                FilterPlayerBox.Text = "Enter player nickname to filter info";
                FilterPlayerBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void FilterCoachBox_Click(object sender, EventArgs e) {
            FilterCoachBox.Text = String.Empty;
            FilterCoachBox.ForeColor = System.Drawing.Color.Black;
        }

        private void FilterCoachBox_Leave(object sender, EventArgs e) {
            if (FilterCoachBox.Text == String.Empty) {
                FilterCoachBox.Text = "Enter coach nickname to filter info";
                FilterCoachBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void FilterTeamBox_Click(object sender, EventArgs e) {
            FilterTeamBox.Text = String.Empty;
            FilterTeamBox.ForeColor = System.Drawing.Color.Black;
        }

        private void FilterTeamBox_Leave(object sender, EventArgs e) {
            if (FilterTeamBox.Text == String.Empty) {
                FilterTeamBox.Text = "Enter team`s name to filter info";
                FilterTeamBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void FilterOrganizerBox_Click(object sender, EventArgs e) {
            FilterOrganizerBox.Text = String.Empty;
            FilterOrganizerBox.ForeColor = System.Drawing.Color.Black;
        }

        private void FilterOrganizerBox_Leave(object sender, EventArgs e) {
            if (FilterOrganizerBox.Text == String.Empty) {
                FilterOrganizerBox.Text = "Enter organizer name to filter info";
                FilterOrganizerBox.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void FilterTournamentBox_Click(object sender, EventArgs e) {
            FilterTournamentBox.Text = String.Empty;
            FilterTournamentBox.ForeColor = System.Drawing.Color.Black;
        }

        private void FilterTournamentBox_Leave(object sender, EventArgs e) {
            if (FilterTournamentBox.Text == String.Empty) {
                FilterTournamentBox.Text = "Enter tournament`s name to filter info";
                FilterTournamentBox.ForeColor = System.Drawing.Color.Silver;
            }
        }
    }
}
