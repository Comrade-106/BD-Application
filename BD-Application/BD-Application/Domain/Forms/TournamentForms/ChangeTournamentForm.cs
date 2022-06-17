using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ChangeTournamentForm : Form {
        private List<Tournament> tournaments;
        private List<Organizer> organizers;
        private Tournament currentTournament = null;

        private readonly IRepositoryTournament repositoryTournanent;
        private readonly IRepositoryOrganizer repositoryOrganizer;

        public ChangeTournamentForm() {
            InitializeComponent();
            repositoryTournanent = new DBRepositoryTournament();
            repositoryOrganizer = new DBRepositoryOrganizer();
        }

        private void FillTournamentBox() {
            TournamentBox.DataSource = null;
            TournamentBox.DataSource = tournaments;
            TournamentBox.DisplayMember = "name";
            TournamentBox.ValueMember = "id";
        }

        private void FillOraganizerBox() {
            OrganizerBox.DataSource = null;
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void TournamentBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (TournamentBox.SelectedItem != null) {
                currentTournament = (Tournament) TournamentBox.SelectedItem;

                if (currentTournament != null && (organizers = repositoryOrganizer.GetAllOrganizers()) != null) {
                    panel1.Visible = true;
                    NameBox.Text = currentTournament.Name;

                    FillOraganizerBox();
                    OrganizerBox.SelectedValue = currentTournament.Organizer.Id;

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
                repositoryTournanent.DeleteTournament(currentTournament);
            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e) {
            if (currentTournament != null) {
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

                                if (repositoryTournanent.ChangeTournament(currentTournament)) {
                                    MessageBox.Show("Tournament`s info changed successfull", "Message!");
                                } else {
                                    MessageBox.Show("Tournament`s info didn`t change", "Message!");
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
                    MessageBox.Show("You entered not all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice tournament", "Message!");
            }
        }

        private void ChangeTournamentForm_Load(object sender, EventArgs e) {
            if ((tournaments = repositoryTournanent.GetAllTournament()) == null) {
                MessageBox.Show("Can`t get info about tournament", "Error!");
                return;
            }
            FillTournamentBox();
        }
    }
}
