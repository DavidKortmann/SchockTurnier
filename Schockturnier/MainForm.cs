using System;
using System.Drawing;
using System.Windows.Forms;
using Schockturnier.Controls;
using Schockturnier.Data;

namespace Schockturnier
{
    public partial class MainForm : Form
    {
        private const int _margin = 10;
        private const int _menuSize = 31;

        public MainForm()
        {
            InitializeComponent();
            nextRoundMenuItem.Enabled = false;
            placesPanel.Visible = false;

            TurnamentContext.Instance.CurrentGame.GameFinished += CurrentGameOnGameFinished;
            for (var index = 0; index < 16; index++)
            {
                var playerName = $"Spieler {index + 1}";
                TurnamentContext.Instance.CurrentGame.Players.Add(new Player(playerName));
            }
        }

        private void CurrentGameOnGameFinished(object sender, EventArgs eventArgs)
        {
            TurnamentContext.Instance.CurrentGame.Winners.ForEach(w => placmentListView.Items.Add(new ListViewItem(new []{$"{w.Number}. Platz", w.Player.Name})));
            placesPanel.Visible = true;
        }

        private void newGameMenuStrip_Click(object sender, EventArgs e)
        {
            var form = new ConfiguratePlayersForm();
            form.Show();
        }

        private void startTurnamentMenuItem_Click(object sender, EventArgs e)
        {
            StartTurnament();
            PrintRoundControl();
        }

        private void nextRoundMenuItem_Click(object sender, EventArgs e)
        {
            TurnamentContext.Instance.CurrentGame.NextRound();
            PrintRoundControl();
        }

        private void StartTurnament()
        {
            newGameMenuStrip.Enabled = false;
            startTurnamentMenuItem.Enabled = false;
            nextRoundMenuItem.Enabled = true;

            TurnamentContext.Instance.CurrentGame.StartGame();
        }

        private void PrintRoundControl()
        {
            var round = TurnamentContext.Instance.CurrentGame.ActiveRound;
            var roundCount = TurnamentContext.Instance.CurrentGame.Rounds.Count;

            var width = GetRoundControlWidth();
            var xOffSet = (roundCount-1) * width;

            var control = new RoundControl(round)
            {
                Location = new Point(xOffSet, 0),
                Height = roundsPanel.Height,
                Width = width
            };
            roundsPanel.Controls.Add(control);
        }

        private int GetRoundControlWidth()
        {
            var roundsCount = TurnamentContext.Instance.CurrentGame.CurrentModus.GroupCounts.Count;
            var width = roundsPanel.Width / roundsCount;
            return width;
        }
    }
}