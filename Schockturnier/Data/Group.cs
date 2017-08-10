using System.Collections.Generic;

namespace Schockturnier.Data
{
    public class Group
    {
        public Group()
        {
            Players = new List<Player>();
        }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }
}
