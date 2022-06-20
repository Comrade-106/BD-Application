using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ViewAllTournament : Form {
        private List<Tournament> tournaments;
        private readonly IRepositoryTournament repository;

        private readonly IRepositoryOrganizer repositoryOrganizer;

        public ViewAllTournament() {
            InitializeComponent();
            repository = new DBRepositoryTournament();
            repositoryOrganizer = new DBRepositoryOrganizer();
        }

        private void ViewAllTournament_Load(object sender, EventArgs e) {
            FillTable(String.Empty);
        }

        private void FillTable(string nickname) {
            if (nickname == String.Empty) {
                if ((tournaments = repository.GetAllTournament()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            } else {
                //if ((teams = repository.GetTeams(nickname)) == null) {
                //    MessageBox.Show("Can`t get info from repository", "Error!");
                //    return;
                // }
            }

            for (int i = 0; i < tournaments.Count; i++) {
                Organizer organizer = null;

                CoahesTable.Rows.Add();

                CoahesTable.Rows[i].Cells[0].Value = tournaments[i].Name;

                if ((organizer = repositoryOrganizer.GetOrganizer(tournaments[i].Organizer.Id)) != null) {
                    CoahesTable.Rows[i].Cells[1].Value = organizer.Name;
                } else {
                    CoahesTable.Rows[i].Cells[1].Value = "";
                }

                CoahesTable.Rows[i].Cells[2].Value = tournaments[i].DateStart;
                CoahesTable.Rows[i].Cells[3].Value = tournaments[i].DateEnd;
                CoahesTable.Rows[i].Cells[4].Value = tournaments[i].PrizePool;
            }
        }
    }
}
