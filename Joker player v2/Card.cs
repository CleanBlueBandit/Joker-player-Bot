using System;
using System.Collections.Generic;
using System.Text;

namespace Joker_player_v2
{
    public class Card
    {
        public string Name { get; set; }
        public string Suit { get; set; }
        public string write()
        {
            if (Name == "Joker") return $"{Suit} Joker";
            return $"{Name} of {Suit}";
        }

    }

    
}
