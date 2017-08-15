using System;
using System.Drawing;
using System.Windows.Forms;
using Schockturnier.Controls;
using Schockturnier.Data;

namespace Schockturnier
{
    public partial class MainForm : Form
    {
        private FormWindowState _lastWindowState;

        public MainForm()
        {
            InitializeComponent();
            nextRoundMenuItem.Enabled = false;
            _lastWindowState = WindowState;

            TurnamentContext.Instance.CurrentGame.GameFinished += CurrentGameOnGameFinished;
            for (var index = 0; index < 16; index++)
            {
                var playerName = $"Spieler {index + 1}";
                TurnamentContext.Instance.CurrentGame.Players.Add(new Player(playerName));
            }
        }

        private void CurrentGameOnGameFinished(object sender, EventArgs eventArgs)
        {
            roundPanel.Controls.Clear();
            var control = new PlacementsControl
            {
                Dock = DockStyle.Fill,
                Width = Width,
                Height = Height
            };
            roundPanel.Controls.Add(control);
            nextRoundMenuItem.Enabled = false;
        }

        private void newGameMenuStrip_Click(object sender, EventArgs e)
        {
            var form = new ConfiguratePlayersForm();
            form.Show();
        }

        private void startTurnamentMenuItem_Click(object sender, EventArgs e)
        {
            StartTurnament();
        }

        private void nextRoundMenuItem_Click(object sender, EventArgs e)
        {
            TurnamentContext.Instance.CurrentGame.NextRound();
            RefreshRounds();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            RefreshRounds();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != _lastWindowState)
            {
                _lastWindowState = WindowState;
                RefreshRounds();
            }
        }

        private void StartTurnament()
        {
            newGameMenuStrip.Enabled = false;
            startTurnamentMenuItem.Enabled = false;
            nextRoundMenuItem.Enabled = true;

            TurnamentContext.Instance.CurrentGame.StartGame();
            RefreshRounds();
        }

        private void RefreshRounds()
        {
            if (!TurnamentContext.Instance.CurrentGame.IsFinished)
            {
                roundPanel.Controls.Clear();
                var round = TurnamentContext.Instance.CurrentGame.ActiveRound;
                var control = new RoundControl(round)
                {
                    Dock = DockStyle.Fill,
                    Width = Width,
                    Height = Height
                };
                roundPanel.Controls.Add(control);
            }
        }
    }
}