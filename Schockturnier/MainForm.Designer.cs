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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.startTurnamentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRoundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roundsPanel = new System.Windows.Forms.Panel();
            this.placesPanel = new System.Windows.Forms.Panel();
            this.placmentListView = new System.Windows.Forms.ListView();
            this.placmentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenu.SuspendLayout();
            this.placesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuStrip});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(1090, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // gameMenuStrip
            // 
            this.gameMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuStrip,
            this.startTurnamentMenuItem,
            this.nextRoundMenuItem});
            this.gameMenuStrip.Name = "gameMenuStrip";
            this.gameMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.gameMenuStrip.Text = "Spiel";
            // 
            // newGameMenuStrip
            // 
            this.newGameMenuStrip.Name = "newGameMenuStrip";
            this.newGameMenuStrip.Size = new System.Drawing.Size(154, 22);
            this.newGameMenuStrip.Text = "Neu";
            this.newGameMenuStrip.Click += new System.EventHandler(this.newGameMenuStrip_Click);
            // 
            // startTurnamentMenuItem
            // 
            this.startTurnamentMenuItem.Name = "startTurnamentMenuItem";
            this.startTurnamentMenuItem.Size = new System.Drawing.Size(154, 22);
            this.startTurnamentMenuItem.Text = "Turnier starten";
            this.startTurnamentMenuItem.Click += new System.EventHandler(this.startTurnamentMenuItem_Click);
            // 
            // nextRoundMenuItem
            // 
            this.nextRoundMenuItem.Name = "nextRoundMenuItem";
            this.nextRoundMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nextRoundMenuItem.Text = "Nächste Runde";
            this.nextRoundMenuItem.Click += new System.EventHandler(this.nextRoundMenuItem_Click);
            // 
            // roundsPanel
            // 
            this.roundsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundsPanel.Location = new System.Drawing.Point(9, 33);
            this.roundsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.roundsPanel.Name = "roundsPanel";
            this.roundsPanel.Size = new System.Drawing.Size(725, 770);
            this.roundsPanel.TabIndex = 1;
            // 
            // placesPanel
            // 
            this.placesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placesPanel.Controls.Add(this.placmentListView);
            this.placesPanel.Location = new System.Drawing.Point(739, 33);
            this.placesPanel.Name = "placesPanel";
            this.placesPanel.Size = new System.Drawing.Size(339, 770);
            this.placesPanel.TabIndex = 6;
            // 
            // placmentListView
            // 
            this.placmentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placmentCol,
            this.nameCol});
            this.placmentListView.FullRowSelect = true;
            this.placmentListView.Location = new System.Drawing.Point(0, 58);
            this.placmentListView.MultiSelect = false;
            this.placmentListView.Name = "placmentListView";
            this.placmentListView.Size = new System.Drawing.Size(339, 130);
            this.placmentListView.TabIndex = 3;
            this.placmentListView.UseCompatibleStateImageBehavior = false;
            this.placmentListView.View = System.Windows.Forms.View.Details;
            // 
            // placmentCol
            // 
            this.placmentCol.Text = "#";
            this.placmentCol.Width = 80;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.Width = 235;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 813);
            this.Controls.Add(this.placesPanel);
            this.Controls.Add(this.roundsPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.placesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startTurnamentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextRoundMenuItem;
        private System.Windows.Forms.Panel roundsPanel;
        private System.Windows.Forms.Panel placesPanel;
        private System.Windows.Forms.ListView placmentListView;
        private System.Windows.Forms.ColumnHeader placmentCol;
        private System.Windows.Forms.ColumnHeader nameCol;
    }
}