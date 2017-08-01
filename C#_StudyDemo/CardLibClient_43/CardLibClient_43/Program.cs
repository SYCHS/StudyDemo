using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CardLibClient_43
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display introduction
            WriteLine("BeijaminCards:a new and exciting card game.");
            WriteLine("To win you must have 7 cards of the same suit in your hand");
            WriteLine();
            //Prompt for number of players
            bool inputOk = false;
            int choice = -1;
            do
            {
                WriteLine("How many players (2-7) ?");
                string input = ReadLine();
                try
                {
                    //Attempt to convert input a valid number of players.
                    choice = Convert.ToInt32(input);
                    if ((choice >= 2) && (choice <= 7))
                    {
                        inputOk = true;
                    }
                }
                catch
                {
                    //
                }
            } while (inputOk == false);
            Player[] players = new Player[choice];
            for (int p = 0; p < players.Length; p++)
            {
                WriteLine($"Player {p+1} ,enter your name:");
                string playerName = ReadLine();
                players[p] = new Player(playerName);
            }

            //Start game.
            Game newGame = new Game();
            newGame.SetPlayers(players);
            int whoWon = newGame.PlayGame();
            //display winning player.
            WriteLine($"{players[whoWon].Name} has won the game!");
            ReadKey();
        }
    }
}
