using BD_Application.Repository;
using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class ChangeTeamForm : Form {
        private Team team = null;
        private readonly IRepositoryTeam repositoryTeam;

        private readonly IRepositoryContractCoach contractCoach;
        private readonly IRepositoryContractPlayer contractsPlayers;

        public ChangeTeamForm(Team team, IRepositoryTeam repositoryTeam, IRepositoryContractPlayer contractsPlayers, IRepositoryContractCoach contractCoach) {
            InitializeComponent();
            this.repositoryTeam = repositoryTeam;
            this.team = team;
            this.contractsPlayers = contractsPlayers;
            this.contractCoach = contractCoach;
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (team != null) {
                if (contractCoach.CheckContractByTeamId(team.Id)) {
                    DialogResult result = MessageBox.Show(
                        "The team has active contract with coach. Determinate this contract?",
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (contractCoach.DeleteContractCoachByTeamId(team.Id)) {
                            MessageBox.Show("The coach`s contract determinated", "Message!");
                        } else {
                            MessageBox.Show("The coach`s contract didn`t determinate", "Message!");
                        }
                    } else {
                        return;
                    }
                } else if (contractsPlayers.CheckContractByTeamId(team.Id)) {
                    DialogResult result = MessageBox.Show(
                        "The team has active contracts with players. Determinate this contracts?",
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (contractsPlayers.DeleteAllContractByTeamId(team.Id)) {
                            MessageBox.Show("The contracts of players determinated", "Message!");
                        } else {
                            MessageBox.Show("The contracts of players didn`t determinate", "Message!");
                        }
                    } else {
                        return;
                    }
                }

                if (repositoryTeam.DeleteTeam(team)) {
                    MessageBox.Show("The team deleted successfull", "Message!");
                    this.Close();
                } else {
                    MessageBox.Show("The team didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice a team", "Message!");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && WorldRankBox.Text != String.Empty) {
                if (team != null) {

                    if (int.TryParse(WorldRankBox.Text, out int rank)) {
                        if (rank <= 0) {
                            MessageBox.Show("A rank can`t be less than '1'", "Message!");
                            return;
                        }
                        team.WorldRank = rank;
                    } else {
                        MessageBox.Show("You entered wrong info", "Message!");
                        return;
                    }

                    team.Name = NameBox.Text;

                    if (repositoryTeam.ChangeTeam(team)) {
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
            if (team != null) {
                panel1.Visible = true;
                NameBox.Text = team.Name;
                WorldRankBox.Text = Convert.ToString(team.WorldRank);
            } else {
                MessageBox.Show("You didn`t choice a team", "Message!");
            }
        }
    }
}
