using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventShapeExampleApp.Publisher
{
    public delegate void DShapeArea(int x);
    class Shape
    {
        public event DShapeArea AreaCalculated;

        public void CalaculateShape(int x) {
            AreaCalculated?.Invoke(x);
        }
    }
}
