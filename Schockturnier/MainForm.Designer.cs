namespace Schockturnier
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.playerAdministrationMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.turnierLadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTurnamentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRoundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuStrip});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1099, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // gameMenuStrip
            // 
            this.gameMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerAdministrationMenuStrip,
            this.turnierLadenToolStripMenuItem,
            this.startTurnamentMenuItem,
            this.nextRoundMenuItem});
            this.gameMenuStrip.ForeColor = System.Drawing.Color.White;
            this.gameMenuStrip.Name = "gameMenuStrip";
            this.gameMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.gameMenuStrip.Text = "Spiel";
            // 
            // playerAdministrationMenuStrip
            // 
            this.playerAdministrationMenuStrip.Name = "playerAdministrationMenuStrip";
            this.playerAdministrationMenuStrip.Size = new System.Drawing.Size(163, 22);
            this.playerAdministrationMenuStrip.Text = "Spieler verwalten";
            this.playerAdministrationMenuStrip.Click += new System.EventHandler(this.playerAdministrationMenuStrip_Click);
            // 
            // turnierLadenToolStripMenuItem
            // 
            this.turnierLadenToolStripMenuItem.Name = "turnierLadenToolStripMenuItem";
            this.turnierLadenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.turnierLadenToolStripMenuItem.Text = "Turnier laden";
            this.turnierLadenToolStripMenuItem.Click += new System.EventHandler(this.turnierLadenToolStripMenuItem_Click);
            // 
            // startTurnamentMenuItem
            // 
            this.startTurnamentMenuItem.Name = "startTurnamentMenuItem";
            this.startTurnamentMenuItem.Size = new System.Drawing.Size(163, 22);
            this.startTurnamentMenuItem.Text = "Turnier starten";
            this.startTurnamentMenuItem.Click += new System.EventHandler(this.startTurnamentMenuItem_Click);
            // 
            // nextRoundMenuItem
            // 
            this.nextRoundMenuItem.Name = "nextRoundMenuItem";
            this.nextRoundMenuItem.Size = new System.Drawing.Size(163, 22);
            this.nextRoundMenuItem.Text = "Nächste Runde";
            this.nextRoundMenuItem.Click += new System.EventHandler(this.nextRoundMenuItem_Click);
            // 
            // roundPanel
            // 
            this.roundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundPanel.Location = new System.Drawing.Point(12, 27);
            this.roundPanel.Name = "roundPanel";
            this.roundPanel.Size = new System.Drawing.Size(1075, 749);
            this.roundPanel.TabIndex = 1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "stf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            this.openFileDialog1.Filter = "Schockturnier-Datei|*.stf";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1099, 788);
            this.Controls.Add(this.roundPanel);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Feuerwehr Schockturnier";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playerAdministrationMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startTurnamentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRoundMenuItem;
        private System.Windows.Forms.Panel roundPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem turnierLadenToolStripMenuItem;
    }
}