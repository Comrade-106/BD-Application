using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.ContractPlayerTeamForms {
    public partial class AddPlayerTeamContractForm : Form {
        private List<Team> teams = null;
        private ContractPlayer contract = null;
        private int id_player;

        private readonly IRepositoryContractPlayer repositoryContract;
        private readonly IRepositoryTeam repositoryTeam;

        public AddPlayerTeamContractForm(int id_player) {
            InitializeComponent();
            repositoryContract = new DBRepositoryContractPlayer();
            repositoryTeam = new DBRepositoryTeam();

            this.id_player = id_player;
        }

        private void FillTeamBox() {
            // Can have more then 5 players
            TeamBox.DataSource = null;
            TeamBox.DataSource = teams;
            TeamBox.DisplayMember = "name";
            TeamBox.ValueMember = "id";
        }

        private void AddPlayerTeamContractForm_Load(object sender, EventArgs e) {
            if ((teams = repositoryTeam.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info from repository", "Error!");
                return;
            }
            FillTeamBox();

            if ((contract = repositoryContract.GetActiveContract(id_player)) != null) {
                TeamBox.SelectedItem = contract;
                StartDateBox.Value = contract.DateFrom;
                EndDateBox.Value = contract.DateTo;
                SalaryBox.Text = Convert.ToString(contract.Salary);
                if (contract.IsMain) {
                    MainPlayerRadioButton.Checked = true;
                } else {
                    MainPlayerRadioButton.Checked = true;
                }
                TeamBox.Enabled = StartDateBox.Enabled = EndDateBox.Enabled = SalaryBox.Enabled = false;
                AddPlayerContractButton.Text = "Change";
            }
        }

        private void AddPlayerContractButton_Click(object sender, EventArgs e) {
            if (TeamBox.SelectedItem != null && StartDateBox.Value != null && 
                EndDateBox.Value != null && SalaryBox.Text != String.Empty) {
                if (StartDateBox.Value < EndDateBox.Value) {
                    if (double.TryParse(SalaryBox.Text, out double salary) && salary >= 0) {
                        if (repositoryContract.NumberOfMainPlayerInTeam(Convert.ToInt32(TeamBox.SelectedValue)) < 5 || ReservePlayerRadioButton.Checked == true) {
                            contract = new ContractPlayer(
                                id_player,
                                Convert.ToInt32(TeamBox.SelectedValue),
                                StartDateBox.Value,
                                EndDateBox.Value,
                                salary
                            );

                            if (MainPlayerRadioButton.Checked == true) {
                                contract.IsMain = true;
                            } else if (ReservePlayerRadioButton.Checked == true) {
                                contract.IsMain = false;
                            } else {
                                MessageBox.Show("You didn`t enter all info", "Message!");
                                return;
                            }

                            if (contract.IdPlayerContract > 0) {
                                if (repositoryContract.ChangeContractPlayer(contract)) {
                                    MessageBox.Show("Contract`s info chanched successull", "Message!");
                                } else {
                                    MessageBox.Show("Contract`s info didn`t change", "Message!");
                                }
                            } else {
                                if (repositoryContract.AddContractPlayer(contract)) {
                                    MessageBox.Show("The contract added successull", "Message!");
                                    this.Close();
                                } else {
                                    MessageBox.Show("The contract didn`t add", "Message!");
                                }
                            }
                        } else {
                            MessageBox.Show("The team already have five main player", "Message!");
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
    }
}
