using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class AddTournamentForm : Form {
        private readonly List<Organizer> organizers;
        private Tournament currentTournament = null;

        private IRepositoryTournament repositoryTournanent;
        private IRepositoryOrganizer repositoryOrganizer;

        public AddTournamentForm() {
            InitializeComponent();
            repositoryTournanent = new DBRepositoryTournament();
            repositoryOrganizer = new DBRepositoryOrganizer();

            if ((organizers = repositoryOrganizer.GetAllOrganizers()) == null) {
                MessageBox.Show("Can`t get info about organizer from DB", "Error!");
                return;
            }

            FillOrganizersBox();
        }

        private void FillOrganizersBox() {
            OrganizerBox.DataSource = null;
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
                            currentTournament = new Tournament(NameBox.Text,
                                                               organizers.Find(x => x.Id == Convert.ToInt32(OrganizerBox.SelectedValue)),
                                                               DateStartBox.Value,
                                                               DateEndBox.Value,
                                                               prize);

                            if (repositoryTournanent.AddTournament(currentTournament)) {
                                MessageBox.Show("The tournament added successfull", "Message!");
                            } else {
                                MessageBox.Show("The tournament didn`t add", "Message!");
                            }
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
