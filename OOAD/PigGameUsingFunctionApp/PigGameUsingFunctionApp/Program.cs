using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGameUsingFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totalScore = 0;
            PrintGameRule();
            for (int i = 0; ; i++)
            {
                int turnScore = 0;
                Console.WriteLine("\nTurn " + (i + 1));
                totalScore += RollAndTurn(turnScore,random);
                if (Result(totalScore, i))
                    break;
                Console.WriteLine("Total Score is " + totalScore);
            }
        }

        private static void PrintGameRule() {
            Console.WriteLine("*See how many turns it takes you to get to 20." +
                "\n*Turn ends when you hold or roll a 1. " +
                "\n*If you roll a 1, you lose all points for the turn." +
                "\n*If you hold, you save all points for the turn.");
        }

        private static bool Result(int totalScore,int i) {
            if (totalScore >= 20)
            {
                Console.WriteLine("Congratulation! You won the game in " + (i + 1) + " turn\nGame over");
                return true;
            }
            return false;
        }

        private static int RollAndTurn(int turnScore,Random random) {
            while (true)
            {
                Console.Write("Roll or hold? (r/h) ==> ");
                string ch = Console.ReadLine();

                if (ch.Equals("r"))
                {
                    int randomNumner = random.Next(1, 6);
                    if (randomNumner.Equals(1))
                    {
                        turnScore = 0;
                        Console.WriteLine("Die " + randomNumner);
                        Console.WriteLine("Turn Over No Score");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Die " + randomNumner);
                        turnScore += randomNumner;
                    }
                }
                else
                {
                    Console.WriteLine("Turn Score is " + turnScore);
                    break;
                }
            }
            return turnScore;
        }
    }
}
