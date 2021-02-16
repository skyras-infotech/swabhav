using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameAppUsingFunctionOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessNumber = GenerateRandomNumber();
            int Turn = 1;
            int Choice = ChooseStartPlaying();
            switch (Choice)
            {
                case 1:
                    while (true)
                    {
                        Console.Write("Enter your guess ==> ");
                        int GuessingNumber = Convert.ToInt32(Console.ReadLine());
                        if (Result(GuessNumber, GuessingNumber,Turn)) {
                            break;
                        }
                        Turn++;
                    }
                    break;
                case 2:
                    break;
            }
        }

        static int GenerateRandomNumber() {
            return new Random().Next(1, 100);
        }
        static int ChooseStartPlaying() {
            Console.WriteLine("---------------Welcome to the Guessing Game------------------");
            Console.WriteLine("Start - 1");
            Console.WriteLine("Stop - 2");
            Console.Write("Enter 1 to start a game ==> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        static bool Result(int GuessNumber, int GuessingNumber,int NoOfTurn) {
            if (GuessNumber == GuessingNumber)
            {
                Console.WriteLine("\n-------------Result---------------");
                Console.WriteLine("\nCongratulation! you win this game");
                Console.WriteLine("Guess was " + GuessNumber);
                Console.WriteLine("Your Guess was " + GuessingNumber);
                Console.WriteLine("Total turns in your game is " + NoOfTurn);
                return true;
            }
            else if (GuessNumber > GuessingNumber)
            {
                Console.WriteLine("your guess is low\n");
                return false;
            }
            else
            {
                Console.WriteLine("your guess is high\n");
                return false;
            }
        }
    }
}
