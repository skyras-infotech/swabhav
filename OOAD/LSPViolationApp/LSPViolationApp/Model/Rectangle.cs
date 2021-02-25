using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    class Rectangle
    {
        private int _length;
        private int _height;

        public Rectangle(int length, int height)
        {
            _length = length;
            _height = height;
        }
        public virtual int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public virtual int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public int CalculateArea() {
            return _length * _height;
        }
    }
}
