using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class ChangeTeamForm : Form {
        private List<Team> teams;
        private Team currentTeam = null;
        private readonly IRepositoryTeam repository;

        private readonly IRepositoryContractCoach contractCoach;
        private readonly IRepositoryContractPlayer contractPlayer;

        public ChangeTeamForm() {
            InitializeComponent();
            repository = new DBRepositoryTeam();
            contractCoach = new DBRepositoryContractCoach();
            contractPlayer = new DBRepositoryContractPlayer();
        }

        private void FillTeamBox() {
            TeamBox.DataSource = null;
            TeamBox.DataSource = teams;
            TeamBox.DisplayMember = "name";
            TeamBox.ValueMember = "id";
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (currentTeam != null) {
                if (contractCoach.CheckContractByTeamId(currentTeam.Id)) {
                    DialogResult result = MessageBox.Show(
                        "The team has active contract with coach. Determinate this contract?",
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (contractCoach.DeleteContractCoachByTeamId(currentTeam.Id)) {
                            MessageBox.Show("The coach`s contract determinated", "Message!");
                        } else {
                            MessageBox.Show("The coach`s contract didn`t determinate", "Message!");
                        }
                    } else {
                        return;
                    }
                } else if (contractPlayer.CheckContractByTeamId(currentTeam.Id)) {
                    DialogResult result = MessageBox.Show(
                        "The team has active contracts with players. Determinate this contract?",
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (contractPlayer.DeleteAllContractByTeamId(currentTeam.Id)) {
                            MessageBox.Show("The contracts of players determinated", "Message!");
                        } else {
                            MessageBox.Show("The contracts of players didn`t determinate", "Message!");
                        }
                    } else {
                        return;
                    }
                }

                if (repository.DeleteTeam(currentTeam)) {
                    MessageBox.Show("The team deleted successfull", "Message!");
                    if ((teams = repository.GetAllTeams()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Error!");
                        return;
                    }
                    FillTeamBox();
                } else {
                    MessageBox.Show("The team didn`t delete", "Message!");
                }

                //contracts?
            } else {
                MessageBox.Show("You didn`t choice a team", "Message!");
            }
        }

        private void TeamBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TeamBox.SelectedItem != null) {
                currentTeam = (Team)TeamBox.SelectedItem;

                if (currentTeam != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTeam.Name;
                    WorldRankBox.Text = Convert.ToString(currentTeam.WorldRank);
                } else {
                    MessageBox.Show("You entered wrong info", "Error!");
                }
            } else {
                MessageBox.Show("You didn`t choice a team", "Message!");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && WorldRankBox.Text != String.Empty) {
                if (currentTeam != null) {

                    if (int.TryParse(WorldRankBox.Text, out int rank)) {
                        if (rank <= 0) {
                            MessageBox.Show("A rank can`t be less than '1'", "Message!");
                            return;
                        }
                        currentTeam.WorldRank = rank;
                    } else {
                        MessageBox.Show("You entered wrong info", "Message!");
                        return;
                    }

                    currentTeam.Name = NameBox.Text;

                    if (repository.ChangeTeam(currentTeam)) {
                        MessageBox.Show("Team`s info changed successfull", "Message!");
                    } else {
                        MessageBox.Show("Team`s info didn`t change", "Message!");
                    }

                } else {
                    MessageBox.Show("You didn`t choice a team", "Message!");
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
