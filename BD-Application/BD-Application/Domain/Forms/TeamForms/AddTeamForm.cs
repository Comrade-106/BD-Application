using System;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class AddTeamForm : Form {
        private readonly IRepositoryTeam repository;

        public AddTeamForm() {
            InitializeComponent();
            repository = new DBRepositoryTeam();
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
                
                if (repository.AddTeam(new Team(NameBox.Text, worldRank))) {
                    MessageBox.Show("Team added successful", "Message!");
                } else {
                    MessageBox.Show("Team didn`t add", "Message!");
                }
                NameBox.Text = WorldRankBox.Text = String.Empty;
               
            } else {
                MessageBox.Show("You didn`t entered all info", "Message!");
            }
        }
    }
}
