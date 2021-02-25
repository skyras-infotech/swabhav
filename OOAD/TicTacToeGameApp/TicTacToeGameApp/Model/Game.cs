using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGameApp.Model
{
    class Game
    {
        private static string[] _arr;
        private int _flag;
        private int _player;

        public Game()
        {
            _arr = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
            _flag = 0;
            _player = 1;
        }

        public string[] GetArray {
            get { return _arr;  }
        }


        public int Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public int Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private static bool CheckIfBoardIsFullOrNot()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(i.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckRows(string mark, int pos)
        {
            int start = 3 * (pos / 3);
            for (int i = start; i < start + 3; i++)
            {
                if (_arr[i] != mark)
                    return false;
            }
            return true;
        }

        private static bool CheckColumn(string mark, int pos)
        {
            int start = pos % 3;
            for (int i = start; i < 9; i += 3)
            {
                if (_arr[i] != mark)
                    return false;
            }
            return true;
        }

        private static bool CheckLeftToRightDiagonal(string mark, int pos)
        {
            int start = (pos % 3) - (pos / 3);
            if (start != 0)
            {
                return false;
            }
            for (int i = start; i < 9; i += 4)
            {
                if (_arr[i] != mark)
                    return false;
            }
            return true;
        }

        private static bool CheckRightToLeftDiagonal(string mark, int pos)
        {
            int start = (pos % 3) + (pos / 3);
            if (start != 2)
            {
                return false;
            }
            for (int i = start; i <= 6; i += 2)
            {
                if (_arr[i] != mark)
                    return false;
            }
            return true;
        }

        public int CheckWin(string mark, int pos)
        {
            if (CheckRows(mark, pos))
            {
                return 1;
            }
            else if (CheckColumn(mark, pos))
            {
                return 1;
            }
            else if (CheckLeftToRightDiagonal(mark, pos))
            {
                return 1;
            }
            else if (CheckRightToLeftDiagonal(mark, pos))
            {
                return 1;
            }
            else if (CheckIfBoardIsFullOrNot())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
