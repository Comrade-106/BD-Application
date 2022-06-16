﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class AddTournamentForm : Form {
        private readonly List<Organizer> organizers;
        private  List<Team> teams;
        private Tournament currentTournament = null;
        private List<Team> selectedTeams;
        private int count;

        private IRepositoryTournanent repositoryTournanent;
        private IRepositoryOrganizer repositoryOrganizer;
        private IRepositoryTeam repositoryTeam;


        public AddTournamentForm() {
            InitializeComponent();
            repositoryTournanent = new DBRepositoryTournament();
            repositoryOrganizer = new DBRepositoryOrganizer();
            repositoryTeam = new DBRepositoryTeam();

            if ((organizers = repositoryOrganizer.GetAllOrganizers()) == null) {
                MessageBox.Show("Can`t get info about organizer from DB", "Error!");
                return;
            }

            if ((teams = repositoryTeam.GetAllTeams()) == null) {
                MessageBox.Show("Can`t get info about teams from DB", "Error!");
                return;
            }

            FillOrganizersBox();
            FillTeamsBox();

            selectedTeams = new List<Team>();
            count = 0;
        }

        private void FillOrganizersBox() {
            OrganizerBox.Items.Clear();
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void FillTeamsBox() {
            _teamsList.Items.Clear();
            _teamsList.DataSource = teams;
            _teamsList.DisplayMember = "name";
            _teamsList.ValueMember = "id";
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

                            if (repositoryTournanent.AddTournament(currentTournament)) {
                                MessageBox.Show("Tournament added successfull", "Message!");
                            } else {
                                MessageBox.Show("Tournament didn`t add", "Message!");
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

        private void AddTeamButton_Click(object sender, EventArgs e) {
            count++;
            if (count >= 16) AddTeamButton.Enabled = false;

            Team temp = teams.Find(x => x.Id == Convert.ToInt32(_teamsList.SelectedValue));
            selectedTeams.Add(temp);
            teams.Remove(temp);

            _teamsGridView.Rows.Add(new object[]{ temp.WorldRank, temp.Name });

            FillTeamsBox();
        }

        private void AddTournamentForm_Load(object sender, EventArgs e) {

        }
    }
}
