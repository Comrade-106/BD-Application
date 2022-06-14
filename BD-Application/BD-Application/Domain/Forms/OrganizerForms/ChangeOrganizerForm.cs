using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class ChangeOrganizerForm : Form {
        private readonly List<Organizer> organizers;
        private Organizer currentOrganizer = null;

        public ChangeOrganizerForm() {
            InitializeComponent();
            if ((organizers = GetAllOrganizers()) == null) {
                MessageBox.Show("Can`t get info from DB", "Error!");
                return;
            }
            FillOrganizerBox();
        }

        private List<Organizer> GetAllOrganizers() {
            List<Organizer> organizers = new List<Organizer>();

            if (false) {
                return null;
            }

            return organizers;
        }

        private void FillOrganizerBox() {
            OrganizerBox.Items.Clear();
            OrganizerBox.DataSource = organizers;
            OrganizerBox.DisplayMember = "name";
            OrganizerBox.ValueMember = "id";
        }

        private void DeleteOrganizerButton_Click(object sender, EventArgs e) {
            if (currentOrganizer != null) {
                //Delete
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (currentOrganizer != null) {

                if (NameBox.Text != String.Empty) {
                    currentOrganizer.Name = NameBox.Text;

                    //Change info by ID

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
    }
}
