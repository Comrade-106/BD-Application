using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class ChangeCoachForm : Form {
        private List<Coach> coaches = new List<Coach>();
        private Coach currentCoach = null;

        public ChangeCoachForm() {
            InitializeComponent();
            coaches = GetAllCoaches();
            FillCoachBox();
        }

        private List<Coach> GetAllCoaches() {
            List<Coach> coaches = new List<Coach>();

            if (false) { //Get all coaches from DB
                return null;
            }

            return coaches;
        }

        private void FillCoachBox() {
            CoachBox.Items.Clear();
            CoachBox.DataSource = coaches;
            CoachBox.DisplayMember = "name";
            CoachBox.ValueMember = "id";
        }

        private void DeleteCoachButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {  //Add check contract

                //Delete coach by ID
                //contracts?

            } else {
                MessageBox.Show("You didn`t choice the coach", "Message!");
            }
        }

        private void ChangePlayerButton_Click(object sender, EventArgs e) {
            //Change contract
        }

        private void AddConctactButton_Click(object sender, EventArgs e) {
            //Add contract
        }

        private void ChangeConcractButton_Click(object sender, EventArgs e) {
            if (currentCoach != null) {
                if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {

                    try {
                        currentCoach.NickName = NickNameBox.Text;
                        currentCoach.Name = NameBox.Text;
                        currentCoach.BirthDay = BirthdayBox.Value;

                        //Change player by ID

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

        private void CoachBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (CoachBox.SelectedItem != null) {
                currentCoach = (Coach)CoachBox.SelectedItem;

                if (currentCoach != null) {
                    panel1.Visible = true;
                    NickNameBox.Text = currentCoach.NickName;
                    NameBox.Text = currentCoach.Name;
                    BirthdayBox.Value = currentCoach.BirthDay;

                    //Change info in DB

                } else {
                    MessageBox.Show("Can`t found player by ID", "Error!");
                }
            } else {
                MessageBox.Show("You didn`t choice the coach", "Message!");
            }
        }
    }
}

