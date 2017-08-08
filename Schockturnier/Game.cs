using System.Collections.Generic;

namespace Schockturnier
{
    public class Game
    {
        public const int MaxPlayersInGroup = 4;
        private Game()
        {
            Players = new List<string>();
            Groups = new List<Group>();
        }

        private static Game _instance;

        public static Game Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Game();
                }
                return _instance;
            }
        }

        public List<string> Players { get; set; }
        public List<Group> Groups { get; set; }

        public void SpreadPlayers()
        {
            if (Players.Count % MaxPlayersInGroup == 0)
            {
                var groupCount = Players.Count / MaxPlayersInGroup;
                for (var i = 0; i < groupCount; i++)
                {
                    Groups.Add(
                        new Group { Name = $"Gruppe {i+1}"}
                        );
                }
                var groupIndex = 0;
                foreach (var player in Players)
                {
                    Groups[groupIndex].Players.Add(player);
                    groupIndex++;
                    if (groupIndex == groupCount)
                    {
                        groupIndex = 0;
                    }
                }
            }
        }
    }

    public class Group
    {
        public Group()
        {
            Players = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Players { get; set; }
    }
}
