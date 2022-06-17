using BD_Application.Repository;
using BD_Application.Repository.DataBaseRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TeamForms {
    public partial class ViewAllTeam : Form {
        private List<Team> teams = null;
        private readonly IRepositoryTeam repository;

        private readonly IRepositoryPlayer repositoryPlayer;
        private readonly IRepositoryContractPlayer contractPlayer;

        private readonly IRepositoryCoach repositoryCoach;
        private readonly IRepositoryContractCoach contractCoach;

        public ViewAllTeam() {
            InitializeComponent();
            repository = new DBRepositoryTeam();

            repositoryCoach = new DBRepositoryCoach();
            contractCoach = new DBRepositoryContractCoach();

            repositoryPlayer = new DBRepositoryPlayer();
            contractPlayer = new DBRepositoryContractPlayer();
        }

        private void ViewAllTeam_Load(object sender, EventArgs e) {
            FillTable(String.Empty);
        }

        private void FillTable(string teamName) {
            if (teamName == String.Empty) {
                if ((teams = repository.GetAllTeams()) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            } else {
                if ((teams = repository.GetTeams(teamName)) == null) {
                    MessageBox.Show("Can`t get info from repository", "Error!");
                    return;
                }
            }

            for (int i = 0; i < teams.Count; i++) {
                Coach coach;
                List<string> players = null;
                AllTeamTable.Rows.Add();

                AllTeamTable.Rows[i].Cells[0].Value = teams[i].Name;                                                //name
                AllTeamTable.Rows[i].Cells[1].Value = teams[i].WorldRank;                                           //rank
                if ((coach = repositoryCoach.GetCoache(contractCoach.GetCoachIdByIdTeam(teams[i].Id))) != null) {
                    AllTeamTable.Rows[i].Cells[2].Value = coach.NickName + " (" + coach.Name + ")";                 //coach
                } else {
                    AllTeamTable.Rows[i].Cells[2].Value = String.Empty;                                             //coach
                }
                if ((players = contractPlayer.GetIdPlayerByTeamId(teams[i].Id)) != null && players.Count > 0) {
                    string main = "Main players: ";
                    string reserve = "Reserve players: ";
                    foreach (string s in players) {
                        Player player = null;
                        int.TryParse(s.Substring(0, s.IndexOf(":")), out int id);
                        int.TryParse(s.Substring(s.IndexOf(":") + 1), out int isMain);
                        if ((player = repositoryPlayer.GetPlayerById(id)) != null) {
                            if (isMain == 1) {
                                main += "\n\t" + player.NickName;
                            } else {
                                reserve += "\n\t" + player.NickName;
                            }
                        }
                    }
                    AllTeamTable.Rows[i].Cells[3].Value = main + ". \n" + reserve;                                    //players
                } else {
                    AllTeamTable.Rows[i].Cells[3].Value = String.Empty;                                             //players
                }
            }
        }
    }
}
