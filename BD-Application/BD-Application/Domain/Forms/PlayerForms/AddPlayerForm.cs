using System;
using System.Windows.Forms;
using BD_Application.DataBase;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class AddPlayerForm : Form {
        private readonly IRepositoryPlayer repository;

        public AddPlayerForm() {
            InitializeComponent();
            repository = new DBRepositoryPlayer();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e) {
            if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {
                try {
                    Player player = new Player(NickNameBox.Text, NameBox.Text, BirthdayBox.Value);

                    if (repository.AddPlayer(player)) {
                        MessageBox.Show("Player added successful", "Message!");
                    } else {
                        MessageBox.Show("Player didn`t add", "Message!");
                    }

                    NickNameBox.Text = NameBox.Text = String.Empty;
                    BirthdayBox.Value = Convert.ToDateTime("1990-01-01");
                } catch (Exception) {
                    MessageBox.Show("You entered wrong info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
