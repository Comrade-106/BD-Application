namespace BD_Application.Domain {
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
            this.PlayerBox = new System.Windows.Forms.ComboBox();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConcractButton = new System.Windows.Forms.Button();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.BirthDayBox = new System.Windows.Forms.DateTimePicker();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NickNameBox = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.ChangePlayerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerBox
            // 
            this.PlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Location = new System.Drawing.Point(81, 9);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(370, 23);
            this.PlayerBox.TabIndex = 3;
            this.PlayerBox.SelectedIndexChanged += new System.EventHandler(this.PlayerBox_SelectedIndexChanged);
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.Location = new System.Drawing.Point(15, 8);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(48, 23);
            this.PlayerLabel.TabIndex = 2;
            this.PlayerLabel.Text = "Player";
            this.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ConcractButton);
            this.panel1.Controls.Add(this.BirthdayLabel);
            this.panel1.Controls.Add(this.BirthDayBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NickNameBox);
            this.panel1.Controls.Add(this.NickNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 133);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // ConcractButton
            // 
            this.ConcractButton.Location = new System.Drawing.Point(253, 94);
            this.ConcractButton.Name = "ConcractButton";
            this.ConcractButton.Size = new System.Drawing.Size(184, 29);
            this.ConcractButton.TabIndex = 14;
            this.ConcractButton.Text = "Change Contract";
            this.ConcractButton.UseVisualStyleBackColor = true;
            this.ConcractButton.Click += new System.EventHandler(this.ConcractButton_Click);
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
            this.BirthDayBox.Location = new System.Drawing.Point(69, 66);
            this.BirthDayBox.Name = "BirthDayBox";
            this.BirthDayBox.Size = new System.Drawing.Size(368, 22);
            this.BirthDayBox.TabIndex = 12;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(69, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(368, 22);
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
            this.NickNameBox.Size = new System.Drawing.Size(368, 22);
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
            // ChangePlayerButton
            // 
            this.ChangePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePlayerButton.Location = new System.Drawing.Point(15, 186);
            this.ChangePlayerButton.Name = "ChangePlayerButton";
            this.ChangePlayerButton.Size = new System.Drawing.Size(439, 32);
            this.ChangePlayerButton.TabIndex = 5;
            this.ChangePlayerButton.Text = "Change";
            this.ChangePlayerButton.UseVisualStyleBackColor = true;
            this.ChangePlayerButton.Click += new System.EventHandler(this.ChangePlayerButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Contract";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ChangePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 230);
            this.Controls.Add(this.ChangePlayerButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.PlayerLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChangePlayerForm";
            this.Text = "Change PLayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PlayerBox;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangePlayerButton;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.DateTimePicker BirthDayBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NickNameBox;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.Button ConcractButton;
        private System.Windows.Forms.Button button1;
    }
}