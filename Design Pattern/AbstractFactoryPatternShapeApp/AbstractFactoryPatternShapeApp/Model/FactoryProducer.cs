using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternShapeApp.Model
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice) {
            if (choice.ToLower().Equals("shape")) {
                return new ShapeFactory();
            }
            else if (choice.ToLower().Equals("color"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
