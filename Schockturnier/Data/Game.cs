using System;
using System.Collections.Generic;
using System.Linq;

namespace Schockturnier.Data
{
    public class Game
    {
        public Game()
        {
            Players = new List<Player>();
            Rounds = new List<Round>();
            Winners = new List<Placement>();
        }

        public delegate void GameFinishedDelegate(object sender, EventArgs e);
        public event GameFinishedDelegate GameFinished;

        public List<Player> Players { get; set; }
        public TurnamentModus CurrentModus { get; set; }
        public List<Round> Rounds { get; set; }
        public List<Placement> Winners { get; set; }
        public Round ActiveRound => Rounds.SingleOrDefault(r => r.IsActive);

        public void StartGame()
        {
            SetModus();
            CreateRound();
            CreateGroups();
            SpreadPlayers();
        }

        public void NextRound()
        {
            var activeRound = Rounds.SingleOrDefault(r => r.IsActive);
            if (activeRound != null && !activeRound.IsFinal)
            {
                activeRound.IsActive = false;
                CreateRound();
                CreateGroups();
                SpreadPlayers();
            }
            else
            {
                OnGameFinished();
            }
        }

        public void OutPlayer(Player player)
        {
            if (ActiveRound.IsFinal)
            {
                var playersLeftCount = Players.Count(p => !p.IsOut);
                if (playersLeftCount <= 4)
                {
                    Winners.Insert(0, new Placement{Number = playersLeftCount, Player = player});
                }
            }
            player.IsOut = !player.IsOut;
        }

        private void SetModus()
        {
            var playersCount = Players.Count;
            var modus = TurnamentModus.PossibleTurnamentModus[0];
            foreach (var possibleModus in TurnamentModus.PossibleTurnamentModus)
            {
                if (playersCount >= possibleModus.PlayersCount)
                {
                    modus = possibleModus;
                }
            }
            CurrentModus = modus;
        }

        private void CreateRound()
        {
            Rounds.Add(new Round {Name = $"{Rounds.Count + 1}. Runde"});
            if (Rounds.Count == CurrentModus.GroupCounts.Count)
            {
                ActiveRound.IsFinal = true;
            }
        }

        private void CreateGroups()
        {
            var currentRoundIndex = Rounds.Count - 1;
            var groupCount = CurrentModus.GroupCounts[currentRoundIndex];
            for (var i = 0; i < groupCount; i++)
            {
                ActiveRound.Groups.Add(new Group{ Name = $"Gruppe {i+1}"});
            }
        }

        private void SpreadPlayers()
        {
            var activePlayers = Players.Where(p => !p.IsOut).ToList();
            var groupCount = ActiveRound.Groups.Count;
            var groupIndex = 0;
            foreach (var player in activePlayers)
            {
                ActiveRound.Groups[groupIndex].Players.Add(player);
                groupIndex++;
                if (groupIndex == groupCount)
                {
                    groupIndex = 0;
                }
            }
        }

        private void OnGameFinished()
        {
            GameFinished?.Invoke(this, EventArgs.Empty);
        }
    }
}