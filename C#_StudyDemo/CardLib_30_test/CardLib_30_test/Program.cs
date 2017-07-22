using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CardLib_30;
namespace CardLib_30_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Card.isAceHigh = true;
            WriteLine("Ace are high.");
            Card.useTrumps = true;
            Card.trump = Suit.Club;
            WriteLine("Clubs are trumps.");
            Card card1, card2, card3, card4, card5;
            card1 = new Card(Suit.Club,Rank.Five);
            card2 = new Card(Suit.Club,Rank.Five);
            card3 = new Card(Suit.Club,Rank.Ace);
            card4 = new Card(Suit.Heart,Rank.Ten);
            card5 = new Card(Suit.Diamond,Rank.Ace);
            WriteLine($"{card1.ToString()} == {card2.ToString()} ? {card1 == card2}");
            WriteLine($"{card1.ToString()} != {card3.ToString()} ? {card1 != card3}");
            WriteLine($"{card3.ToString()} == {card5.ToString()} ? {card3 == card5}");
            WriteLine($"{card3.ToString()} > {card4.ToString()} ? {card3 > card4}");
            WriteLine($"{card4.ToString()} < {card5.ToString()} ? {card4 < card5}");
            WriteLine();
            ReadKey();

        }
    }
}
