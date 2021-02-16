using GuessGameAppUsingObjectOriented.Model;
using System;

namespace GuessGameAppUsingObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame guessGame = new GuessGame();
            guessGame.GenerateRandomNumber();
            switch (ChooseStartPlaying())
            {
                case 1:
                    while (true)
                    {
                        Console.Write("Enter your guess ==> ");
                        guessGame.GuessingNumber = Convert.ToInt32(Console.ReadLine());
                        if (guessGame.GameResult(guessGame.GuessNumber, guessGame.GuessingNumber, guessGame.Turn))
                        {
                            break;
                        }
                    }
                    break;
                case 2:
                    break;
            }
            DisplayResult(guessGame);

        }
        static int ChooseStartPlaying()
        {
            Console.WriteLine("---------------Welcome to the Guessing Game------------------");
            Console.WriteLine("Start - 1");
            Console.WriteLine("Stop - 2");
            Console.Write("Enter 1 to start a game ==> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static void DisplayResult(GuessGame g)
        {
            if (g.Result)
            {
                Console.WriteLine("\n-------------Result---------------");
                Console.WriteLine("\nCongratulation! you win this game");
                Console.WriteLine("Guess was " + g.GuessNumber);
                Console.WriteLine("Your Guess was " + g.GuessingNumber);
                Console.WriteLine("Total turns in your game is " + g.Turn);
            }
        }
    }
}
