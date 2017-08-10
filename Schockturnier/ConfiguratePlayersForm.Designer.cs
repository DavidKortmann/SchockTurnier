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
            this.generateRandomButton = new System.Windows.Forms.Button();
            this.playersListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersListBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerNameTextbox
            // 
            this.playerNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerNameTextbox.Location = new System.Drawing.Point(13, 18);
            this.playerNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.playerNameTextbox.Name = "playerNameTextbox";
            this.playerNameTextbox.Size = new System.Drawing.Size(521, 22);
            this.playerNameTextbox.TabIndex = 0;
            this.playerNameTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playerNameTextbox_KeyUp);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPlayerButton.Location = new System.Drawing.Point(542, 15);
            this.AddPlayerButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(100, 28);
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
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(16, 54);
            this.playersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(734, 436);
            this.playersListBox.TabIndex = 2;
            this.playersListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playersListBox_KeyUp);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okayButton.Location = new System.Drawing.Point(633, 498);
            this.okayButton.Margin = new System.Windows.Forms.Padding(4);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(117, 34);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Übernehmen";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // generateRandomButton
            // 
            this.generateRandomButton.Location = new System.Drawing.Point(650, 15);
            this.generateRandomButton.Name = "generateRandomButton";
            this.generateRandomButton.Size = new System.Drawing.Size(100, 28);
            this.generateRandomButton.TabIndex = 4;
            this.generateRandomButton.Text = "Random";
            this.generateRandomButton.UseVisualStyleBackColor = true;
            this.generateRandomButton.Click += new System.EventHandler(this.generateRandomButton_Click);
            // 
            // playersListBoxContextMenu
            // 
            this.playersListBoxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.playersListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripItem});
            this.playersListBoxContextMenu.Name = "playersListBoxContextMenu";
            this.playersListBoxContextMenu.Size = new System.Drawing.Size(148, 30);
            // 
            // deleteToolStripItem
            // 
            this.deleteToolStripItem.Name = "deleteToolStripItem";
            this.deleteToolStripItem.Size = new System.Drawing.Size(147, 26);
            this.deleteToolStripItem.Text = "Entfernen";
            // 
            // ConfiguratePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 545);
            this.Controls.Add(this.generateRandomButton);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.playerNameTextbox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button generateRandomButton;
        private System.Windows.Forms.ContextMenuStrip playersListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripItem;
    }
}

