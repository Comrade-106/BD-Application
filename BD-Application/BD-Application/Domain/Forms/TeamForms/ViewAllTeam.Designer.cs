namespace BD_Application.Domain.Forms.TeamForms {
    partial class ViewAllTeam {
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
            this.AllTeamTable = new System.Windows.Forms.DataGridView();
            this.team_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.world_rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllTeamTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllTeamTable
            // 
            this.AllTeamTable.AllowUserToAddRows = false;
            this.AllTeamTable.AllowUserToDeleteRows = false;
            this.AllTeamTable.AllowUserToResizeColumns = false;
            this.AllTeamTable.AllowUserToResizeRows = false;
            this.AllTeamTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllTeamTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllTeamTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.AllTeamTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllTeamTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllTeamTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_name,
            this.world_rank,
            this.coach,
            this.players});
            this.AllTeamTable.Location = new System.Drawing.Point(12, 12);
            this.AllTeamTable.Name = "AllTeamTable";
            this.AllTeamTable.RowHeadersVisible = false;
            this.AllTeamTable.Size = new System.Drawing.Size(593, 275);
            this.AllTeamTable.TabIndex = 0;
            // 
            // team_name
            // 
            this.team_name.HeaderText = "Team`s name";
            this.team_name.Name = "team_name";
            this.team_name.ReadOnly = true;
            // 
            // world_rank
            // 
            this.world_rank.HeaderText = "World rank";
            this.world_rank.Name = "world_rank";
            this.world_rank.ReadOnly = true;
            // 
            // coach
            // 
            this.coach.HeaderText = "Coach";
            this.coach.Name = "coach";
            // 
            // players
            // 
            this.players.HeaderText = "Players";
            this.players.Name = "players";
            this.players.ReadOnly = true;
            // 
            // ViewAllTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 299);
            this.Controls.Add(this.AllTeamTable);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewAllTeam";
            this.Text = "View teams";
            this.Load += new System.EventHandler(this.ViewAllTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllTeamTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllTeamTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn world_rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn players;
    }
}