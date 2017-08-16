using System;

namespace Schockturnier.Data
{
    [Serializable]
    public class Placement
    {
        public int Number { get; set; }
        public Player Player { get; set; }
    }
}
