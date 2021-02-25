using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Model
{
    class Square : IShape
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int Side
        {
            get { return side; }
            set { side = value; }
        }

        public int CalculateArea()
        {
            return side * side;
        }
    }
}
