namespace BD_Application.Domain.Forms {
    partial class MainMenu {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlayer = new System.Windows.Forms.TabPage();
            this.FilterPlayerBox = new System.Windows.Forms.TextBox();
            this.ViewPlayerButton = new System.Windows.Forms.Button();
            this.PanelPlayer = new System.Windows.Forms.Panel();
            this.PlayerInfo = new System.Windows.Forms.Label();
            this.PlayersTable = new System.Windows.Forms.DataGridView();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewAllPlayerButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.ChangePlayerButton = new System.Windows.Forms.Button();
            this.PlayerBox = new System.Windows.Forms.ComboBox();
            this.tabCoach = new System.Windows.Forms.TabPage();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.tabOrganizer = new System.Windows.Forms.TabPage();
            this.tabTournament = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPlayer.SuspendLayout();
            this.PanelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 431);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPlayer);
            this.tabControl1.Controls.Add(this.tabCoach);
            this.tabControl1.Controls.Add(this.tabTeam);
            this.tabControl1.Controls.Add(this.tabOrganizer);
            this.tabControl1.Controls.Add(this.tabTournament);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 423);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPlayer
            // 
            this.tabPlayer.Controls.Add(this.FilterPlayerBox);
            this.tabPlayer.Controls.Add(this.ViewPlayerButton);
            this.tabPlayer.Controls.Add(this.PanelPlayer);
            this.tabPlayer.Controls.Add(this.ViewAllPlayerButton);
            this.tabPlayer.Controls.Add(this.AddPlayerButton);
            this.tabPlayer.Controls.Add(this.ChangePlayerButton);
            this.tabPlayer.Controls.Add(this.PlayerBox);
            this.tabPlayer.Location = new System.Drawing.Point(4, 24);
            this.tabPlayer.Name = "tabPlayer";
            this.tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayer.Size = new System.Drawing.Size(700, 395);
            this.tabPlayer.TabIndex = 0;
            this.tabPlayer.Text = "Player";
            this.tabPlayer.UseVisualStyleBackColor = true;
            // 
            // FilterPlayerBox
            // 
            this.FilterPlayerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterPlayerBox.ForeColor = System.Drawing.Color.Silver;
            this.FilterPlayerBox.Location = new System.Drawing.Point(435, 7);
            this.FilterPlayerBox.Name = "FilterPlayerBox";
            this.FilterPlayerBox.Size = new System.Drawing.Size(259, 22);
            this.FilterPlayerBox.TabIndex = 6;
            this.FilterPlayerBox.Text = "Enter player nickname to filter info";
            this.FilterPlayerBox.Click += new System.EventHandler(this.FilterPlayerBox_Click);
            this.FilterPlayerBox.Leave += new System.EventHandler(this.FilterPlayerBox_Leave);
            // 
            // ViewPlayerButton
            // 
            this.ViewPlayerButton.Location = new System.Drawing.Point(292, 35);
            this.ViewPlayerButton.Name = "ViewPlayerButton";
            this.ViewPlayerButton.Size = new System.Drawing.Size(137, 37);
            this.ViewPlayerButton.TabIndex = 2;
            this.ViewPlayerButton.Text = "View player`s info";
            this.ViewPlayerButton.UseVisualStyleBackColor = true;
            this.ViewPlayerButton.Click += new System.EventHandler(this.ViewPlayerButton_Click);
            // 
            // PanelPlayer
            // 
            this.PanelPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPlayer.Controls.Add(this.PlayerInfo);
            this.PanelPlayer.Controls.Add(this.PlayersTable);
            this.PanelPlayer.Location = new System.Drawing.Point(6, 78);
            this.PanelPlayer.Name = "PanelPlayer";
            this.PanelPlayer.Size = new System.Drawing.Size(688, 311);
            this.PanelPlayer.TabIndex = 5;
            this.PanelPlayer.Visible = false;
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.Location = new System.Drawing.Point(14, 16);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(660, 279);
            this.PlayerInfo.TabIndex = 7;
            // 
            // PlayersTable
            // 
            this.PlayersTable.AllowUserToAddRows = false;
            this.PlayersTable.AllowUserToDeleteRows = false;
            this.PlayersTable.AllowUserToResizeColumns = false;
            this.PlayersTable.AllowUserToResizeRows = false;
            this.PlayersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlayersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.PlayersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlayersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nickname,
            this.name,
            this.birthday,
            this.team});
            this.PlayersTable.Location = new System.Drawing.Point(3, 3);
            this.PlayersTable.Name = "PlayersTable";
            this.PlayersTable.RowHeadersVisible = false;
            this.PlayersTable.Size = new System.Drawing.Size(682, 305);
            this.PlayersTable.TabIndex = 3;
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Nickname";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // birthday
            // 
            this.birthday.HeaderText = "Birthday";
            this.birthday.Name = "birthday";
            // 
            // team
            // 
            this.team.HeaderText = "Team";
            this.team.Name = "team";
            this.team.ReadOnly = true;
            // 
            // ViewAllPlayerButton
            // 
            this.ViewAllPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewAllPlayerButton.Location = new System.Drawing.Point(494, 35);
            this.ViewAllPlayerButton.Name = "ViewAllPlayerButton";
            this.ViewAllPlayerButton.Size = new System.Drawing.Size(137, 37);
            this.ViewAllPlayerButton.TabIndex = 4;
            this.ViewAllPlayerButton.Text = "View all player`s info";
            this.ViewAllPlayerButton.UseVisualStyleBackColor = true;
            this.ViewAllPlayerButton.Click += new System.EventHandler(this.ViewAllPlayerButton_Click);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(6, 35);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(137, 37);
            this.AddPlayerButton.TabIndex = 0;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // ChangePlayerButton
            // 
            this.ChangePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePlayerButton.Location = new System.Drawing.Point(149, 35);
            this.ChangePlayerButton.Name = "ChangePlayerButton";
            this.ChangePlayerButton.Size = new System.Drawing.Size(137, 37);
            this.ChangePlayerButton.TabIndex = 1;
            this.ChangePlayerButton.Text = "Change player`s info";
            this.ChangePlayerButton.UseVisualStyleBackColor = true;
            this.ChangePlayerButton.Click += new System.EventHandler(this.ChangePlayerButton_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Items.AddRange(new object[] {
            "Player",
            "Coach",
            "Team",
            "Organizer",
            "Tournament"});
            this.PlayerBox.Location = new System.Drawing.Point(6, 6);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(423, 23);
            this.PlayerBox.TabIndex = 3;
            // 
            // tabCoach
            // 
            this.tabCoach.Location = new System.Drawing.Point(4, 24);
            this.tabCoach.Name = "tabCoach";
            this.tabCoach.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoach.Size = new System.Drawing.Size(700, 395);
            this.tabCoach.TabIndex = 1;
            this.tabCoach.Text = "Coach";
            this.tabCoach.UseVisualStyleBackColor = true;
            // 
            // tabTeam
            // 
            this.tabTeam.Location = new System.Drawing.Point(4, 24);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Size = new System.Drawing.Size(700, 395);
            this.tabTeam.TabIndex = 2;
            this.tabTeam.Text = "Team";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // tabOrganizer
            // 
            this.tabOrganizer.Location = new System.Drawing.Point(4, 24);
            this.tabOrganizer.Name = "tabOrganizer";
            this.tabOrganizer.Size = new System.Drawing.Size(700, 395);
            this.tabOrganizer.TabIndex = 3;
            this.tabOrganizer.Text = "Organizer";
            this.tabOrganizer.UseVisualStyleBackColor = true;
            // 
            // tabTournament
            // 
            this.tabTournament.Location = new System.Drawing.Point(4, 24);
            this.tabTournament.Name = "tabTournament";
            this.tabTournament.Size = new System.Drawing.Size(700, 395);
            this.tabTournament.TabIndex = 4;
            this.tabTournament.Text = "Tournament";
            this.tabTournament.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(285, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 455);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPlayer.ResumeLayout(false);
            this.tabPlayer.PerformLayout();
            this.PanelPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewPlayerButton;
        private System.Windows.Forms.Button ChangePlayerButton;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.ComboBox PlayerBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlayer;
        private System.Windows.Forms.TabPage tabCoach;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.TabPage tabOrganizer;
        private System.Windows.Forms.TabPage tabTournament;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ViewAllPlayerButton;
        private System.Windows.Forms.Panel PanelPlayer;
        private System.Windows.Forms.DataGridView PlayersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.TextBox FilterPlayerBox;
        private System.Windows.Forms.Label PlayerInfo;
    }
}