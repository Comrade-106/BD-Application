using BD_Application.Repository;
using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class ChangeOrganizerForm : Form {
        private Organizer organizer = null;
        private readonly IRepositoryOrganizer repositoryOrganizer;

        public ChangeOrganizerForm(Organizer organizer, IRepositoryOrganizer repositoryOrganizer) {
            InitializeComponent();
            this.organizer = organizer;
            this.repositoryOrganizer = repositoryOrganizer;
        }

        private void DeleteOrganizerButton_Click(object sender, EventArgs e) {
            if (organizer != null) {
                if (repositoryOrganizer.DeleteOrganizer(organizer)) {
                    MessageBox.Show("The organizer deleted successfull", "Message!");
                    this.Close();
                } else {
                    MessageBox.Show("The organizer didn`t delete", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerButton_Click(object sender, EventArgs e) {
            if (organizer != null) {

                if (NameBox.Text != String.Empty) {
                    organizer.Name = NameBox.Text;

                    if (repositoryOrganizer.ChangeOrganizer(organizer)) {
                        MessageBox.Show("Organizer`s info changed successfull", "Message!");
                    } else {
                        MessageBox.Show("Organizer`s info didn`t change", "Message!");
                    }
                } else {
                    MessageBox.Show("You didn`t enter all info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }

        private void ChangeOrganizerForm_Load(object sender, EventArgs e) {
            if (organizer != null) {
                panel1.Visible = true;
                NameBox.Text = organizer.Name;
            } else {
                MessageBox.Show("You didn`t choice organizer", "Message!");
            }
        }
    }
}
