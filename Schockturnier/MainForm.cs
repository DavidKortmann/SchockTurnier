using System;
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
            //for (var index = 0; index < 16; index++)
            //{
            //    var playerName = $"Spieler {index + 1}";
            //    TurnamentContext.Instance.CurrentGame.Players.Add(new Player(playerName));
            //}
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

        private void playerAdministrationMenuStrip_Click(object sender, EventArgs e)
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

        private void turnierLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                TurnamentContext.Instance.LoadGame(openFileDialog1.FileName);
                TurnamentContext.Instance.CurrentGame.GameFinished += CurrentGameOnGameFinished;
                playerAdministrationMenuStrip.Enabled = false;
                startTurnamentMenuItem.Enabled = false;
                nextRoundMenuItem.Enabled = true;
                RefreshRounds();
            }
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
            if (TurnamentContext.Instance.CurrentGame.Players.Count >= 12)
            {
                var result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    playerAdministrationMenuStrip.Enabled = false;
                    startTurnamentMenuItem.Enabled = false;
                    nextRoundMenuItem.Enabled = true;
                    TurnamentContext.Instance.CurrentGame.StartGame(saveFileDialog.FileName);
                    RefreshRounds();
                }
            }
            else
            {
                MessageBox.Show(this, "Die mindestanzahl von 12 Spielern wurde nicht erreicht.", "Fehler!", MessageBoxButtons.OK);
            }
            
        }

        private void RefreshRounds()
        {
            if (!TurnamentContext.Instance.CurrentGame.IsFinished && TurnamentContext.Instance.CurrentGame.IsStarted)
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