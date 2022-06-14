namespace BD_Application.Domain.Forms.TournamentForms {
    partial class ChangeTournamentForm {
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
            this.PrizePoolBox = new System.Windows.Forms.TextBox();
            this.PrizePoolLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateEndBox = new System.Windows.Forms.DateTimePicker();
            this.DateStartBox = new System.Windows.Forms.DateTimePicker();
            this.OrganizerBox = new System.Windows.Forms.ComboBox();
            this.OrganizerLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TournamentBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(8, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // PrizePoolBox
            // 
            this.PrizePoolBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrizePoolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizePoolBox.Location = new System.Drawing.Point(102, 116);
            this.PrizePoolBox.Name = "PrizePoolBox";
            this.PrizePoolBox.Size = new System.Drawing.Size(388, 22);
            this.PrizePoolBox.TabIndex = 9;
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
            // DateEndLabel
            // 
            this.DateEndLabel.Location = new System.Drawing.Point(3, 88);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(93, 22);
            this.DateEndLabel.TabIndex = 7;
            this.DateEndLabel.Text = "Date End";
            this.DateEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // DateEndBox
            // 
            this.DateEndBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateEndBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEndBox.Location = new System.Drawing.Point(102, 88);
            this.DateEndBox.Name = "DateEndBox";
            this.DateEndBox.Size = new System.Drawing.Size(388, 22);
            this.DateEndBox.TabIndex = 5;
            this.DateEndBox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // DateStartBox
            // 
            this.DateStartBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateStartBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateStartBox.Location = new System.Drawing.Point(102, 60);
            this.DateStartBox.Name = "DateStartBox";
            this.DateStartBox.Size = new System.Drawing.Size(388, 22);
            this.DateStartBox.TabIndex = 4;
            this.DateStartBox.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // OrganizerBox
            // 
            this.OrganizerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerBox.FormattingEnabled = true;
            this.OrganizerBox.Location = new System.Drawing.Point(102, 31);
            this.OrganizerBox.Name = "OrganizerBox";
            this.OrganizerBox.Size = new System.Drawing.Size(388, 23);
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
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(102, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(388, 22);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tournament";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TournamentBox
            // 
            this.TournamentBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TournamentBox.FormattingEnabled = true;
            this.TournamentBox.Location = new System.Drawing.Point(111, 8);
            this.TournamentBox.Name = "TournamentBox";
            this.TournamentBox.Size = new System.Drawing.Size(388, 23);
            this.TournamentBox.TabIndex = 4;
            this.TournamentBox.SelectedIndexChanged += new System.EventHandler(this.TournamentBox_SelectedIndexChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeButton.Location = new System.Drawing.Point(12, 190);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(193, 29);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(306, 190);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(193, 29);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 231);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.TournamentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(535, 270);
            this.Name = "ChangeTournamentForm";
            this.Text = "Change Tournament";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PrizePoolBox;
        private System.Windows.Forms.Label PrizePoolLabel;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.DateTimePicker DateEndBox;
        private System.Windows.Forms.DateTimePicker DateStartBox;
        private System.Windows.Forms.ComboBox OrganizerBox;
        private System.Windows.Forms.Label OrganizerLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TournamentBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}