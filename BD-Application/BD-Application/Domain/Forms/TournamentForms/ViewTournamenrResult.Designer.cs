namespace BD_Application.Domain.Forms.TournamentForms {
    partial class ViewTournamenrResult {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.resultsTable = new System.Windows.Forms.DataGridView();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsTable
            // 
            this.resultsTable.AllowUserToAddRows = false;
            this.resultsTable.AllowUserToDeleteRows = false;
            this.resultsTable.AllowUserToResizeColumns = false;
            this.resultsTable.AllowUserToResizeRows = false;
            this.resultsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.resultsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place,
            this.team,
            this.prize});
            this.resultsTable.Location = new System.Drawing.Point(12, 12);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowHeadersVisible = false;
            this.resultsTable.RowHeadersWidth = 51;
            this.resultsTable.Size = new System.Drawing.Size(668, 321);
            this.resultsTable.TabIndex = 3;
            this.resultsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoahesTable_CellContentClick);
            // 
            // place
            // 
            this.place.HeaderText = "Place";
            this.place.MinimumWidth = 6;
            this.place.Name = "place";
            // 
            // team
            // 
            this.team.HeaderText = "Team";
            this.team.MinimumWidth = 6;
            this.team.Name = "team";
            // 
            // prize
            // 
            this.prize.HeaderText = "Prize";
            this.prize.MinimumWidth = 6;
            this.prize.Name = "prize";
            // 
            // ViewTournamenrResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 345);
            this.Controls.Add(this.resultsTable);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewTournamenrResult";
            this.Text = "Tournamenr result";
            ((System.ComponentModel.ISupportInitialize)(this.resultsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.DataGridViewTextBoxColumn prize;
    }
}