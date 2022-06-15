using System;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class AddOrganizerForm : Form {
        private readonly IRepositoryOrganizer repository;
        public AddOrganizerForm() {
            InitializeComponent();
            repository = new DBRepositoryOrganizer();
        }

        private void AddOrganizerButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty) {
                Organizer organizer = new Organizer(NameBox.Text);

                if (repository.AddOrganizer(organizer)) {
                    MessageBox.Show("Organizer added successfull", "Message!");
                    NameBox.Text = String.Empty;
                } else {
                    MessageBox.Show("Organizer didn`t add", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
