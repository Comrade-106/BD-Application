using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class ChangePlayerForm : Form {
        private List<Player> players;
        private Player currentPlayer;

        public ChangePlayerForm() {
            InitializeComponent();
            players = GetAllPlayers();
            FillPlayerBox();
        }

        private List<Player> GetAllPlayers() {
            List<Player> players = new List<Player>();

            if (false) { //Get all players from DB
                return null;
            }

            return players;
        }

        private void FillPlayerBox() {
            PlayerBox.Items.Clear();
            foreach (Player player in players) {
                PlayerBox.Items.Add(player.Id + ", " + player.NickName + " (" + player.Name + ")");
            }
        }

        private void PlayerBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (PlayerBox.SelectedValue != null) {
                if (int.TryParse(PlayerBox.SelectedText.Substring(0, PlayerBox.SelectedText.IndexOf(", ")), out int id)) {
                    currentPlayer = players.Find(x => x.Id == id);
                    panel1.Visible = true;

                    if (currentPlayer != null) {
                        NickNameBox.Text = currentPlayer.NickName;
                        NameBox.Text = currentPlayer.Name;
                        BirthDayBox.Value = currentPlayer.BirthDay;
                    } else {
                        MessageBox.Show("Can`t found player by ID", "Error!");
                    }
                } else {
                    MessageBox.Show("Can`t get ID", "Error!");
                }
            }
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (currentPlayer != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthDayBox.Value != null) {
                    try {
                        currentPlayer.NickName = NickNameBox.Text;
                        currentPlayer.Name = NameBox.Text;
                        currentPlayer.BirthDay = BirthDayBox.Value;

                        //Change player by ID

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


                //Delete Player
            }
        }
    }
}
