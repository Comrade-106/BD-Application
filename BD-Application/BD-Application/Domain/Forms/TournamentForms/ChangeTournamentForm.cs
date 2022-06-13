using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ChangeTournamentForm : Form {
        private List<Tournament> tournaments;
        private List<Organizer> organizers;
        private Tournament currentTournament = null;

        public ChangeTournamentForm() {
            InitializeComponent();
            if ((tournaments = GetAllTournaments()) == null) {
                MessageBox.Show("Can`t get info about tournament", "Error!");
                return;
            }
            FillTournamentBox();
        }

        private List<Tournament> GetAllTournaments() {
            List<Tournament> tournaments = new List<Tournament>();

            if (false) {    //Get tournament from DB
                return null;
            }

            return tournaments;
        }

        private List<Organizer> GetAllOrganizers() {
            List<Organizer> organizers = new List<Organizer>();

            if (false) {    //Get organizer from DB
                return null;
            }

            return organizers;
        }

        private void FillTournamentBox() {
            TournamentBox.Items.Clear();
            TournamentBox.DataSource = tournaments;
            TournamentBox.DisplayMember = "name";
            TournamentBox.ValueMember = "id";
        }

        private void FillOraganizerBox() {
            OrganizerBox.Items.Clear();
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void TournamentBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TournamentBox.SelectedItem != null) {
                currentTournament = tournaments.Find(x => x.Id == Convert.ToInt32(TournamentBox.SelectedValue));
            
                if (currentTournament != null && (organizers = GetAllOrganizers()) != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTournament.Name;

                    FillOraganizerBox();
                    OrganizerBox.SelectedText = currentTournament.Organizer.Name; 

                    DateStartBox.Value = currentTournament.DateStart;
                    DateEndBox.Value = currentTournament.DateEnd;
                    PrizePoolBox.Text = Convert.ToString(currentTournament.PrizePool);
                } else {
                    MessageBox.Show("Can`t get info about this tournament", "Error!");
                }

            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            if (currentTournament != null) {

                //Delete tournament, chnge bool value

            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (currentTournament != null) {
                if (NameBox.Text != String.Empty && OrganizerBox.SelectedItem != null && 
                    DateStartBox.Value != null && DateEndBox.Value != null && PrizePoolBox.Text != String.Empty) {
                    if (double.TryParse(PrizePoolBox.Text, out double prize)) {
                        if (prize >= 0.0) {
                            currentTournament.Name = NameBox.Text;
                            currentTournament.Organizer = organizers.Find(x => x.Id == Convert.ToInt32(OrganizerBox.SelectedValue));
                            currentTournament.DateStart = DateStartBox.Value;
                            currentTournament.DateEnd = DateEndBox.Value;
                            currentTournament.PrizePool = prize;
                        } else {
                            MessageBox.Show("Prize pool can`t be less than 0", "Message!");
                        }
                    } else {
                        MessageBox.Show("Prize pool is a number with comma", "Message!");
                    }

                } else {
                    MessageBox.Show("You entered not all info ", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }
    }
}
