namespace Schockturnier.Controls
{
    partial class PlacementsControl
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1. Platz");
            this.placementsLabel = new System.Windows.Forms.Label();
            this.placementsListView = new System.Windows.Forms.ListView();
            this.playerNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.placementCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // placementsLabel
            // 
            this.placementsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.placementsLabel.AutoSize = true;
            this.placementsLabel.BackColor = System.Drawing.Color.Transparent;
            this.placementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placementsLabel.ForeColor = System.Drawing.Color.White;
            this.placementsLabel.Location = new System.Drawing.Point(370, 9);
            this.placementsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placementsLabel.Name = "placementsLabel";
            this.placementsLabel.Size = new System.Drawing.Size(160, 29);
            this.placementsLabel.TabIndex = 2;
            this.placementsLabel.Text = "Siegerehrung";
            // 
            // placementsListView
            // 
            this.placementsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placementsListView.BackColor = System.Drawing.Color.White;
            this.placementsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.placementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placementCol,
            this.playerNameCol});
            this.placementsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placementsListView.ForeColor = System.Drawing.Color.Black;
            this.placementsListView.FullRowSelect = true;
            this.placementsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.placementsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.placementsListView.Location = new System.Drawing.Point(3, 55);
            this.placementsListView.MultiSelect = false;
            this.placementsListView.Name = "placementsListView";
            this.placementsListView.Size = new System.Drawing.Size(894, 581);
            this.placementsListView.TabIndex = 3;
            this.placementsListView.UseCompatibleStateImageBehavior = false;
            this.placementsListView.View = System.Windows.Forms.View.Details;
            // 
            // playerNameCol
            // 
            this.playerNameCol.Text = "Name";
            this.playerNameCol.Width = 800;
            // 
            // placementCol
            // 
            this.placementCol.Text = "";
            this.placementCol.Width = 400;
            // 
            // PlacementsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.placementsListView);
            this.Controls.Add(this.placementsLabel);
            this.Name = "PlacementsControl";
            this.Size = new System.Drawing.Size(900, 639);
            this.Load += new System.EventHandler(this.PlacementsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label placementsLabel;
        private System.Windows.Forms.ListView placementsListView;
        private System.Windows.Forms.ColumnHeader placementCol;
        private System.Windows.Forms.ColumnHeader playerNameCol;
    }
}
