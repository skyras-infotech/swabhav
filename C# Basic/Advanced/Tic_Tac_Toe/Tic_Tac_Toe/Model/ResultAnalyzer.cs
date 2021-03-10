using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Model
{
    public class ResultAnalyzer
    {
        private Board _board;

        public ResultAnalyzer(Board board)
        {
            _board = board;
        }

        public Board GetBoard {
            get { return _board; }
        }

        public bool CheckRows(Mark mark, int pos)
        {
            int start = _board.Size * (pos / _board.Size);
            for (int i = start; i < start + _board.Size; i++)
            {
                if (_board.GetCells[i].Mark != mark)
                    return false;
            }
            return true;
        }

        public bool CheckColumn(Mark mark, int pos)
        {
            int start = pos % _board.Size;
            for (int i = start; i < _board.Size*_board.Size; i += _board.Size)
            {
                if (_board.GetCells[i].Mark != mark)
                    return false;
            }
            return true;
        }

        public bool CheckLeftToRightDiagonal(Mark mark, int pos)
        {
            int start = (pos % _board.Size) - (pos / _board.Size);
            if (start != 0)
            {
                return false;
            }
            for (int i = start; i < _board.Size*_board.Size; i += (_board.Size + 1))
            {
                if (_board.GetCells[i].Mark != mark)
                    return false;
            }
            return true;
        }

        public bool CheckRightToLeftDiagonal(Mark mark, int pos)
        {
            int start = (pos % _board.Size) + (pos / _board.Size);
            if (start != (_board.Size - 1))
            {
                return false;
            }
            for (int i = start; i <= _board.Size*(_board.Size - 1); i += (_board.Size - 1))
            {
                if (_board.GetCells[i].Mark != mark)
                    return false;
            }
            return true;
        }

        public Result GameResult(Mark mark, int pos)
        {
            if (CheckRows(mark, pos))
            {
                return Result.Win;
            }
            else if (CheckColumn(mark, pos))
            {
                return Result.Win;
            }
            else if (CheckLeftToRightDiagonal(mark, pos))
            {
                return Result.Win;
            }
            else if (CheckRightToLeftDiagonal(mark, pos))
            {
                return Result.Win;
            }
            else if (_board.CheckIBoardIsFull())
            {
                return Result.Draw;
            }
            else
            {
                return Result.InProgress;
            }
        }
    }
}
