namespace BD_Application.Domain.Forms.PlayerForms {
    partial class ChangePlayerForm {
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
            this.ChangePlayerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddChangeContractButton = new System.Windows.Forms.Button();
            this.TerminateContractButton = new System.Windows.Forms.Button();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthDayBox = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangePlayerButton
            // 
            this.ChangePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangePlayerButton.Location = new System.Drawing.Point(9, 192);
            this.ChangePlayerButton.Name = "ChangePlayerButton";
            this.ChangePlayerButton.Size = new System.Drawing.Size(191, 32);
            this.ChangePlayerButton.TabIndex = 9;
            this.ChangePlayerButton.Text = "Change";
            this.ChangePlayerButton.UseVisualStyleBackColor = true;
            this.ChangePlayerButton.Click += new System.EventHandler(this.ChangePlayerButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddChangeContractButton);
            this.panel1.Controls.Add(this.TerminateContractButton);
            this.panel1.Controls.Add(this.BirthdayLabel);
            this.panel1.Controls.Add(this.BirthDayBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.NickNameLabel);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 160);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // AddChangeContractButton
            // 
            this.AddChangeContractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddChangeContractButton.Location = new System.Drawing.Point(6, 121);
            this.AddChangeContractButton.Name = "AddChangeContractButton";
            this.AddChangeContractButton.Size = new System.Drawing.Size(184, 29);
            this.AddChangeContractButton.TabIndex = 15;
            this.AddChangeContractButton.Text = "Add/Change Contract";
            this.AddChangeContractButton.UseVisualStyleBackColor = true;
            this.AddChangeContractButton.Click += new System.EventHandler(this.AddChangeContractButton_Click);
            // 
            // TerminateContractButton
            // 
            this.TerminateContractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TerminateContractButton.Location = new System.Drawing.Point(209, 121);
            this.TerminateContractButton.Name = "TerminateContractButton";
            this.TerminateContractButton.Size = new System.Drawing.Size(184, 29);
            this.TerminateContractButton.TabIndex = 14;
            this.TerminateContractButton.Text = "Terminate Contract";
            this.TerminateContractButton.UseVisualStyleBackColor = true;
            this.TerminateContractButton.Click += new System.EventHandler(this.TerminateConcractButton_Click);
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Location = new System.Drawing.Point(3, 66);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(60, 22);
            this.BirthdayLabel.TabIndex = 13;
            this.BirthdayLabel.Text = "Birthday";
            this.BirthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BirthDayBox
            // 
            this.BirthDayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDayBox.Location = new System.Drawing.Point(69, 66);
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(324, 22);
            this.BirthDayBox.TabIndex = 12;
            this.BirthDayBox.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(69, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(324, 22);
            this.NameBox.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(3, 38);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 22);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NickNameBox
            // 
            this.NickNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NickNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NickNameBox.Location = new System.Drawing.Point(69, 10);
            this.NickNameBox.Name = "NickNameBox";
            this.NickNameBox.Size = new System.Drawing.Size(324, 22);
            this.NickNameBox.TabIndex = 9;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.Location = new System.Drawing.Point(3, 10);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(60, 22);
            this.NickNameLabel.TabIndex = 8;
            this.NickNameLabel.Text = "Nickname";
            this.NickNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePlayerButton.Location = new System.Drawing.Point(219, 195);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(188, 29);
            this.DeletePlayerButton.TabIndex = 10;
            this.DeletePlayerButton.Text = "Delete";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            this.DeletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // ChangePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 236);
            this.Controls.Add(this.DeletePlayerButton);
            this.Controls.Add(this.ChangePlayerButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(435, 275);
            this.Name = "ChangePlayerForm";
            this.Text = "Change Player";
            this.Load += new System.EventHandler(this.ChangePlayerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePlayerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddChangeContractButton;
        private System.Windows.Forms.Button TerminateContractButton;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthDayBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.Button DeletePlayerButton;
    }
}