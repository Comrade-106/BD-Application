using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class AddTournamentForm : Form {
        private readonly List<Organizer> organizers;
        private Tournament currentTournament = null;

        public AddTournamentForm() {
            InitializeComponent();
            if ((organizers = GetAllOrganizers()) == null) {
                MessageBox.Show("Can`t get info about organizer from DB", "Error!");
                return;
            }
            FillOrganizersBox();
        }

        private List<Organizer> GetAllOrganizers() {
            List<Organizer> organizers = new List<Organizer>();

            if (false) {//get organizers from db
                return null;
            }

            return organizers;
        }

        private void FillOrganizersBox() {
            OrganizerBox.Items.Clear();
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void AddTournamentButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty && OrganizerBox.SelectedItem != null &&
                    DateStartBox.Value != null && DateEndBox.Value != null && PrizePoolBox.Text != String.Empty) {
                if (double.TryParse(PrizePoolBox.Text, out double prize)) {
                    if (prize >= 0.0) {
                        if (DateEndBox.Value > DateStartBox.Value) {
                            currentTournament.Name = NameBox.Text;
                            currentTournament.Organizer = organizers.Find(x => x.Id == Convert.ToInt32(OrganizerBox.SelectedValue));
                            currentTournament.DateStart = DateStartBox.Value;
                            currentTournament.DateEnd = DateEndBox.Value;
                            currentTournament.PrizePool = prize;
                        } else {
                            MessageBox.Show("End date can`t be less than start date", "Message!");
                        }
                    } else {
                        MessageBox.Show("Prize pool can`t be less than 0", "Message!");
                    }
                } else {
                    MessageBox.Show("Prize pool is a number with comma", "Message!");
                }
            } else {
                MessageBox.Show("You entered not all info ", "Message!");
            }
        }
    }
}
