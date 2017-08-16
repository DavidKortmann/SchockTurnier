using System;
using System.Collections.Generic;

namespace Schockturnier.Data
{
    [Serializable]
    public class Round
    {
        public Round()
        {
            Groups = new List<Group>();
            IsActive = true;
        }

        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsFinal { get; set; }
        public List<Group> Groups { get; set; }
    }
}