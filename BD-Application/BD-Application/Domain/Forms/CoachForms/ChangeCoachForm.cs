using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Domain.Forms.ContractCoachTeamForms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class ChangeCoachForm : Form {
        private List<Coach> coaches;
        private Coach currentCoach = null;
        private readonly IRepositoryCoach repository;
        private readonly IRepositoryContractCoach repositoryContract;

        public ChangeCoachForm() {
            InitializeComponent();
            repository = new DBRepositoryCoach();
            repositoryContract = new DBRepositoryContractCoach();
        }

        private void FillCoachBox() {
            CoachBox.DataSource = null;
            CoachBox.DataSource = coaches;
            CoachBox.DisplayMember = "nickname";
            CoachBox.ValueMember = "id";
        }

        private void DeleteCoachButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                var contract = repositoryContract.GetActiveContract(currentCoach.Id);
                if (contract != null) {
                    DialogResult result = MessageBox.Show(
                        "The coach has active contract with team. Determinate this contract?",
                        "Message!",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.DefaultDesktopOnly
                    );
                    if (result == DialogResult.Yes) {
                        if (repositoryContract.DeleteContractCoach(contract)) {
                            MessageBox.Show("The contract deleted successfull", "Message!");
                        } else {
                            MessageBox.Show("The contract didn`t delete", "Message!");
                        }
                    } else {
                        return;
                    }
                }
                if (repository.DeleteCoach(currentCoach)) {
                    MessageBox.Show("The coach deleted successfull", "Message!");
                    if ((coaches = repository.GetAllCoaches()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Error!");
                        return;
                    }
                    FillCoachBox();
                } else {
                    MessageBox.Show("The coach didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void ChangeCoachButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {

                    try {
                        currentCoach.NickName = NickNameBox.Text;
                        currentCoach.Name = NameBox.Text;
                        currentCoach.BirthDay = BirthdayBox.Value;

                        if (repository.ChangeCoach(currentCoach)) {
                            MessageBox.Show("Coach`s info changed successfull", "Message!");
                        } else {
                            MessageBox.Show("Coach`s info changed successfull", "Message!");
                        }

                    } catch (Exception) {
                        MessageBox.Show("You entered wrong info", "Message!");
                    }
                } else {
                    MessageBox.Show("You didn`t enter all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }

        }

        private void AddConctactButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                AddCoachTeamContract form = new AddCoachTeamContract(currentCoach.Id);
                form.ShowDialog();
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void TerminateConcractButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                var contract = repositoryContract.GetActiveContract(currentCoach.Id);
                if (contract != null) {
                    if (repositoryContract.DeleteContractCoach(contract)) {
                        MessageBox.Show("The contract deleted successfull", "Message!");
                    } else {
                        MessageBox.Show("The contract didn`t delete", "Message!");
                    }
                } else {
                    MessageBox.Show("The coach didn`t have active contract", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void CoachBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (CoachBox.SelectedItem != null) {
                currentCoach = (Coach)CoachBox.SelectedItem;

                if (currentCoach != null) {
                    panel1.Visible = true;
                    NickNameBox.Text = currentCoach.NickName;
                    NameBox.Text = currentCoach.Name;
                    BirthdayBox.Value = currentCoach.BirthDay;
                } else {
                    MessageBox.Show("Can`t found player by ID", "Error!");
                }
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void ChangeCoachForm_Load(object sender, EventArgs e) {
            if ((coaches = repository.GetAllCoaches()) == null) {
                MessageBox.Show("Can`t get info from repository", "Error!");
                return;
            }
            FillCoachBox();
        }
    }
}

