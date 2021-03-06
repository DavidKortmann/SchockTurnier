﻿using System;

namespace Schockturnier.Data
{
    [Serializable]
    public class Player
    {
        public Player()
        {
        }

        public Player(string name)
        {
            Name = name;
            IsOut = false;
        }
        public string Name { get; set; }
        public bool IsOut { get; set; }

        public override string ToString()
        {
            var isOutString = IsOut ? "-Out-" : "";
            return $"{Name}\t{isOutString}";
        }
    }
}
