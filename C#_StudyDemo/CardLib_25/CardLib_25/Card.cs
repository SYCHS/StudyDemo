using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib_25
{
    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;

        private Card()
        {
          
        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override String ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }
    }
}