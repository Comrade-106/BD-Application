using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Domain.Forms.ContractCoachTeamForms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class ChangeCoachForm : Form {
        private Coach coach = null;
        private readonly IRepositoryCoach repositoryCoach;
        private readonly IRepositoryContractCoach repositoryContract;

        public ChangeCoachForm(Coach coach, IRepositoryCoach repositoryCoach, IRepositoryContractCoach contractCoach) {
            InitializeComponent();
            this.coach = coach;
            this.repositoryCoach = repositoryCoach;
            this.repositoryContract = contractCoach;
        }

        private void DeleteCoachButton_Click(object sender, EventArgs e) {
            if (coach != null) {
                var contract = repositoryContract.GetActiveContractByCoach(coach.Id);
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
                if (repositoryCoach.DeleteCoach(coach)) {
                    MessageBox.Show("The coach deleted successfull", "Message!");
                    this.Close();
                } else {
                    MessageBox.Show("The coach didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void ChangeCoachButton_Click(object sender, EventArgs e) {
            if (coach != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {

                    try {
                        coach.NickName = NickNameBox.Text;
                        coach.Name = NameBox.Text;
                        coach.BirthDay = BirthdayBox.Value;

                        if (repositoryCoach.ChangeCoach(coach)) {
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
            if (coach != null) {
                AddCoachTeamContract form = new AddCoachTeamContract(coach.Id);
                form.ShowDialog();
            } else {
                MessageBox.Show("You didn`t choice a coach", "Message!");
            }
        }

        private void TerminateConcractButton_Click(object sender, EventArgs e) {
            if (coach != null) {
                var contract = repositoryContract.GetActiveContractByCoach(coach.Id);
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

        private void ChangeCoachForm_Load(object sender, EventArgs e) {
            if (coach != null) {
                panel1.Visible = true;
                NickNameBox.Text = coach.NickName;
                NameBox.Text = coach.Name;
                BirthdayBox.Value = coach.BirthDay;
            } else {
                MessageBox.Show("Unknown coach", "Message!");
            }
        }
    }
}

