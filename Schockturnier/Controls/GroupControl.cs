using System.Windows.Forms;
using Schockturnier.Data;

namespace Schockturnier.Controls
{
    public partial class GroupControl : UserControl
    {
        private readonly Group _group;
        public GroupControl(Group group)
        {
            InitializeComponent();
            _group = group;
            RefreshList();
        }

        private void RefreshList()
        {
            playersListView.Items.Clear();;
            groupNameLabel.Text = _group.Name;
            _group.Players.ForEach(p => playersListView.Items.Add(new ListViewItem(new []{p.Name, p.IsOut ? "OUT": ""})));
        }

        private void playersListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               ChangePlayerState();
            }
        }

        private void ChangePlayerState()
        {
            var index = playersListView.SelectedItems[0].Index;
            if (index >= 0)
            {
                var player = _group.Players[index];
                TurnamentContext.Instance.CurrentGame.OutPlayer(player);
                RefreshList();
            }
        }
    }
}