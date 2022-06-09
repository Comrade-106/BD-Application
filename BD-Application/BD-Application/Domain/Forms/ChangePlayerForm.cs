using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain {
    public partial class ChangePlayerForm : Form {
        private List<Player> players;
        private int currentID;

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
                if (int.TryParse(PlayerBox.SelectedText.Substring(0, PlayerBox.SelectedText.IndexOf(", ")), out currentID)) {
                    Player player = players.Find(x => x.Id == currentID);
                    panel1.Visible = true;

                    if (player != null) {
                        NickNameBox.Text = player.NickName;
                        NameBox.Text = player.Name;
                        BirthDayBox.Value = player.BirthDay;
                    } else {
                        MessageBox.Show("Can`t found player by ID", "Error!");
                    }
                } else {
                    MessageBox.Show("Can`t get ID", "Error!");
                }
            }
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (PlayerBox.SelectedValue != null) {
                try {
                    string nickName = NickNameBox.Text;
                    string name = NameBox.Text;
                    DateTime birthDay = BirthDayBox.Value;
                
                    Player player = new Player(nickName, name, birthDay);

                    //Change player by ID

                } catch (Exception) {
                    MessageBox.Show("You entered wrong info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice the player", "Message!");
            }
        }

        private void ConcractButton_Click(object sender, EventArgs e) {
            //Conctacts
        }
    }
}
