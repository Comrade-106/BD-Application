using System;
using System.Windows.Forms;

namespace BD_Application.Domain {
    public partial class AddPlayerForm : Form {
        public AddPlayerForm() {
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            try {
                string nickName = NickNameBox.Text;
                string name = NameBox.Text;
                DateTime birthDay = BirthDayBox.Value;
                Player player = new Player(nickName, name, birthDay);

                //Add player into DB
                MessageBox.Show("Player added successful", "Message!");
            } catch (Exception) {
                MessageBox.Show("You entered wrong info", "Message!");
            }
        }
    }
}
