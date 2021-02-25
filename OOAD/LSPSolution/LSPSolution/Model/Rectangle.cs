using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolution.Model
{
    class Rectangle : IShape
    {
        protected int length;
        protected int breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }


        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int CalculateArea()
        {
            return length * breadth;
        }
    }
}
