namespace BD_Application.Domain.Forms.CoachForms {
    partial class ChangeCoachForm {
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
            this.CoachBox = new System.Windows.Forms.ComboBox();
            this.CoachLabel = new System.Windows.Forms.Label();
            this.DeleteCoachButton = new System.Windows.Forms.Button();
            this.ChangePlayerButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddContractButton = new System.Windows.Forms.Button();
            this.ChangeConcractButton = new System.Windows.Forms.Button();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthdayBox = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoachBox
            // 
            this.CoachBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoachBox.FormattingEnabled = true;
            this.CoachBox.Location = new System.Drawing.Point(79, 9);
            this.CoachBox.Name = "CoachBox";
            this.CoachBox.Size = new System.Drawing.Size(328, 23);
            this.CoachBox.TabIndex = 9;
            this.CoachBox.SelectedIndexChanged += new System.EventHandler(this.CoachBox_SelectedIndexChanged);
            // 
            // CoachLabel
            // 
            this.CoachLabel.Location = new System.Drawing.Point(12, 9);
            this.CoachLabel.Name = "CoachLabel";
            this.CoachLabel.Size = new System.Drawing.Size(48, 23);
            this.CoachLabel.TabIndex = 8;
            this.CoachLabel.Text = "Coach";
            this.CoachLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteCoachButton
            // 
            this.DeleteCoachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCoachButton.Location = new System.Drawing.Point(219, 192);
            this.DeleteCoachButton.Name = "DeleteCoachButton";
            this.DeleteCoachButton.Size = new System.Drawing.Size(188, 32);
            this.DeleteCoachButton.TabIndex = 10;
            this.DeleteCoachButton.Text = "Delete";
            this.DeleteCoachButton.UseVisualStyleBackColor = true;
            this.DeleteCoachButton.Click += new System.EventHandler(this.DeleteCoachButton_Click);
            // 
            // ChangePlayerButton
            // 
            this.ChangePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangePlayerButton.Location = new System.Drawing.Point(12, 192);
            this.ChangePlayerButton.Name = "ChangePlayerButton";
            this.ChangePlayerButton.Size = new System.Drawing.Size(188, 32);
            this.ChangePlayerButton.TabIndex = 28;
            this.ChangePlayerButton.Text = "Change";
            this.ChangePlayerButton.UseVisualStyleBackColor = true;
            this.ChangePlayerButton.Click += new System.EventHandler(this.ChangeCoachButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddContractButton);
            this.panel1.Controls.Add(this.ChangeConcractButton);
            this.panel1.Controls.Add(this.BirthdayLabel);
            this.panel1.Controls.Add(this.BirthdayBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.NickNameLabel);
            this.panel1.Location = new System.Drawing.Point(9, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 133);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // AddContractButton
            // 
            this.AddContractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContractButton.Location = new System.Drawing.Point(6, 94);
            this.AddContractButton.Name = "AddContractButton";
            this.AddContractButton.Size = new System.Drawing.Size(184, 29);
            this.AddContractButton.TabIndex = 15;
            this.AddContractButton.Text = "Add Contract";
            this.AddContractButton.UseVisualStyleBackColor = true;
            this.AddContractButton.Click += new System.EventHandler(this.AddConctactButton_Click);
            // 
            // ChangeConcractButton
            // 
            this.ChangeConcractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeConcractButton.Location = new System.Drawing.Point(209, 94);
            this.ChangeConcractButton.Name = "ChangeConcractButton";
            this.ChangeConcractButton.Size = new System.Drawing.Size(184, 29);
            this.ChangeConcractButton.TabIndex = 14;
            this.ChangeConcractButton.Text = "Terminate Contract";
            this.ChangeConcractButton.UseVisualStyleBackColor = true;
            this.ChangeConcractButton.Click += new System.EventHandler(this.TerminateConcractButton_Click);
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
            // BirthdayBox
            // 
            this.BirthdayBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayBox.Location = new System.Drawing.Point(69, 66);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(324, 22);
            this.BirthdayBox.TabIndex = 12;
            this.BirthdayBox.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
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
            // ChangeCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 236);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChangePlayerButton);
            this.Controls.Add(this.DeleteCoachButton);
            this.Controls.Add(this.CoachBox);
            this.Controls.Add(this.CoachLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(435, 275);
            this.Name = "ChangeCoachForm";
            this.Text = "Change Coach";
            this.Load += new System.EventHandler(this.ChangeCoachForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CoachBox;
        private System.Windows.Forms.Label CoachLabel;
        private System.Windows.Forms.Button DeleteCoachButton;
        private System.Windows.Forms.Button ChangePlayerButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddContractButton;
        private System.Windows.Forms.Button ChangeConcractButton;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthdayBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Label NickNameLabel;
    }
}