using System;
using System.Collections.Generic;

namespace Schockturnier.Data
{
    [Serializable]
    public class TurnamentModus
    {
        public int PlayersCount { get; set; }
        public List<int> GroupCounts { get; set; }

        public static List<TurnamentModus> PossibleTurnamentModus => new List<TurnamentModus>
        {
            new TurnamentModus{ PlayersCount = 12, GroupCounts = new List<int>{4,2,1}},
            new TurnamentModus{ PlayersCount = 17, GroupCounts = new List<int>{5,2,1}},
            new TurnamentModus{ PlayersCount = 21, GroupCounts = new List<int>{6,3,1}},
            new TurnamentModus{ PlayersCount = 25, GroupCounts = new List<int>{8,4,2,1}},
            new TurnamentModus{ PlayersCount = 33, GroupCounts = new List<int>{10,5,2,1}},
            new TurnamentModus{ PlayersCount = 41, GroupCounts = new List<int>{12,6,3,1}}
        };
    }
}