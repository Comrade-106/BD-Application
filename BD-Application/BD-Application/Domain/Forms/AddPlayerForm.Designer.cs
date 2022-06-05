
namespace BD_Application.Domain {
    partial class AddPlayerForm {
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
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthDayBox = new System.Windows.Forms.DateTimePicker();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.TeamBox = new System.Windows.Forms.ComboBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.Location = new System.Drawing.Point(12, 12);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(60, 22);
            this.NickNameLabel.TabIndex = 0;
            this.NickNameLabel.Text = "Nickname";
            this.NickNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NickNameBox
            // 
            this.NickNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NickNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickNameBox.Location = new System.Drawing.Point(96, 12);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(309, 22);
            this.NickNameBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(96, 40);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(309, 22);
            this.NameBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(12, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDayBox.Location = new System.Drawing.Point(96, 68);
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(309, 22);
            this.BirthDayBox.TabIndex = 4;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(12, 68);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(60, 22);
            this.BirthdayLabel.TabIndex = 5;
            this.BirthdayLabel.Text = "Birthday";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TeamLabel
            // 
            this.TeamLabel.Location = new System.Drawing.Point(12, 96);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(60, 22);
            this.TeamLabel.TabIndex = 6;
            this.TeamLabel.Text = "Team";
            this.TeamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.FormattingEnabled = true;
            this.TeamBox.Location = new System.Drawing.Point(96, 97);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(309, 23);
            this.TeamBox.TabIndex = 7;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlayerButton.Location = new System.Drawing.Point(15, 126);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(390, 32);
            this.AddPlayerButton.TabIndex = 8;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 171);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.BirthdayLabel);
            this.Controls.Add(this.BirthDayBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NickNameBox);
            this.Controls.Add(this.NickNameLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(430, 210);
            this.Name = "AddPlayerForm";
            this.Text = "Add Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker BirthDayBox;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.ComboBox TeamBox;
        private System.Windows.Forms.Button AddPlayerButton;
    }
}