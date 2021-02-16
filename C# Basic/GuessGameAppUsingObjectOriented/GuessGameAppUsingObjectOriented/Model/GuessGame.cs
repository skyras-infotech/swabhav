using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameAppUsingObjectOriented.Model
{
    class GuessGame
    {
        private int turn = 1;
        private int guessingNumber;
        private int guessNumber;
        private bool result;

        public void GenerateRandomNumber() { 
            guessNumber =  new Random().Next(1, 100);
        }

        public int GuessingNumber { get { return guessingNumber; } 
            set { guessingNumber = value; } }
        public int GuessNumber { get { return guessNumber; } }
        public int Turn { get { return turn; } }
        public bool Result { get { return result; } }

        public bool GameResult(int Guess,int Guessing,int NoOfTurn) {
            if (Guess == Guessing)
            {
                result = true;
            }
            else if (Guess > Guessing) 
            {
                Console.WriteLine("your guess is low\n");
                turn++;
                result = false;
            }
            else
            {
                Console.WriteLine("your guess is high\n");
                turn++;
                result = false;
            }
            return result;
        }
    }
}
