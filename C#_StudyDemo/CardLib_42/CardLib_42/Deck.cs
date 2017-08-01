using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib_42
{
    public class Deck:ICloneable
    {
        private CardsCollection cards = new CardsCollection();

        public event EventHandler LastCardDrawn;

        public Deck()
        {
            /*cards = new Card[52];
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }*/ 
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new CardLib_42.Card((Suit)suitVal,(Rank)rankVal));
                }
            }

           
        }

        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this,EventArgs.Empty);
                return cards[cardNum];
            }
                
            else
                throw new CardOutOfRangeException(cards.Clone() as CardsCollection);
        }
        public Deck(bool useTrumps, Suit trump):this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }
        private Deck(CardsCollection newCards)
        {
            cards = newCards;
        }

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as CardsCollection);
            return newDeck;
        }

        /*public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum",cardNum,"value must be between 0 and 51."));
        }*/

        public void Shuffle()
        {
            //Card[] newDeck = new Card[52];
            CardsCollection newDeck = new CardsCollection();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                //int destCard = 0;
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);//Next(x)----生成一个介于0~x之间的随机数。
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                //newDeck[destCard] = cards[i];
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
    }
}