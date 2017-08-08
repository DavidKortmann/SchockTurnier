using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schockturnier
{
    public partial class ConfiguratePlayersForm : Form
    {
        public ConfiguratePlayersForm()
        {
            InitializeComponent();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            if (playerNameTextbox.Text.Trim().Length > 0)
            {
                var playerName = playerNameTextbox.Text;
                if (Game.Instance.Players.Any(s => s == playerName))
                {
                    MessageBox.Show(this, "Der Spieler ist bereits vorhanden. Gib einen anderen Namen ein.",
                        "Spieler bereits vorhanden", MessageBoxButtons.OK);
                }
                else
                {
                    Game.Instance.Players.Add(playerNameTextbox.Text);
                    playersListBox.Items.Add(playerNameTextbox.Text);
                }
            }
        }

        private void spreadPlayerButton_Click(object sender, EventArgs e)
        {
            Game.Instance.SpreadPlayers();
        }
    }
}
