using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class ChangeOrganizerForm : Form {
        private List<Organizer> organizers;
        private Organizer current = null;

        public ChangeOrganizerForm() {
            InitializeComponent();
            organizers = GetAllOrganizers();
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
            foreach (Organizer organizer in organizers) {
                OrganizerBox.Items.Add(organizer.Id + ", " + organizer.Name);
            }
        }

        private void DeleteOrganizerButton_Click(object sender, EventArgs e) {
            if (current != null) {
                //Delete
            } else {
                MessageBox.Show("You don`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty) {
                current.Name = NameBox.Text;

                //Change info by ID

            }
        }

        private void OrganizerBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (OrganizerBox.SelectedItem != null) {

                if (int.TryParse(OrganizerBox.SelectedText.Substring(0, OrganizerBox.SelectedText.IndexOf(", ")), out int id)) {
                    if ((current = organizers.Find(x => x.Id == id)) != null) {
                        NameBox.Text = current.Name;
                    } else {
                        MessageBox.Show("Can`t find organizer by id", "Error!");
                    }
                } else {
                    MessageBox.Show("Can`t get organizer`s id", "Error!");
                }
            }
        }
    }
}
