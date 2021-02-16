using System;
using System.Threading;

namespace OOADChapter2
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine();
            remote.PressButton();
            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido’s all done...");
            try
            {
                Thread.Sleep(10000);
            }
            catch(ThreadInterruptedException e) {
                Console.WriteLine("Error "+e.Message);
            }

            Console.WriteLine("...but he's stuck outside!");
            Console.WriteLine("\nFido starts barking...");
            Console.WriteLine("...so Gina grabs the remote control.");
            remote.PressButton();
            Console.WriteLine("\nFido’s back inside...");
        }
    }
}
