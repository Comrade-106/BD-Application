using System;
using System.Windows.Forms;
using BD_Application.Domain.Forms.CoachForms;

namespace BD_Application.Domain.Forms {
    public partial class MainMenu : Form {

        public MainMenu() {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e) {

        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedItem != null) {
                switch (comboBox1.SelectedValue.ToString()) {
                    case "Player":
                      
                        break;

                    /*case "Coach":
                        CoachForms.AddCoachForm form = new CoachForms.AddCoachFormForm();
                        form.ShowDialog();
                        break;
                    case "Team":
                        TeamForms.AddTeamForm form = new AddTeamForm();
                        form.ShowDialog();
                        break;
                    case "Tournament":
                        AddTournamentForm form = new AddTournamentForm();
                        form.ShowDialog();
                        break;
                        default: return;*/
                }
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {

        }

        private void ViewButton_Click(object sender, EventArgs e) {

        }
    }
}
