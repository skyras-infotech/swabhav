using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    class Rectangle
    {
        private int height;
        private int width;
        private string color;

        public int Height {
            get {
                return height;
            }
            set {
                if (value < 1)
                {
                    height = 1;
                }
                else if (value > 100)
                {
                    height = 100;
                }
                else
                {
                    height = value;
                }
            }
        }
        public int Width
        {
            get { return width; }
            set {
                if (value < 1)
                {
                    width = 1;
                }
                else if (value > 100)
                {
                    width = 100;
                }
                else
                {
                    width = value;
                }
            }
        }

 
        public string Color
        {
            get { return color; }
            set
            {
                if (value.Equals("Red") || value.Equals("Green") || value.Equals("Blue"))
                {
                    color = value;
                }
                else
                {
                    color = "black";
                }
            }
        }
    }
}
