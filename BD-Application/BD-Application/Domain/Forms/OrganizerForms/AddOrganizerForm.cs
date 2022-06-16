using System;
using System.Windows.Forms;
using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;

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
                    MessageBox.Show("The organizer added successfull", "Message!");
                    NameBox.Text = String.Empty;
                } else {
                    MessageBox.Show("The organizer didn`t add", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
