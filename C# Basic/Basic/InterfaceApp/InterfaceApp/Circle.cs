using System;

namespace InterfaceApp
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }
}
