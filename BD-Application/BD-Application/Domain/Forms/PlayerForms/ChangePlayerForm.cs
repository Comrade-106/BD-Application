using BD_Application.Domain.Forms.ContractPlayerTeamForms;
using BD_Application.Repository;
using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class ChangePlayerForm : Form {
        private Player currentPlayer;
        private readonly IRepositoryPlayer repositoryPlayers;
        private readonly IRepositoryContractPlayer repositoryContract;

        public ChangePlayerForm(Player player, IRepositoryPlayer repositoryPlayers, IRepositoryContractPlayer repositoryContract) {
            InitializeComponent();
            currentPlayer = player;
            this.repositoryPlayers = repositoryPlayers;
            this.repositoryContract = repositoryContract;
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthDayBox.Value != null) {
                    try {
                        currentPlayer.NickName = NickNameBox.Text;
                        currentPlayer.Name = NameBox.Text;
                        currentPlayer.BirthDay = BirthDayBox.Value;

                        repositoryPlayers.ChangePlayer(currentPlayer);
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
                    DialogResult result = MessageBox.Show(
                        "The Player has active contract with team. Determinate this contract?",
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

                if (repositoryPlayers.DeletePlayer(currentPlayer)) {
                    MessageBox.Show("The player deleted successfull", "Message!");
                    this.Close();
                } else {
                    MessageBox.Show("The player didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice the player", "Message!");
            }
        }

        private void ChangePlayerForm_Load(object sender, EventArgs e) { 
            if (currentPlayer != null) {
                panel1.Visible = true;
                NickNameBox.Text = currentPlayer.NickName;
                NameBox.Text = currentPlayer.Name;
                BirthDayBox.Value = currentPlayer.BirthDay;
            } else {
                MessageBox.Show("Can`t found a player", "Error!");
            }
        }

        private void AddChangeContractButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                AddPlayerTeamContractForm form = new AddPlayerTeamContractForm(currentPlayer.Id);
                form.ShowDialog();
            } else {
                MessageBox.Show("You didn` choice a player", "Message!");
            }
        }

        private void TerminateConcractButton_Click(object sender, EventArgs e) {
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
