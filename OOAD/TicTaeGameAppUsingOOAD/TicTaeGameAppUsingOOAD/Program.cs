using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTaeGameAppUsingOOAD.Model;

namespace TicTaeGameAppUsingOOAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Welcome to TicTacToe ========\n");
            Console.Write("Enter first player name ==> ");
            string p1 = Console.ReadLine();
            Console.Write("Enter second player name ==> ");
            string p2 = Console.ReadLine();
            Console.Write("Enter Board Size you want to play (if 3x3 enter 3) ==> ");
            int size = Convert.ToInt32(Console.ReadLine());

            Board board = new Board(size);

            Player player1 = new Player(p1, Mark.X);
            Player player2 = new Player(p1, Mark.O);

            Console.WriteLine("\nPlayer " + p1 + " play with mark "+Mark.X);
            Console.WriteLine("Player " + p2 + " play with mark "+Mark.O+"\n");

            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(resultAnalyzer,player1,player2);

            for (int i = 0; i < size * size; i++)
            {
                Console.WriteLine(board.PrintBoard()+"\n");

                if (i % 2 == 0)
                {
                    if (TurnPlayer(p1, game,size))
                    {
                        Console.WriteLine(board.PrintBoard() + "\n");
                        return;
                    }
                }
                else {
                    if (TurnPlayer(p2, game,size))
                    {
                        Console.WriteLine(board.PrintBoard() + "\n");
                        return;
                    }
                }
            }

        }
        private static bool TurnPlayer(string player, Game game,int size) {
            
            reselect: Console.Write(player + ", Enter the position where you place the mark ==> ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (game.ResultAnalyzer.GetBoard.GetCells[pos].Mark != Mark.N) {
                Console.WriteLine("This cell is already marked! please choose another");
                goto reselect;
            }
            int result = game.Play(pos);
            if (result.Equals(1))
            {
                Console.WriteLine("Congratulations! "+player + ", you won this game");
                return true;
            }
            else if (result.Equals(-1))
            {
                Console.WriteLine("Sorry! the game is draw");
                return true;
            }
            else 
            {
                if(game.TotalMoves >= (2 * (size - 1)))
                    Console.WriteLine("The game is in progress");
                return false;
            }
        }
    }
}
