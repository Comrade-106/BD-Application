namespace BD_Application.Domain {
    partial class DeletePlayerForm {
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
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerBox = new System.Windows.Forms.ComboBox();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.Location = new System.Drawing.Point(12, 9);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(48, 23);
            this.PlayerLabel.TabIndex = 0;
            this.PlayerLabel.Text = "Player";
            this.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerBox
            // 
            this.PlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Location = new System.Drawing.Point(66, 9);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(340, 23);
            this.PlayerBox.TabIndex = 1;
            this.PlayerBox.SelectedIndexChanged += new System.EventHandler(this.PlayerBox_SelectedIndexChanged);
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePlayerButton.Location = new System.Drawing.Point(15, 80);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(388, 29);
            this.DeletePlayerButton.TabIndex = 2;
            this.DeletePlayerButton.Text = "Delete";
            this.DeletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeletePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 121);
            this.Controls.Add(this.DeletePlayerButton);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.PlayerLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(430, 160);
            this.Name = "DeletePlayerForm";
            this.Text = "Delete Player";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.ComboBox PlayerBox;
        private System.Windows.Forms.Button DeletePlayerButton;
    }
}