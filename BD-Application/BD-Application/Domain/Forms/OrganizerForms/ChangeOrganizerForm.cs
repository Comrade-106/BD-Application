using BD_Application.DataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class ChangeOrganizerForm : Form {
        private List<Organizer> organizers;
        private Organizer currentOrganizer = null;
        private readonly IRepositoryOrganizer repository;

        public ChangeOrganizerForm() {
            InitializeComponent();
            repository = new DBRepositoryOrganizer();
        }

        private void FillOrganizerBox() {
            OrganizerBox.Items.Clear();
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void DeleteOrganizerButton_Click(object sender, EventArgs e) {
            if (currentOrganizer != null) {
                repository.DeleteOrganizer(currentOrganizer);
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (currentOrganizer != null) {

                if (NameBox.Text != String.Empty) {
                    currentOrganizer.Name = NameBox.Text;

                    repository.ChangeOrganizer(currentOrganizer);
                } else {
                    MessageBox.Show("You didn`t enter all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void OrganizerBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (OrganizerBox.SelectedItem != null) {
                currentOrganizer = (Organizer)OrganizerBox.SelectedItem;

                if (currentOrganizer != null) {
                    NameBox.Text = currentOrganizer.Name;
                } else {
                    MessageBox.Show("You entered wrong info", "Error!");
                }
            }
        }

        private void ChangeOrganizerForm_Load(object sender, EventArgs e) {
            if ((organizers = repository.GetAllOrganizers()) == null) {
                MessageBox.Show("Can`t get info from repository", "Error!");
                return;
            }
            FillOrganizerBox();
        }
    }
}
