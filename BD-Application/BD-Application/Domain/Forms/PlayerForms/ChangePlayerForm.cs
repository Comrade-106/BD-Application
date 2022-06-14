using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class ChangePlayerForm : Form {
        private List<Player> players;
        private Player currentPlayer;
        private IRepositoryPlayer repository;

        public ChangePlayerForm() {
            InitializeComponent();
            repository = new DBRepositoryPlayer();
        }

        private void FillPlayerBox() {
            PlayerBox.Items.Clear();
            PlayerBox.DataSource = players;
            PlayerBox.DisplayMember = "name";
            PlayerBox.ValueMember = "id";
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


        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthDayBox.Value != null) {
                    try {
                        currentPlayer.NickName = NickNameBox.Text;
                        currentPlayer.Name = NameBox.Text;
                        currentPlayer.BirthDay = BirthDayBox.Value;

                        repository.ChangePlayer(currentPlayer);

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

        private void ConcractButton_Click(object sender, EventArgs e) {
            //Conctacts
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {//Add check contract

                repository.DeletePlayer(currentPlayer);
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
    }
}
