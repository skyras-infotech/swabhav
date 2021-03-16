using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameAppUsingMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int GuessNumber = new Random().Next(1, 100);
            int Turn = 1;
            Console.WriteLine("---------------Welcome to the Guessing Game------------------");
            Console.WriteLine("Start - 1");
            Console.WriteLine("Stop - 2");
            Console.Write("Enter 1 to start a game ==> ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    while (true) {
                        Console.Write("Enter your guess ==> ");
                        int GuessingNumber = Convert.ToInt32(Console.ReadLine());
                        if (GuessNumber == GuessingNumber)
                        {
                            Console.WriteLine("\n------------Result---------------");
                            Console.WriteLine("\nCongratulation! you win this game");
                            Console.WriteLine("Guess was "+GuessingNumber);
                            Console.WriteLine("Your Guess was "+GuessNumber);
                            Console.WriteLine("Total turns in your game is "+Turn);
                            break;
                        }
                        else if (GuessNumber > GuessingNumber)
                        {
                            Console.WriteLine("your guess is low\n");
                            Turn++;
                        }
                        else {
                            Console.WriteLine("your guess is high\n");
                            Turn++;
                        }
                    }
                    break;
                case 2:
                    break;
            }
        }
    }
}
