using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain {
    public partial class DeletePlayerForm : Form {
        private List<Player> players;

        public DeletePlayerForm() {
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
                PlayerBox.Items.Add(player.Id +  ", " + player.NickName + " (" + player.Name + ")");
            }
        }

        private void PlayerBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (PlayerBox.SelectedValue != null) {
                int ID;

                if (int.TryParse(PlayerBox.SelectedText.Substring(0, PlayerBox.SelectedText.IndexOf(", ")), out ID)) {
                    //Delete player by ID
                } else {
                    MessageBox.Show("Can`t get ID", "Error!");
                }
            } else {
                MessageBox.Show("You didn`t choice the player", "Message!");
            }
        }
    }
}
