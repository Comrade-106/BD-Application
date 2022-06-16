namespace BD_Application.Domain.Forms.ContractPlayerTeamForms {
    partial class AddPlayerTeamContractForm {
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
            this.MainPlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.ReservePlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.AddPlayerContractButton = new System.Windows.Forms.Button();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDateBox = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateBox = new System.Windows.Forms.DateTimePicker();
            this.TeamLable = new System.Windows.Forms.Label();
            this.TeamBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MainPlayerRadioButton);
            this.panel1.Controls.Add(this.ReservePlayerRadioButton);
            this.panel1.Controls.Add(this.AddPlayerContractButton);
            this.panel1.Controls.Add(this.SalaryBox);
            this.panel1.Controls.Add(this.SalaryLabel);
            this.panel1.Controls.Add(this.EndDateLabel);
            this.panel1.Controls.Add(this.EndDateBox);
            this.panel1.Controls.Add(this.StartDateLabel);
            this.panel1.Controls.Add(this.StartDateBox);
            this.panel1.Controls.Add(this.TeamLable);
            this.panel1.Controls.Add(this.TeamBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 242);
            this.panel1.TabIndex = 0;
            // 
            // MainPlayerRadioButton
            // 
            this.MainPlayerRadioButton.AutoSize = true;
            this.MainPlayerRadioButton.Location = new System.Drawing.Point(86, 145);
            this.MainPlayerRadioButton.Name = "MainPlayerRadioButton";
            this.MainPlayerRadioButton.Size = new System.Drawing.Size(89, 19);
            this.MainPlayerRadioButton.TabIndex = 13;
            this.MainPlayerRadioButton.TabStop = true;
            this.MainPlayerRadioButton.Text = "Main player";
            this.MainPlayerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReservePlayerRadioButton
            // 
            this.ReservePlayerRadioButton.AutoSize = true;
            this.ReservePlayerRadioButton.Location = new System.Drawing.Point(86, 170);
            this.ReservePlayerRadioButton.Name = "ReservePlayerRadioButton";
            this.ReservePlayerRadioButton.Size = new System.Drawing.Size(104, 19);
            this.ReservePlayerRadioButton.TabIndex = 12;
            this.ReservePlayerRadioButton.TabStop = true;
            this.ReservePlayerRadioButton.Text = "Reserve player";
            this.ReservePlayerRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddPlayerContractButton
            // 
            this.AddPlayerContractButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlayerContractButton.Location = new System.Drawing.Point(3, 203);
            this.AddPlayerContractButton.Name = "AddPlayerContractButton";
            this.AddPlayerContractButton.Size = new System.Drawing.Size(432, 34);
            this.AddPlayerContractButton.TabIndex = 11;
            this.AddPlayerContractButton.Text = "Add";
            this.AddPlayerContractButton.UseVisualStyleBackColor = true;
            this.AddPlayerContractButton.Click += new System.EventHandler(this.AddPlayerContractButton_Click);
            // 
            // SalaryBox
            // 
            this.SalaryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaryBox.Location = new System.Drawing.Point(86, 117);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(349, 22);
            this.SalaryBox.TabIndex = 10;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.Location = new System.Drawing.Point(3, 117);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(77, 23);
            this.SalaryLabel.TabIndex = 9;
            this.SalaryLabel.Text = "Salary";
            this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.Location = new System.Drawing.Point(3, 89);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(77, 22);
            this.EndDateLabel.TabIndex = 7;
            this.EndDateLabel.Text = "To";
            this.EndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndDateBox
            // 
            this.EndDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateBox.Location = new System.Drawing.Point(86, 89);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.Size = new System.Drawing.Size(349, 22);
            this.EndDateBox.TabIndex = 6;
            this.EndDateBox.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.Location = new System.Drawing.Point(3, 61);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(77, 22);
            this.StartDateLabel.TabIndex = 5;
            this.StartDateLabel.Text = "From";
            this.StartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartDateBox
            // 
            this.StartDateBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateBox.Location = new System.Drawing.Point(86, 61);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.Size = new System.Drawing.Size(349, 22);
            this.StartDateBox.TabIndex = 4;
            this.StartDateBox.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // TeamLable
            // 
            this.TeamLable.Location = new System.Drawing.Point(3, 32);
            this.TeamLable.Name = "TeamLable";
            this.TeamLable.Size = new System.Drawing.Size(77, 23);
            this.TeamLable.TabIndex = 3;
            this.TeamLable.Text = "Team";
            this.TeamLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TeamBox
            // 
            this.TeamBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamBox.FormattingEnabled = true;
            this.TeamBox.Location = new System.Drawing.Point(86, 32);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(349, 23);
            this.TeamBox.TabIndex = 2;
            // 
            // AddPlayerTeamContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 266);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(480, 305);
            this.Name = "AddPlayerTeamContractForm";
            this.Text = "Player`s contracts";
            this.Load += new System.EventHandler(this.AddPlayerTeamContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker StartDateBox;
        private System.Windows.Forms.Label TeamLable;
        private System.Windows.Forms.ComboBox TeamBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDateBox;
        private System.Windows.Forms.TextBox SalaryBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Button AddPlayerContractButton;
        private System.Windows.Forms.RadioButton MainPlayerRadioButton;
        private System.Windows.Forms.RadioButton ReservePlayerRadioButton;
    }
}