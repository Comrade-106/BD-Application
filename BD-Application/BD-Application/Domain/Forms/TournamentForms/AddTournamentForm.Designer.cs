namespace BD_Application.Domain.Forms.TournamentForms {
    partial class AddTournamentForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateEndBox = new System.Windows.Forms.DateTimePicker();
            this.DateStartBox = new System.Windows.Forms.DateTimePicker();
            this.OrganizerBox = new System.Windows.Forms.ComboBox();
            this.OrganizerLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.PrizePoolLabel = new System.Windows.Forms.Label();
            this.PrizePoolBox = new System.Windows.Forms.TextBox();
            this.AddTournamentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddTournamentButton);
            this.panel1.Controls.Add(this.PrizePoolBox);
            this.panel1.Controls.Add(this.PrizePoolLabel);
            this.panel1.Controls.Add(this.DateEndLabel);
            this.panel1.Controls.Add(this.DateStartLabel);
            this.panel1.Controls.Add(this.DateEndBox);
            this.panel1.Controls.Add(this.DateStartBox);
            this.panel1.Controls.Add(this.OrganizerBox);
            this.panel1.Controls.Add(this.OrganizerLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 274);
            this.panel1.TabIndex = 0;
            // 
            // DateEndBox
            // 
            this.DateEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEndBox.Location = new System.Drawing.Point(102, 88);
            this.DateEndBox.Name = "DateEndBox";
            this.DateEndBox.Size = new System.Drawing.Size(423, 22);
            this.DateEndBox.TabIndex = 5;
            this.DateEndBox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DateStartBox
            // 
            this.DateStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStartBox.Location = new System.Drawing.Point(102, 60);
            this.DateStartBox.Name = "DateStartBox";
            this.DateStartBox.Size = new System.Drawing.Size(423, 22);
            this.DateStartBox.TabIndex = 4;
            this.DateStartBox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // OrganizerBox
            // 
            this.OrganizerBox.FormattingEnabled = true;
            this.OrganizerBox.Location = new System.Drawing.Point(102, 31);
            this.OrganizerBox.Name = "OrganizerBox";
            this.OrganizerBox.Size = new System.Drawing.Size(423, 23);
            this.OrganizerBox.TabIndex = 3;
            // 
            // OrganizerLabel
            // 
            this.OrganizerLabel.Location = new System.Drawing.Point(3, 32);
            this.OrganizerLabel.Name = "OrganizerLabel";
            this.OrganizerLabel.Size = new System.Drawing.Size(93, 22);
            this.OrganizerLabel.TabIndex = 2;
            this.OrganizerLabel.Text = "Organizer";
            this.OrganizerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(102, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(423, 22);
            this.NameBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.Location = new System.Drawing.Point(3, 60);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(93, 22);
            this.DateStartLabel.TabIndex = 6;
            this.DateStartLabel.Text = "Date Start";
            this.DateStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.Location = new System.Drawing.Point(3, 88);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(93, 22);
            this.DateEndLabel.TabIndex = 7;
            this.DateEndLabel.Text = "Date End";
            this.DateEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrizePoolLabel
            // 
            this.PrizePoolLabel.Location = new System.Drawing.Point(3, 116);
            this.PrizePoolLabel.Name = "PrizePoolLabel";
            this.PrizePoolLabel.Size = new System.Drawing.Size(93, 22);
            this.PrizePoolLabel.TabIndex = 8;
            this.PrizePoolLabel.Text = "Prize Pool";
            this.PrizePoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrizePoolBox
            // 
            this.PrizePoolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizePoolBox.Location = new System.Drawing.Point(102, 116);
            this.PrizePoolBox.Name = "PrizePoolBox";
            this.PrizePoolBox.Size = new System.Drawing.Size(423, 22);
            this.PrizePoolBox.TabIndex = 9;
            // 
            // AddTournamentButton
            // 
            this.AddTournamentButton.Location = new System.Drawing.Point(3, 239);
            this.AddTournamentButton.Name = "AddTournamentButton";
            this.AddTournamentButton.Size = new System.Drawing.Size(522, 30);
            this.AddTournamentButton.TabIndex = 10;
            this.AddTournamentButton.Text = "Add";
            this.AddTournamentButton.UseVisualStyleBackColor = true;
            this.AddTournamentButton.Click += new System.EventHandler(this.AddTournamentButton_Click);
            // 
            // AddTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 298);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddTournamentForm";
            this.Text = "Add Tournament";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox OrganizerBox;
        private System.Windows.Forms.Label OrganizerLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker DateEndBox;
        private System.Windows.Forms.DateTimePicker DateStartBox;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.TextBox PrizePoolBox;
        private System.Windows.Forms.Label PrizePoolLabel;
        private System.Windows.Forms.Button AddTournamentButton;
    }
}