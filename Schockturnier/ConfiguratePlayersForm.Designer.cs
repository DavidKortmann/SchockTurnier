namespace Schockturnier
{
    partial class ConfiguratePlayersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerNameTextbox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.spreadPlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameTextbox
            // 
            this.playerNameTextbox.Location = new System.Drawing.Point(12, 12);
            this.playerNameTextbox.Name = "playerNameTextbox";
            this.playerNameTextbox.Size = new System.Drawing.Size(175, 20);
            this.playerNameTextbox.TabIndex = 0;
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(193, 12);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 1;
            this.AddPlayerButton.Text = "Anmelden";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(12, 38);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(256, 251);
            this.playersListBox.TabIndex = 2;
            // 
            // spreadPlayerButton
            // 
            this.spreadPlayerButton.Location = new System.Drawing.Point(274, 12);
            this.spreadPlayerButton.Name = "spreadPlayerButton";
            this.spreadPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.spreadPlayerButton.TabIndex = 3;
            this.spreadPlayerButton.Text = "Aufteilen";
            this.spreadPlayerButton.UseVisualStyleBackColor = true;
            this.spreadPlayerButton.Click += new System.EventHandler(this.spreadPlayerButton_Click);
            // 
            // ConfiguratePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 736);
            this.Controls.Add(this.spreadPlayerButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.playerNameTextbox);
            this.Name = "ConfiguratePlayersForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextbox;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button spreadPlayerButton;
    }
}

