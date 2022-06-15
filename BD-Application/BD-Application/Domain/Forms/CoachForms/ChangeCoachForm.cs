using BD_Application.DataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class ChangeCoachForm : Form {
        private List<Coach> coaches;
        private Coach currentCoach = null;
        private readonly IRepositoryCoach repository;

        public ChangeCoachForm() {
            InitializeComponent();
            repository = new DBRepositoryCoach();
        }

        private void FillCoachBox() {
            CoachBox.Items.Clear();
            CoachBox.DataSource = coaches;
            CoachBox.DisplayMember = "nickname";
            CoachBox.ValueMember = "id";
        }

        private void DeleteCoachButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {  //Add check contract

                repository.DeleteCoach(currentCoach);
                //contracts?

            } else {
                MessageBox.Show("You didn`t choice the coach", "Message!");
            }
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {

                    try {
                        currentCoach.NickName = NickNameBox.Text;
                        currentCoach.Name = NameBox.Text;
                        currentCoach.BirthDay = BirthdayBox.Value;

                        repository.ChangeCoach(currentCoach);

                    } catch (Exception) {
                        MessageBox.Show("You entered wrong info", "Message!");
                    }
                } else {
                    MessageBox.Show("You didn`t enter all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice the coach", "Message!");
            }

        }

        private void AddConctactButton_Click(object sender, EventArgs e) {
            //Add contract
        }

        private void ChangeConcractButton_Click(object sender, EventArgs e) {
            //Change contract
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
                MessageBox.Show("You didn`t choice the coach", "Message!");
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

