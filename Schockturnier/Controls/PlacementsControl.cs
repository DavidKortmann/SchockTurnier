using System;
using System.Windows.Forms;
using Schockturnier.Data;

namespace Schockturnier.Controls
{
    public partial class PlacementsControl : UserControl
    {
        public PlacementsControl()
        {
            InitializeComponent();
        }

        private void PlacementsControl_Load(object sender, EventArgs e)
        {
            placementsListView.Items.Clear();
            foreach (var winner in TurnamentContext.Instance.CurrentGame.Winners)
            {
                placementsListView.Items.Add(new ListViewItem(new[] {$"{winner.Number}. Platz", winner.Player.Name}));
            }
        }
    }
}
