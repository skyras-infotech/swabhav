using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGameApp.Model;

namespace TicTacToeGameApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("========== Welcome to TicTacToe Game =========\n");
            Console.Write("Enter 1st player name ==> ");
            string player1 = Console.ReadLine();
            Console.Write("Enter 2nd player name ==> ");
            string player2 = Console.ReadLine();
            Console.WriteLine("\n"+player1 + " your mark is X");
            Console.WriteLine(player2 + " your mark is O"+"\n");
            int pos;
            Board(game.GetArray);
            do
            {
                if (game.Player % 2 != 0)
                {
                    Console.Write(player1+", enter position you want to mark ==> ");
                    pos = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write(player2 + ", enter position you want to mark ==> ");
                    pos = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();

                if (game.GetArray[pos] != "X" && game.GetArray[pos] != "O")
                {
                    if (game.Player % 2 == 0)
                    { 
                        game.GetArray[pos] = "O";
                        game.Player++;
                    }
                    else
                    {
                        game.GetArray[pos] = "X";
                        game.Player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", pos, game.GetArray[pos]);
                    Console.WriteLine("\n");
                }
                Board(game.GetArray);
                game.Flag = game.CheckWin(game.GetArray[pos],pos);
            } while (game.Flag != 1 && game.Flag != -1);

            if (game.Flag == 1)
            {
                if (((game.Player % 2) + 1) % 2 != 0)
                {
                    Console.WriteLine(player1 + " has won");
                }
                else {
                    Console.WriteLine(player2 + " has won");
                }
            }
            else 
            {
                Console.WriteLine("game is draw");
            }
        }
        private static void Board(string[] arr)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);
            Console.WriteLine("     |     |      ");
        }
    }
}
