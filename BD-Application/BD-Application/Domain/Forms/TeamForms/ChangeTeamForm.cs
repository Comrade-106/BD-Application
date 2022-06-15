using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class ChangeTeamForm : Form {
        private List<Team> teams;
        private Team currentTeam = null;
        private readonly IRepositoryTeam repository;

        public ChangeTeamForm() {
            InitializeComponent();
            repository = new DBRepositoryTeam();
        }

        private void FillTeamBox() {
            TeamBox.Items.Clear();
            TeamBox.DataSource = teams;
            TeamBox.DisplayMember = "name";
            TeamBox.ValueMember = "id";
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (currentTeam != null) {
                repository.DeleteTeam(currentTeam);
                //contracts?
            } else {
                MessageBox.Show("You don`t choice team", "Message!");
            }
        }

        private void TeamBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TeamBox.SelectedItem != null) {
                currentTeam = (Team) TeamBox.SelectedItem;

                if (currentTeam != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTeam.Name;
                    WorldRankBox.Text = Convert.ToString(currentTeam.WorldRank);
                } else {
                    MessageBox.Show("You entered wrong info", "Error!");
                }
            } else {
                MessageBox.Show("You don`t choice team", "Message!");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && WorldRankBox.Text != String.Empty) {
                if (currentTeam != null) {

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

                    repository.ChangeTeam(currentTeam);

                } else {
                    MessageBox.Show("You don`t choice team", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t entered all info", "Message!");
            }
        }

        private void ChangeTeamForm_Load(object sender, EventArgs e) {
            if ((teams = repository.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info from repository", "Error!");
                return;
            }
            FillTeamBox();
        }
    }
}
