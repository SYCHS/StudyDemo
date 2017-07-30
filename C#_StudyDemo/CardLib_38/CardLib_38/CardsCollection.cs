using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CardLib_38
{
    public class CardsCollection:List<Card>,ICloneable
    {
        /*public void Add(Card newCard)
        {
            List.Add(newCard);
        }
        public void Remove(Card oldCard)
        {
            List.Remove(oldCard);
        }
        public Card this[int cardIndex]
        {
            get{ return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }*/
        public void CopyTo(CardsCollection targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }
        public object Clone()
        {
            CardsCollection newCards = new CardsCollection();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }


    }
}
