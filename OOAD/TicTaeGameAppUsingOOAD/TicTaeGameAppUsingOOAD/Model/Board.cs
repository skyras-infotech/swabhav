using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaeGameAppUsingOOAD.Model
{
    public class Board
    {
        private Cell[] _cells;
        private int _size;

        public Board(int size)
        {
            _cells = new Cell[size*size];
            _size = size;

            for (int i = 0; i < _size*_size; i++)
            {
                _cells[i] = new Cell();
            }
        }

        public Cell[] GetCells {
            get { return _cells; }
        }

        public int Size
        {
            get { return _size; }
        }

        public void SetMarkInPosition(Player player, int position) {
            try
            {
                if (position > _cells.Length) {
                    throw new OutOfCellException("sorry! you entered wrong position. position should be 0 to " + (_cells.Length - 1));
                }
                _cells[position].Mark = player.PlayerMark;
            }
            catch (CellAlreadyOccupiedException e) {

                throw new CellAlreadyOccupiedException(e.Message);
            }
        }

        public string PrintBoard() {
            string pb = "";
            for (int i = 0; i < _size * _size; i++)
            {
                pb += "__";
                pb += _cells[i].Mark;
                pb += "__";
                if ((i % _size) != (_size - 1))
                {
                    pb += "|";
                }
                if ((i % _size) == (_size - 1)) {
                    pb += "\n";
                }
                
            }
            for (int i = 0; i < _size; i++)
            {
                if(i != 2)
                    pb += "     |";
            }
            return pb;
        }

        public bool CheckIBoardIsFull() {
            for (int i = 0; i < _size * _size; i++)
            {
                if (_cells[i].Mark.Equals(Mark.N))
                    return false;
            }
            return true;
        }
        
    }
}
