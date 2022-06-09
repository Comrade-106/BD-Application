using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class ChangeTeamForm : Form {
        private List<Team> teams;
        private Team currentTeam = null;

        public ChangeTeamForm() {
            InitializeComponent();
            teams = GetAllTeams();
            FillTeamBox();
        }

        private List<Team> GetAllTeams() {
            List<Team> teams = new List<Team>();

            if (false) { //Get all teams from DB
                return null;
            }

            return teams;
        }

        private void FillTeamBox() {
            TeamBox.Items.Clear();
            foreach (Team team in teams) {
                TeamBox.Items.Add(team.Id + ", " + team.Name);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (currentTeam != null) {
                //Delete (logic) team
                //contracts?
            } else {
                MessageBox.Show("You don`t choice team", "Message!");
            }
        }

        private void TeamBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TeamBox.SelectedItem != null) {
                int.TryParse(TeamBox.SelectedText.Substring(TeamBox.SelectedText.IndexOf(", ")), out int currentId);

                if ((currentTeam = teams.Find(x => x.Id == currentId)) != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTeam.Name;
                    WorldRankBox.Text = Convert.ToString(currentTeam.WorldRank);
                } else {
                    MessageBox.Show("Can`t get id", "Error!");
                }
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && WorldRankBox.Text != String.Empty) {
                if (TeamBox.SelectedItem != null) {

                    if (int.TryParse(WorldRankBox.Text, out int rank)) {
                        if (rank <= 0) {
                            MessageBox.Show("Rank can`t be less than '1'", "Message!");
                            return;
                        }
                        currentTeam.WorldRank = rank;
                    } else {
                        MessageBox.Show("You entered wrong info", "Message!");
                        return;
                    }

                    currentTeam.Name = NameBox.Text;

                    //Change team to currentTeam by ID

                } else {
                    MessageBox.Show("You don`t choice team", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t entered all info", "Message!");
            }
        }
    }
}
