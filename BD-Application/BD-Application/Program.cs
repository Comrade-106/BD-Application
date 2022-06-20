using System;
using System.Windows.Forms;

namespace BD_Application {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Domain.Forms.MainMenu());
            //Application.Run(new Domain.Forms.TournamentForms.ChangeTournamentForm());
            //Application.Run(new Domain.Forms.TournamentForms.ViewTournamenrResult());
        }
    }
}
