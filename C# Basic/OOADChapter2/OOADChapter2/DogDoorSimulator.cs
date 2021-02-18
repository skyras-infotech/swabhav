using System;
using System.Threading;

namespace OOADChapter2
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            //Remote remote = new Remote(door);
            Console.WriteLine();
            Console.WriteLine("Fido starts barking...");
            recognizer.recognize("Woof");
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
            recognizer.recognize("Woof");
            Console.WriteLine("\nFido’s back inside...");
        }
    }
}
