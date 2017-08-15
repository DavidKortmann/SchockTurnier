namespace Schockturnier.Controls
{
    partial class GroupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.playersListView = new System.Windows.Forms.ListView();
            this.playerNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerIsOutCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Location = new System.Drawing.Point(2, 3);
            this.groupNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(42, 13);
            this.groupNameLabel.TabIndex = 1;
            this.groupNameLabel.Text = "Gruppe";
            // 
            // playersListView
            // 
            this.playersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerNameCol,
            this.playerIsOutCol});
            this.playersListView.FullRowSelect = true;
            this.playersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.playersListView.Location = new System.Drawing.Point(60, 3);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(303, 152);
            this.playersListView.TabIndex = 2;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            this.playersListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.playersListView_KeyUp);
            // 
            // playerNameCol
            // 
            this.playerNameCol.Text = "Name";
            this.playerNameCol.Width = 200;
            // 
            // playerIsOutCol
            // 
            this.playerIsOutCol.Text = "";
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.groupNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(366, 158);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader playerIsOutCol;
        private System.Windows.Forms.ColumnHeader playerNameCol;
    }
}
