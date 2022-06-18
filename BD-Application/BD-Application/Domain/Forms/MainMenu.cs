using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using BD_Application.Domain.Forms.PlayerForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace BD_Application.Domain.Forms {
    public partial class MainMenu : Form {
        private List<Player> players;

        private readonly IRepositoryTeam repository;

        private readonly IRepositoryPlayer repositoryPlayer;
        private readonly IRepositoryContractPlayer contractPlayer;

        public MainMenu() {
            InitializeComponent();
            repository = new DBRepositoryTeam();

            repositoryPlayer = new DBRepositoryPlayer();
            contractPlayer = new DBRepositoryContractPlayer();
        }



        private void MainMenu_Load(object sender, EventArgs e) {
            if ((players = repositoryPlayer.GetAllPlayers()) == null) {
                MessageBox.Show("Can`t get info from repository", "Message!");
            }
            FillPlayerBox();
            PanelPlayer.Visible = false;
            PlayerInfo.Visible = false;
            PlayersTable.Visible = false;
        }

        private void FillPlayerBox() {
            PlayerBox.DataSource = null;
            PlayerBox.DataSource = players;
            PlayerBox.DisplayMember = "nickname";
            PlayerBox.ValueMember = "id";
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
                        if ((team = repository.GetTeam(contract.IdTeam)) != null) {
                            PlayerInfo.Text += team.Name;
                        }
                    }
                    PlayerInfo.Visible = true;

                }
            } else {
                MessageBox.Show("Message!");
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
                    if ((team = repository.GetTeam(contract.IdTeam)) != null) {
                        PlayersTable.Rows[i].Cells[3].Value = team.Name;
                    } else {
                        PlayersTable.Rows[i].Cells[3].Value = String.Empty;
                    }
                } else {
                    PlayersTable.Rows[i].Cells[3].Value = String.Empty;
                }
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            AddPlayerForm form = new AddPlayerForm();
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
    }
}
