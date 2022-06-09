using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class AddTeamForm : Form {
        public AddTeamForm() {
            InitializeComponent();
        }

        private void AddTeamButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && WorldRankBox.Text != String.Empty) {

                if (!int.TryParse(WorldRankBox.Text, out int worldRank)) {
                    MessageBox.Show("You entered wrong info", "Message!");
                    return;
                }

                if (worldRank <= 0) {
                    MessageBox.Show("Rank can`t be less than '1'", "Message!");
                    return;
                }

                Team team = new Team(NameBox.Text, worldRank);
                //Add team into DB

                MessageBox.Show("Team added successful", "Message!");
            } else {
                MessageBox.Show("You didn`t entered all info", "Message!");
            }
        }
    }
}
