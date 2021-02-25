using System;
using LSPViolationApp.Model;

namespace LSPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(30,20);
            Console.WriteLine("Rectangle area is "+r1.CalculateArea());

            Square s1 = new Square(20);
            Console.WriteLine("Square area is "+ s1.CalculateArea());

            Console.WriteLine("Rectangle "+should_not_change_length_if_height_changes(r1));
            Console.WriteLine("Square " + should_not_change_length_if_height_changes(s1));
        }

        public static bool should_not_change_length_if_height_changes(Rectangle obj) {
            int before = obj.Length;
            obj.Height = (obj.Length + 10);
            int after = obj.Length;
            if (before == after)
                return true;
            return false;
        }
    }
}
