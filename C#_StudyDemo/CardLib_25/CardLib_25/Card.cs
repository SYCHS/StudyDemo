using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CardLib_25
{
    public class Card:ICloneable
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

        public Object Clone() => MemberwiseClone();


    }
}