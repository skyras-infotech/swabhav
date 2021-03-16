using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Rectangle
    {
        private int height;
        private int width;
        private string color;

        public Rectangle(int height, int width, string color)
        {
            this.height = height;
            this.width = width;
            this.color = color;
        }

        public string Details
        {
            get
            {
                return "Height is " + height.ToString() +
                         "\nWidth is " + width.ToString() +
                         "\nColor is " + color;
            }
        }
    }
}
