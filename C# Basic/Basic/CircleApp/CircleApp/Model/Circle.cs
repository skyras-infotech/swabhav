using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Model
{
    class Circle
    {
        private const double PI = 3.14;
        private double radius;
        private string color;

        public string Color
        {
            get { return color; }
            set {
                if (value.Equals("Red") || value.Equals("Green") || value.Equals("Blue"))
                {
                    color = value;
                }
                else {
                    color = "black";
                }
            }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateArea() {
            return PI * radius * radius;
        }


    }
}
