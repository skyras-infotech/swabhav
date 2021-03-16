using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Model
{
    public class Cell
    {
        private Mark _mark;

        public Cell()
        {
            _mark = Mark.N;
        }

        public Mark Mark {
            get { return _mark; }
            set
            {
                if (_mark.Equals(Mark.N))
                {
                    _mark = value;
                }
                else {
                    throw new CellAlreadyOccupiedException("Mark is already set");
                }
            }
        }
    }
}
