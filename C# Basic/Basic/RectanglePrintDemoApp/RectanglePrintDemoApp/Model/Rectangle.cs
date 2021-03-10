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

        public void setHeight(int height)
        {
            if (height < 1)
            {
                this.height = 1;
            }
            else if (height > 100)
            {
                this.height = 100;
            }
            else
            {
                this.height = height;
            }
        }

        public void setWidth(int width)
        {
            if (width < 1)
            {
                this.width = 1;
            }
            else if (width > 100)
            {
                this.width = 100;
            }
            else
            {
                this.width = width;
            }
        }


        public void setColor(string color)
        {
            if (color.Equals("Red") || color.Equals("Green") || color.Equals("Blue"))
            {
                this.color = color;
            }
            else
            {
                this.color = "black";
            }
        }

        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }
        public string getColor()
        {
            return color;
        }
    }
}
