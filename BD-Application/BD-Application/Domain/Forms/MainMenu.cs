using BD_Application.Domain.Forms.CoachForms;
using BD_Application.Domain.Forms.OrganizerForms;
using BD_Application.Domain.Forms.PlayerForms;
using BD_Application.Domain.Forms.TeamForms;
using BD_Application.Domain.Forms.TournamentForms;
using System;
using System.Windows.Forms;


namespace BD_Application.Domain.Forms {
    public partial class MainMenu : Form {

        public MainMenu() {
            InitializeComponent();
        }


        private void MainMenu_Load(object sender, EventArgs e) {

        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (comboBox1.SelectedItem != null) {
                switch (comboBox1.SelectedItem) {
                    case "Player":
                        AddPlayerForm addPlayerForm = new AddPlayerForm();
                        addPlayerForm.ShowDialog();
                        break;

                    case "Coach":
                        AddCoachForm form = new AddCoachForm();
                        form.ShowDialog();
                        break;
                    case "Team":
                        AddTeamForm teamForm = new AddTeamForm();
                        teamForm.ShowDialog();
                        break;
                    case "Organizer":
                        AddOrganizerForm organizerForm = new AddOrganizerForm();
                        organizerForm.ShowDialog();
                        break;
                    case "Tournament":
                        AddTournamentForm tournamentForm = new AddTournamentForm();
                        tournamentForm.ShowDialog();
                        break;
                    default: return;
                }
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {

        }

        private void ViewButton_Click(object sender, EventArgs e) {

        }
    }
}
