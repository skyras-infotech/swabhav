using System;

namespace InterfaceUsageScenarioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            Console.WriteLine(audi.CheckAC());
            Console.WriteLine(audi.Wheel());
            Console.WriteLine(audi.NewFeatures());
            Console.WriteLine();
            Toyoto toyoto = new Toyoto();
            Console.WriteLine(toyoto.CheckAC());
            Console.WriteLine(toyoto.Wheel());
        }
    }
}
