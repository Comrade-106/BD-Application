using System.Data;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.TournamentForms {
    public partial class ViewTournamenrResult : Form {
        public ViewTournamenrResult(DataTable results) {
            InitializeComponent();
            
            resultsTable.DataSource = null;
            resultsTable.Rows.Clear();
            resultsTable.Columns.Clear();
            
            resultsTable.DataSource = results;
            resultsTable.Visible = true;
        }

        private void CoahesTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
