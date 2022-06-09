using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class AddCoachForm : Form {
        public AddCoachForm() {
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {
                try {
                    Player player = new Player(NickNameBox.Text, NameBox.Text, BirthdayBox.Value);

                    //Add player into DB

                    MessageBox.Show("Player added successful", "Message!");
                } catch (Exception) {
                    MessageBox.Show("You entered wrong info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
