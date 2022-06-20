using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.ContractCoachTeamForms {
    public partial class AddCoachTeamContract : Form {
        private List<Team> teams = null;
        private ContractCoach contract = null;
        private int id_coach;

        private readonly IRepositoryContractCoach repositoryContract;
        private readonly IRepositoryTeam repositoryTeam;
        public AddCoachTeamContract(int id_coach) {
            InitializeComponent();
            repositoryContract = new DBRepositoryContractCoach();
            repositoryTeam = new DBRepositoryTeam();
            this.id_coach = id_coach;
        }

        private void FillTeamBox() {
            // Only 1 coach
            TeamBox.DataSource = null;
            TeamBox.DataSource = teams;
            TeamBox.DisplayMember = "name";
            TeamBox.ValueMember = "id";
        }

        private void AddCoachContractButton_Click(object sender, EventArgs e) {
            if (TeamBox.SelectedItem != null && StartDateBox.Value != null &&
                EndDateBox.Value != null && SalaryBox.Text != String.Empty) {
                if (StartDateBox.Value < EndDateBox.Value) {
                    if (double.TryParse(SalaryBox.Text, out double salary) && salary >= 0) {
                        if (!repositoryContract.HaveCoachInTheTeame(Convert.ToInt32(TeamBox.SelectedValue))) {
                            contract = new ContractCoach(
                                id_coach,
                                Convert.ToInt32(TeamBox.SelectedValue),
                                StartDateBox.Value,
                                EndDateBox.Value,
                                salary
                            );

                            if (repositoryContract.AddContractCoach(contract)) {
                                MessageBox.Show("The contract added successull", "Message!");
                                this.Close();
                            } else {
                                MessageBox.Show("The contract didn`t add", "Message!");
                            }

                        } else {
                            MessageBox.Show("The team already have a coach", "Message!");
                        }
                    } else {
                        MessageBox.Show("Salary is a number. And it can`t be less than 0", "Message!");
                    }
                } else {
                    MessageBox.Show("Date end can`t be less than date start", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }

        private void AddCoachTeamContract_Load(object sender, EventArgs e) {
            if ((teams = repositoryTeam.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info from repository", "Error!");
                return;
            }
            FillTeamBox();

            if ((contract = repositoryContract.GetActiveContractByCoach(id_coach)) != null) {
                MessageBox.Show("This Coach already have a contarct with team", "Message!");
                this.Close();
            }
        }
    }
}
