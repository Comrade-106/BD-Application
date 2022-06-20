namespace BD_Application.Domain.Forms.TournamentForms {
    partial class ViewAllTournament {
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
            this.CoahesTable = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prize_pool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CoahesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CoahesTable
            // 
            this.CoahesTable.AllowUserToAddRows = false;
            this.CoahesTable.AllowUserToDeleteRows = false;
            this.CoahesTable.AllowUserToResizeColumns = false;
            this.CoahesTable.AllowUserToResizeRows = false;
            this.CoahesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoahesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoahesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.CoahesTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoahesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoahesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.organizer,
            this.date_start,
            this.date_end,
            this.prize_pool});
            this.CoahesTable.Location = new System.Drawing.Point(12, 12);
            this.CoahesTable.Name = "CoahesTable";
            this.CoahesTable.RowHeadersVisible = false;
            this.CoahesTable.Size = new System.Drawing.Size(523, 315);
            this.CoahesTable.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // organizer
            // 
            this.organizer.HeaderText = "Organizer";
            this.organizer.Name = "organizer";
            this.organizer.ReadOnly = true;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Date start";
            this.date_start.Name = "date_start";
            // 
            // date_end
            // 
            this.date_end.HeaderText = "Date end";
            this.date_end.Name = "date_end";
            this.date_end.ReadOnly = true;
            // 
            // prize_pool
            // 
            this.prize_pool.HeaderText = "Prize pool";
            this.prize_pool.Name = "prize_pool";
            this.prize_pool.ReadOnly = true;
            // 
            // ViewAllTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 339);
            this.Controls.Add(this.CoahesTable);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewAllTournament";
            this.Text = "View tournament";
            this.Load += new System.EventHandler(this.ViewAllTournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoahesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoahesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn prize_pool;
    }
}