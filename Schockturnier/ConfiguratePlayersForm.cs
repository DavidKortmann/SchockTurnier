using System;
using System.Linq;
using System.Windows.Forms;
using Schockturnier.Data;

namespace Schockturnier
{
    public partial class ConfiguratePlayersForm : Form
    {
        public ConfiguratePlayersForm()
        {
            InitializeComponent();
        }
        private void ConfiguratePlayersForm_Load(object sender, EventArgs e)
        {
            TurnamentContext.Instance.CurrentGame.Players.ForEach(s => playersListBox.Items.Add(s.Name));
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }

        private void playerNameTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPlayer();
            }
        }

        private void playersListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeletePlayer();
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPlayer()
        {
            if (playerNameTextbox.Text.Trim().Length > 0)
            {
                var playerName = playerNameTextbox.Text;
                if (TurnamentContext.Instance.CurrentGame.Players.Any(p => p.Name == playerName))
                {
                    MessageBox.Show(this, "Der Spieler ist bereits vorhanden. Gib einen anderen Namen ein.",
                        "Spieler bereits vorhanden", MessageBoxButtons.OK);
                }
                else
                {
                    TurnamentContext.Instance.CurrentGame.Players.Add(new Player(playerName));
                    playersListBox.Items.Add(playerName);
                    playerNameTextbox.Text = string.Empty;
                    playerNameTextbox.Focus();
                }
            }
        }

        private void DeletePlayer()
        {
            var index = playersListBox.SelectedIndex;
            if (index >= 0)
            {
                TurnamentContext.Instance.CurrentGame.Players.RemoveAt(index);
                playersListBox.Items.RemoveAt(index);
            }
        }

        private void generateRandomButton_Click(object sender, EventArgs e)
        {
            for (var index = 0; index < 16; index++)
            {
                var playerName = $"Spieler {index + 1}";
                TurnamentContext.Instance.CurrentGame.Players.Add(new Player(playerName));
                playersListBox.Items.Add(playerName);
            }
        }
    }
}