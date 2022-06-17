using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class ViewAllOrganizers : Form {
        private List<Organizer> organizers = null;
        private readonly IRepositoryOrganizer repository;

        public ViewAllOrganizers() {
            InitializeComponent();
            repository = new DBRepositoryOrganizer();
        }

        private void ViewAllOrganizers_Load(object sender, EventArgs e) {
            FillTable(String.Empty);
        }
        private void FillTable(string nickname) {
            if (nickname == String.Empty) {
                if ((organizers = repository.GetAllOrganizers()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            } else {
                //if ((teams = repository.GetTeams(nickname)) == null) {
                //    MessageBox.Show("Can`t get info from repository", "Error!");
                //    return;
                // }
            }

            for (int i = 0; i < organizers.Count; i++) {
                CoahesTable.Rows.Add();
                CoahesTable.Rows[i].Cells[0].Value = organizers[i].Name;
            }
        }
    }
}
