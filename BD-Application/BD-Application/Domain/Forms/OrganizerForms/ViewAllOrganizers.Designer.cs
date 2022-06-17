namespace BD_Application.Domain.Forms.OrganizerForms {
    partial class ViewAllOrganizers {
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
            this.name});
            this.CoahesTable.Location = new System.Drawing.Point(12, 12);
            this.CoahesTable.Name = "CoahesTable";
            this.CoahesTable.RowHeadersVisible = false;
            this.CoahesTable.Size = new System.Drawing.Size(558, 311);
            this.CoahesTable.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ViewAllOrganizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 335);
            this.Controls.Add(this.CoahesTable);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewAllOrganizers";
            this.Text = "View organizers";
            this.Load += new System.EventHandler(this.ViewAllOrganizers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoahesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoahesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}