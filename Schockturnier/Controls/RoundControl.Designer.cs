namespace Schockturnier.Controls
{
    partial class RoundControl
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
            this.roundNameLabel = new System.Windows.Forms.Label();
            this.groupsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // roundNameLabel
            // 
            this.roundNameLabel.AutoSize = true;
            this.roundNameLabel.Location = new System.Drawing.Point(2, 4);
            this.roundNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundNameLabel.Name = "roundNameLabel";
            this.roundNameLabel.Size = new System.Drawing.Size(51, 13);
            this.roundNameLabel.TabIndex = 0;
            this.roundNameLabel.Text = "Gruppe 1";
            // 
            // groupsPanel
            // 
            this.groupsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupsPanel.Location = new System.Drawing.Point(3, 20);
            this.groupsPanel.Name = "groupsPanel";
            this.groupsPanel.Size = new System.Drawing.Size(311, 140);
            this.groupsPanel.TabIndex = 1;
            // 
            // RoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupsPanel);
            this.Controls.Add(this.roundNameLabel);
            this.Name = "RoundControl";
            this.Size = new System.Drawing.Size(317, 163);
            this.Load += new System.EventHandler(this.RoundControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roundNameLabel;
        private System.Windows.Forms.Panel groupsPanel;
    }
}
