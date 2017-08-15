using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Schockturnier.Data;

namespace Schockturnier.Controls
{
    public partial class RoundControl : UserControl
    {
        private readonly Round _round;
        private const int Margin = 0;

        public RoundControl(Round round)
        {
            InitializeComponent();
            _round = round;
        }
        private void RoundControl_Load(object sender, System.EventArgs e)
        {
            roundNameLabel.Text = _round.Name;
            RefreshGroups();
        }
        
        private void RefreshGroups()
        {
            var height = 300;
            foreach (var group in _round.Groups)
            {
                var control = new GroupControl(group)
                {
                    Height = height,
                    Width = CalculateWidth()
                };
                flowLayoutPanel.Controls.Add(control);
            }
        }

        private int CalculateWidth()
        {
            Debug.WriteLine("RoundControl: {0}", Width);
            Debug.WriteLine("FlowPanel: {0}", flowLayoutPanel.Width);
            Debug.WriteLine("Papa: {0}", Parent.Width);

            Application.DoEvents();
            return (flowLayoutPanel.Width / 4) - (5*3);
        }

        public int CalculateYOffset()
        {
            var height = CalculateWidth();
            var maxGroupCount = TurnamentContext.Instance.CurrentGame.CurrentModus.GroupCounts[0];
            var roundGroupCount = _round.Groups.Count;
            return height / 2;
        }
    }
}