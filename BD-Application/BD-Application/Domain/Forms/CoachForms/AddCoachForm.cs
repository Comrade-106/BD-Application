using System;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class AddCoachForm : Form {
        private IRepositoryCoach repository;

        public AddCoachForm() {
            InitializeComponent();
            repository = new DBRepositoryCoach();
        }

        private void AddCoachButton_Click(object sender, EventArgs e) {
            if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {
                try {
                    Coach coach = new Coach(NickNameBox.Text, NameBox.Text, BirthdayBox.Value);

                    if (repository.AddCoach(coach)) {
                        MessageBox.Show("The coach added successful", "Message!");
                        NameBox.Text = NickNameBox.Text = String.Empty;
                        BirthdayBox.Value = Convert.ToDateTime("1990-01-01");
                    } else {
                        MessageBox.Show("The coach didn`t add", "Message!");
                    }
                } catch (Exception) {
                    MessageBox.Show("You entered wrong info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
