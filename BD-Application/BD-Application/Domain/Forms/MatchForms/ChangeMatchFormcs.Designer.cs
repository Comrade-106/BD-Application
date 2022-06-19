
namespace BD_Application.Domain.Forms.MatchForms {
    partial class ChangeMatchForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this._tournamentBox = new System.Windows.Forms.TextBox();
            this._stageBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._dateBox = new System.Windows.Forms.DateTimePicker();
            this._team1Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._team2Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._score1Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._score2Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this._closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Турнир";
            // 
            // _tournamentBox
            // 
            this._tournamentBox.Location = new System.Drawing.Point(96, 6);
            this._tournamentBox.Name = "_tournamentBox";
            this._tournamentBox.ReadOnly = true;
            this._tournamentBox.Size = new System.Drawing.Size(277, 22);
            this._tournamentBox.TabIndex = 1;
            // 
            // _stageBox
            // 
            this._stageBox.Location = new System.Drawing.Point(96, 34);
            this._stageBox.Name = "_stageBox";
            this._stageBox.ReadOnly = true;
            this._stageBox.Size = new System.Drawing.Size(277, 22);
            this._stageBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Этап";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата";
            // 
            // _dataBox
            // 
            this._dateBox.Location = new System.Drawing.Point(96, 65);
            this._dateBox.Name = "_dataBox";
            this._dateBox.Size = new System.Drawing.Size(277, 22);
            this._dateBox.TabIndex = 5;
            // 
            // _team1Box
            // 
            this._team1Box.Location = new System.Drawing.Point(96, 93);
            this._team1Box.Name = "_team1Box";
            this._team1Box.ReadOnly = true;
            this._team1Box.Size = new System.Drawing.Size(277, 22);
            this._team1Box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Команда 1";
            // 
            // _team2Box
            // 
            this._team2Box.Location = new System.Drawing.Point(96, 121);
            this._team2Box.Name = "_team2Box";
            this._team2Box.ReadOnly = true;
            this._team2Box.Size = new System.Drawing.Size(277, 22);
            this._team2Box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Команда 2";
            // 
            // _score1Box
            // 
            this._score1Box.Location = new System.Drawing.Point(96, 149);
            this._score1Box.Name = "_score1Box";
            this._score1Box.Size = new System.Drawing.Size(50, 22);
            this._score1Box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Счет";
            // 
            // _score2Box
            // 
            this._score2Box.Location = new System.Drawing.Point(162, 149);
            this._score2Box.Name = "_score2Box";
            this._score2Box.Size = new System.Drawing.Size(50, 22);
            this._score2Box.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(98, 191);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(93, 42);
            this._saveButton.TabIndex = 15;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _closeButton
            // 
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._closeButton.Location = new System.Drawing.Point(197, 191);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(93, 42);
            this._closeButton.TabIndex = 16;
            this._closeButton.Text = "Закрыть";
            this._closeButton.UseVisualStyleBackColor = true;
            // 
            // ChangeMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 245);
            this.Controls.Add(this._closeButton);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._score2Box);
            this.Controls.Add(this._score1Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._team2Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._team1Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._dateBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._stageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._tournamentBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangeMatchForm";
            this.Text = "ChangeMatchFormcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tournamentBox;
        private System.Windows.Forms.TextBox _stageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker _dateBox;
        private System.Windows.Forms.TextBox _team1Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _team2Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _score1Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _score2Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _closeButton;
    }
}