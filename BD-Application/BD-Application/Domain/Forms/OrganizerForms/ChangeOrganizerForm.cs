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
                if (repository.DeleteOrganizer(currentOrganizer)) {
                    MessageBox.Show("Organizer deleted successfull", "Message!");
                    if ((organizers = repository.GetAllOrganizers()) == null) {
                        MessageBox.Show("Can`t get info from repository", "Error!");
                        return;
                    }
                } else {
                    MessageBox.Show("Organizer didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (currentOrganizer != null) {

                if (NameBox.Text != String.Empty) {
                    currentOrganizer.Name = NameBox.Text;

                    if (repository.ChangeOrganizer(currentOrganizer)) {
                        MessageBox.Show("Organizer changed successfull", "Message!");
                    } else {
                        MessageBox.Show("Organizer didn`t change", "Message!");
                    }
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
                    panel1.Visible = true;
                    NameBox.Text = currentOrganizer.Name;
                } else {
                    MessageBox.Show("You entered wrong info", "Error!");
                }
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
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
