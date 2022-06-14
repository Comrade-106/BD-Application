using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.OrganizerForms {
    public partial class AddOrganizerForm : Form {
        public AddOrganizerForm() {
            InitializeComponent();
        }

        private void AddOrganizerButton_Click(object sender, EventArgs e) {
            if (NameBox.Text != String.Empty) {
                Organizer organizer = new Organizer(NameBox.Text);

                //Add oraganizer into BD
            }
        }
    }
}
