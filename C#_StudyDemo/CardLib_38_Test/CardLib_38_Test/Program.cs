﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardLib_38;
using static System.Console;

namespace CardLib_38_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            try
            {
                Card myCard = deck1.GetCard(60);
            }
            catch (CardOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.DeckContents[0]);
            }
            ReadKey();
        }
    }
}
