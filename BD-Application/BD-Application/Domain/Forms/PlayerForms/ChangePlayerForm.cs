using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using BD_Application.Domain.Forms.ContractPlayerTeamForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class ChangePlayerForm : Form {
        private List<Player> players;
        private Player currentPlayer;
        private readonly IRepositoryPlayer repository;
        private readonly IRepositoryContractPlayer repositoryContract;

        public ChangePlayerForm() {
            InitializeComponent();
            repository = new DBRepositoryPlayer();
            repositoryContract = new DBRepositoryContractPlayer();
        }

        private void FillPlayerBox() {
            PlayerBox.DataSource = null;
            PlayerBox.DataSource = players;
            PlayerBox.DisplayMember = "nickname";
            PlayerBox.ValueMember = "id";
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthDayBox.Value != null) {
                    try {
                        currentPlayer.NickName = NickNameBox.Text;
                        currentPlayer.Name = NameBox.Text;
                        currentPlayer.BirthDay = BirthDayBox.Value;

                        repository.ChangePlayer(currentPlayer);
                        MessageBox.Show("Player`s info changed successfull", "Message!");
                    } catch (Exception) {
                        MessageBox.Show("You entered wrong info", "Message!");
                    }
                } else {
                    MessageBox.Show("You didn`t enter all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice the player", "Message!");
            }
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {

                var contract = repositoryContract.GetActiveContract(currentPlayer.Id);
                if (contract != null) {
                    DialogResult result =  MessageBox.Show(
                        "The Player have active contract with team. Determinate this contract?", 
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (repositoryContract.DeleteContractPlayer(contract)) {
                            MessageBox.Show("The contract deleted successfull", "Message!");
                        } else {
                            MessageBox.Show("The contract didn`t delete", "Message!");
                        }
                    } else {
                        return;
                    }
                }

                if (repository.DeletePlayer(currentPlayer)) {
                    MessageBox.Show("The player deleted successfull", "Message!");
                    if ((players = repository.GetAllPlayers()) == null) {
                        MessageBox.Show("Can`t get info from database", "Error!");
                        return;
                    }
                } else {
                    MessageBox.Show("The player didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice the player", "Message!");
            }
        }

        private void ChangePlayerForm_Load(object sender, EventArgs e) {
            if ((players = repository.GetAllPlayers()) == null) {
                MessageBox.Show("Can`t get info from database", "Error!");
                return;
            }
            FillPlayerBox();
        }

        private void PlayerBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (PlayerBox.SelectedItem != null) {
                currentPlayer = (Player)PlayerBox.SelectedItem;

                if (currentPlayer != null) {
                    panel1.Visible = true;
                    NickNameBox.Text = currentPlayer.NickName;
                    NameBox.Text = currentPlayer.Name;
                    BirthDayBox.Value = currentPlayer.BirthDay;
                } else {
                    MessageBox.Show("Can`t found a player", "Error!");
                }
            } else {
                MessageBox.Show("You didn` choice a player", "Message!");
            }
        }

        private void AddContractButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                AddPlayerTeamContractForm form = new AddPlayerTeamContractForm(currentPlayer.Id);
                form.ShowDialog();
            } else {
                MessageBox.Show("You didn` choice a player", "Message!");
            }
        }

        private void TerminateContractButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                var contract = repositoryContract.GetActiveContract(currentPlayer.Id);
                if (contract != null) {
                    if (repositoryContract.DeleteContractPlayer(contract)) {
                        MessageBox.Show("The contract deleted successfull", "Message!");
                    } else {
                        MessageBox.Show("The contract didn`t delete", "Message!");
                    }
                } else {
                    MessageBox.Show("The player didn`t have active contract", "Message!");
                }
                
            } else {
                MessageBox.Show("You didn` choice a player", "Message!");
            }
        }
    }
}
