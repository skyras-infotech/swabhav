using System;
using PigGameUsingOOADApp.Model;

namespace PigGameUsingOOADApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();
            Game game = new Game(die);
            DisplayRules();
            PlayGame(game);
        }

        private static void DisplayRules()
        {
            Console.WriteLine("*See how many turns it takes you to get to 20." +
                "\n*Turn ends when you hold or roll a 1. " +
                "\n*If you roll a 1, you lose all points for the turn." +
                "\n*If you hold, you save all points for the turn.");
        }

        private static void PlayGame(Game game)
        {
            while (!game.IsGameOver) 
            {
                game.IsTurnOver = false;
                game.Turn = 0;
                Console.WriteLine("\nTurn " + game.SwitchTurn);
                while (!game.IsTurnOver)
                {
                    Console.Write("Roll or hold? (r/h) ==> ");
                    string ch = Console.ReadLine();

                    if (ch.Equals("r"))
                    {
                        RollDie(game);
                    }   
                    else
                    {
                        HoldTurn(game);
                    }
                }
                game.Score += game.Turn;
                Console.WriteLine("Total Score is " + game.Score);
                if (game.HasWon())
                {
                    Console.WriteLine("\nCongratulation You won in " + game.SwitchTurn + " turn! Game Over...\n");
                    game.IsGameOver = true;
                }
                TakeTurn(game);
            }
        }

        private static void HoldTurn(Game game)
        {
            game.IsTurnOver = true;
            Console.WriteLine("Turn Score is " + game.Turn);
        }

        private static void RollDie(Game game)
        {
            game.GetDie.Roll();
            if (game.GetDie.Value.Equals(1))
            {
                game.Turn = 0;
                Console.WriteLine("Die : " + game.GetDie.Value);
                Console.WriteLine("Turn Over. No Score!");
            }
            else
            {
                Console.WriteLine("Die : " + game.GetDie.Value);
                game.Turn += game.GetDie.Value;
            }
        }

        private static void TakeTurn(Game game)
        {
            game.SwitchTurn++;
        }

    }
}
