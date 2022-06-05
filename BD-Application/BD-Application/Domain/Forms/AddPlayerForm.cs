using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain {
    public partial class AddPlayerForm : Form {
        private List<Team> teams;
        public AddPlayerForm() {
            InitializeComponent();
            teams = GetAllTeams();
            FillTeamBox();
        }

        private List<Team> GetAllTeams() {
            List<Team> teams = new List<Team>();

            if (false) { // Read teams from DB
                return null;
            }

            return teams;
        }

        private void FillTeamBox() { 
            TeamBox.Items.Clear();
            foreach (Team team in teams) {
                TeamBox.Items.Add(team.Id + ", " + team.Name);
            }
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            try {
                string nickName = NickNameBox.Text;
                string name = NameBox.Text;
                DateTime birthDay = BirthDayBox.Value;
                Team team = teams.Find(x => x.Id == Convert.ToInt32(TeamBox.Text.Substring(0, TeamBox.Text.IndexOf(", "))));
                Player player = new Player(nickName, name, birthDay, team);

                //Add player into DB
                MessageBox.Show("Player added successful", "Message!");
            } catch (Exception) {
                MessageBox.Show("You entered wrong info", "Message!");
            }
        }
    }
}
