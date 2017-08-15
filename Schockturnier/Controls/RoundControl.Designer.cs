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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // roundNameLabel
            // 
            this.roundNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roundNameLabel.AutoSize = true;
            this.roundNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNameLabel.ForeColor = System.Drawing.Color.White;
            this.roundNameLabel.Location = new System.Drawing.Point(393, 11);
            this.roundNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundNameLabel.Name = "roundNameLabel";
            this.roundNameLabel.Size = new System.Drawing.Size(116, 29);
            this.roundNameLabel.TabIndex = 0;
            this.roundNameLabel.Text = "Runde 99";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(5, 56);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(893, 422);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // RoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.roundNameLabel);
            this.Name = "RoundControl";
            this.Size = new System.Drawing.Size(901, 481);
            this.Load += new System.EventHandler(this.RoundControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roundNameLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}
