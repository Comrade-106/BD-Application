using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class ViewAllCoaches : Form {
        private List<Coach> coaches;
        private readonly IRepositoryTeam repository;

        private readonly IRepositoryCoach repositoryCoach;
        private readonly IRepositoryContractCoach contractCoach;

        public ViewAllCoaches() {
            InitializeComponent();
            repository = new DBRepositoryTeam();

            repositoryCoach = new DBRepositoryCoach();
            contractCoach = new DBRepositoryContractCoach();
        }

        private void ViewAllCoaches_Load(object sender, EventArgs e) {
            FillTable(String.Empty);
        }

        private void FillTable(string nickname) {
            if (nickname == String.Empty) {
                if ((coaches = repositoryCoach.GetAllCoaches()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            } else {
                //if ((teams = repository.GetTeams(nickname)) == null) {
                //    MessageBox.Show("Can`t get info from repository", "Error!");
                //    return;
                // }
            }

            for (int i = 0; i < coaches.Count; i++) {
                ContractCoach contract = null;
                Team team = null;

                CoahesTable.Rows.Add();

                CoahesTable.Rows[i].Cells[0].Value = coaches[i].NickName;
                CoahesTable.Rows[i].Cells[1].Value = coaches[i].Name;
                CoahesTable.Rows[i].Cells[2].Value = coaches[i].BirthDay.ToString("yyyy-MM-dd");

                if ((contract = contractCoach.GetActiveContract(coaches[i].Id)) != null) {
                    if ((team = repository.GetTeam(contract.IdTeam)) != null) {
                        CoahesTable.Rows[i].Cells[3].Value = team.Name;
                    } else {
                        CoahesTable.Rows[i].Cells[3].Value = String.Empty;
                    }
                } else {
                    CoahesTable.Rows[i].Cells[3].Value = String.Empty;
                }
                
            }
        }
    }
}
