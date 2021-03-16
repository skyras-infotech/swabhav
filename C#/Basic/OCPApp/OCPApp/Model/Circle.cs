using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPApp.Model
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
