using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternShapeApp.Model
{
    class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            if (shape == null)
            {
                return null;
            }
            else if (shape.ToLower().Equals("circle"))
            {
                return new Circle();
            }
            else if (shape.ToLower().Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shape.ToLower().Equals("square"))
            {
                return new Square();
            }
            else {
                return null;
            }
        }
    }
}
