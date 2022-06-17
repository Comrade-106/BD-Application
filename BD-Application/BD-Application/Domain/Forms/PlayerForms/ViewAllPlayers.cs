using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.PlayerForms {
    public partial class ViewAllPlayers : Form {
        private List<Player> players;
        private readonly IRepositoryTeam repository;

        private readonly IRepositoryPlayer repositoryPlayer;
        private readonly IRepositoryContractPlayer contractPlayer;
        public ViewAllPlayers() {
            InitializeComponent();
            repository = new DBRepositoryTeam();

            repositoryPlayer = new DBRepositoryPlayer();
            contractPlayer = new DBRepositoryContractPlayer();
        }

        private void ViewAllPlayers_Load(object sender, EventArgs e) {
            FillTable(String.Empty);
        }

        private void FillTable(string nickname) {
            if (nickname == String.Empty) {
                if ((players = repositoryPlayer.GetAllPlayers()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            } else {
                //if ((teams = repository.GetTeams(nickname)) == null) {
                //    MessageBox.Show("Can`t get info from repository", "Error!");
                //    return;
                // }
            }

            for (int i = 0; i < players.Count; i++) {
                ContractPlayer contract = null;
                Team team = null;

                CoahesTable.Rows.Add();

                CoahesTable.Rows[i].Cells[0].Value = players[i].NickName;
                CoahesTable.Rows[i].Cells[1].Value = players[i].Name;
                CoahesTable.Rows[i].Cells[2].Value = players[i].BirthDay;

                if ((contract = contractPlayer.GetActiveContract(players[i].Id)) != null) {
                    if ((team = repository.GetTeam(contract.IdTeam)) != null) {
                        CoahesTable.Rows[i].Cells[2].Value = team.Name;
                    } else {
                        CoahesTable.Rows[i].Cells[2].Value = String.Empty;
                    }
                } else {
                    CoahesTable.Rows[i].Cells[2].Value = String.Empty;
                }

            }
        }
    }
}
