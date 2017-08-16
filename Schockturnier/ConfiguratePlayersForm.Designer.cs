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
            this.components = new System.ComponentModel.Container();
            this.playerNameTextbox = new System.Windows.Forms.TextBox();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.okayButton = new System.Windows.Forms.Button();
            this.playersListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeButton = new System.Windows.Forms.Button();
            this.playersListBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameTextbox
            // 
            this.playerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNameTextbox.Location = new System.Drawing.Point(10, 15);
            this.playerNameTextbox.Name = "playerNameTextbox";
            this.playerNameTextbox.Size = new System.Drawing.Size(436, 20);
            this.playerNameTextbox.TabIndex = 0;
            this.playerNameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playerNameTextbox_KeyUp);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlayerButton.Location = new System.Drawing.Point(452, 13);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlayerButton.TabIndex = 1;
            this.AddPlayerButton.Text = "Anmelden";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // playersListBox
            // 
            this.playersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.Location = new System.Drawing.Point(12, 44);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(600, 355);
            this.playersListBox.TabIndex = 2;
            this.playersListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playersListBox_KeyUp);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(523, 405);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(88, 28);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Übernehmen";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // playersListBoxContextMenu
            // 
            this.playersListBoxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.playersListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripItem});
            this.playersListBoxContextMenu.Name = "playersListBoxContextMenu";
            this.playersListBoxContextMenu.Size = new System.Drawing.Size(126, 26);
            // 
            // deleteToolStripItem
            // 
            this.deleteToolStripItem.Name = "deleteToolStripItem";
            this.deleteToolStripItem.Size = new System.Drawing.Size(125, 22);
            this.deleteToolStripItem.Text = "Entfernen";
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(533, 13);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Entfernen";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ConfiguratePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 443);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.playerNameTextbox);
            this.Name = "ConfiguratePlayersForm";
            this.Text = "Spieler bearbeiten";
            this.Load += new System.EventHandler(this.ConfiguratePlayersForm_Load);
            this.playersListBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTextbox;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.ContextMenuStrip playersListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripItem;
        private System.Windows.Forms.Button removeButton;
    }
}

