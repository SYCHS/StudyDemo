using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib_25
{
    public class Deck
    {
        private CardsCollection cards = new CardsCollection();

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
                    cards.Add(new CardLib_25.Card((Suit)suitVal,(Rank)rankVal));
                }
            }

           
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum",cardNum,"value must be between 0 and 51."));
        }

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