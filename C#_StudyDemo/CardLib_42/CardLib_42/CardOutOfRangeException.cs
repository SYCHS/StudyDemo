using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib_42
{
    public class CardOutOfRangeException:Exception
    {
        private CardsCollection deckContents;

        public CardsCollection DeckContents
        {
            get { return deckContents; }
        }

        public CardOutOfRangeException(CardsCollection sourceDeckContents)
            :base("There are only 52 cards in the deck.")
        {
            deckContents = sourceDeckContents;
        }
    }
}
