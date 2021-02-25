using System;
using PigGameUsinhOOPSApp.Model;

namespace PigGameUsinhOOPSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            PigGame game = new PigGame();
            DisplayRules();
            for (int i = 1; ; i++)
            {
                game.TurnScore = 0;
                Console.WriteLine("\nTurn " + i);
                while (true)
                {
                    Console.Write("Roll or hold? (r/h) ==> ");
                    string ch = Console.ReadLine();

                    if (ch.Equals("r"))
                    {
                        int randomNumner = game.Roll(random);
                        if (randomNumner.Equals(1))
                        {
                            game.TurnScore= 0;
                            Console.WriteLine("Die : " + randomNumner);
                            Console.WriteLine("Turn Over. No Score!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Die : " + randomNumner);
                            game.TurnScore+= randomNumner;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Turn Score is " + game.TurnScore);
                        break;
                    }
                }
                Console.WriteLine("Total Score is " + game.BankPoints());
                if (game.HasWon())
                {
                    Console.WriteLine("\nCongratulation You won in " + i + " turn! Game Over...\n");
                    break;
                }
            }
        }
        private static void DisplayRules() {
            Console.WriteLine("*See how many turns it takes you to get to 20." +
                "\n*Turn ends when you hold or roll a 1. " +
                "\n*If you roll a 1, you lose all points for the turn." +
                "\n*If you hold, you save all points for the turn.");
        }
    }
}
