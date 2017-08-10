using System.Drawing;
using System.Windows.Forms;
using Schockturnier.Data;

namespace Schockturnier.Controls
{
    public partial class RoundControl : UserControl
    {
        private readonly Round _round;
        private const int Margin = 15;

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
            var yOffset = 0;
            var height = CalculateControlHeight();
            foreach (var group in _round.Groups)
            {
                var control = new GroupControl(group)
                {
                    Location = new Point(0, yOffset),
                    Height = height,
                    Width = Width
                };
                groupsPanel.Controls.Add(control);
                yOffset += control.Height + Margin;
            }
        }

        private int CalculateControlHeight()
        {
            var maxGroupCount = TurnamentContext.Instance.CurrentGame.CurrentModus.GroupCounts[0];
            var sumMaring = (maxGroupCount - 1) * Margin;
            return (Height - sumMaring) / maxGroupCount;
        }

        public int CalculateYOffset()
        {
            var height = CalculateControlHeight();
            var maxGroupCount = TurnamentContext.Instance.CurrentGame.CurrentModus.GroupCounts[0];
            var roundGroupCount = _round.Groups.Count;
            return height / 2;
        }
    }
}