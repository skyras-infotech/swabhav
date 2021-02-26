using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaeGameAppUsingOOAD.Model
{
    class Cell
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
            }
        }
    }
}
