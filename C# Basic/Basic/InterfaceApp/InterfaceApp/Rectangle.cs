using System;

namespace InterfaceApp
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
