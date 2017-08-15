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
            this.groupNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.ForeColor = System.Drawing.Color.White;
            this.groupNameLabel.Location = new System.Drawing.Point(147, 7);
            this.groupNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(74, 24);
            this.groupNameLabel.TabIndex = 1;
            this.groupNameLabel.Text = "Gruppe";
            // 
            // playersListView
            // 
            this.playersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersListView.BackColor = System.Drawing.Color.White;
            this.playersListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerNameCol,
            this.playerIsOutCol});
            this.playersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersListView.ForeColor = System.Drawing.Color.Black;
            this.playersListView.FullRowSelect = true;
            this.playersListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.playersListView.Location = new System.Drawing.Point(4, 39);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(360, 116);
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
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.groupNameLabel);
            this.ForeColor = System.Drawing.Color.White;
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
