using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternShapeApp.Model
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            else if (color.ToLower().Equals("red"))
            {
                return new Red();
            }
            else if (color.ToLower().Equals("green"))
            {
                return new Blue();
            }
            else if (color.ToLower().Equals("blue"))
            {
                return new Green();
            }
            else
            {
                return null;
            }
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
