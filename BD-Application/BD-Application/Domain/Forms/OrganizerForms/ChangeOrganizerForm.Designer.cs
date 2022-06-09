namespace BD_Application.Domain.Forms.OrganizerForms {
    partial class ChangeOrganizerForm {
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OrganizerLabel = new System.Windows.Forms.Label();
            this.OrganizerBox = new System.Windows.Forms.ComboBox();
            this.ChangeOrganizerButton = new System.Windows.Forms.Button();
            this.DeleteOrganizerButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 33);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(3, 3);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 22);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(69, 3);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(321, 22);
            this.NameBox.TabIndex = 0;
            // 
            // OrganizerLabel
            // 
            this.OrganizerLabel.Location = new System.Drawing.Point(16, 9);
            this.OrganizerLabel.Name = "OrganizerLabel";
            this.OrganizerLabel.Size = new System.Drawing.Size(60, 22);
            this.OrganizerLabel.TabIndex = 4;
            this.OrganizerLabel.Text = "Organizer";
            this.OrganizerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrganizerBox
            // 
            this.OrganizerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizerBox.FormattingEnabled = true;
            this.OrganizerBox.Location = new System.Drawing.Point(82, 9);
            this.OrganizerBox.Name = "OrganizerBox";
            this.OrganizerBox.Size = new System.Drawing.Size(325, 23);
            this.OrganizerBox.TabIndex = 5;
            this.OrganizerBox.SelectedIndexChanged += new System.EventHandler(this.OrganizerBox_SelectedIndexChanged);
            // 
            // ChangeOrganizerButton
            // 
            this.ChangeOrganizerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeOrganizerButton.Location = new System.Drawing.Point(12, 116);
            this.ChangeOrganizerButton.Name = "ChangeOrganizerButton";
            this.ChangeOrganizerButton.Size = new System.Drawing.Size(142, 28);
            this.ChangeOrganizerButton.TabIndex = 6;
            this.ChangeOrganizerButton.Text = "Change";
            this.ChangeOrganizerButton.UseVisualStyleBackColor = true;
            this.ChangeOrganizerButton.Click += new System.EventHandler(this.ChangeOrganizerButton_Click);
            // 
            // DeleteOrganizerButton
            // 
            this.DeleteOrganizerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteOrganizerButton.Location = new System.Drawing.Point(265, 116);
            this.DeleteOrganizerButton.Name = "DeleteOrganizerButton";
            this.DeleteOrganizerButton.Size = new System.Drawing.Size(142, 28);
            this.DeleteOrganizerButton.TabIndex = 7;
            this.DeleteOrganizerButton.Text = "Delete";
            this.DeleteOrganizerButton.UseVisualStyleBackColor = true;
            this.DeleteOrganizerButton.Click += new System.EventHandler(this.DeleteOrganizerButton_Click);
            // 
            // ChangeOrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 156);
            this.Controls.Add(this.DeleteOrganizerButton);
            this.Controls.Add(this.ChangeOrganizerButton);
            this.Controls.Add(this.OrganizerBox);
            this.Controls.Add(this.OrganizerLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(435, 195);
            this.Name = "ChangeOrganizerForm";
            this.Text = "Change Organizer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label OrganizerLabel;
        private System.Windows.Forms.ComboBox OrganizerBox;
        private System.Windows.Forms.Button ChangeOrganizerButton;
        private System.Windows.Forms.Button DeleteOrganizerButton;
    }
}