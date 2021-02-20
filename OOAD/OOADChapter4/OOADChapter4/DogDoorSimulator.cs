using System;
using System.Threading;

namespace OOADChapter2
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));

            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);
            Console.WriteLine();
            Console.WriteLine("Bruce starts barking...");
            recognizer.recognize(new Bark("rowlf"));
            Console.WriteLine("\nBruce has gone outside...");
            try
            {
                Thread.Sleep(10000);
            }
            catch(ThreadInterruptedException e) {
                Console.WriteLine("Error "+e.Message);
            }

            Console.WriteLine("\nBruce all done...");
            Console.WriteLine("...but he's stuck outside!");

            Bark smallDogBark = new Bark("yip");
            Console.WriteLine("A small dog starts barking.");
            recognizer.recognize(smallDogBark);

            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("Error " + e.Message);
            }

            Console.WriteLine("\nBruce starts barking...");
            recognizer.recognize(new Bark("rowlf"));
            Console.WriteLine("\nBruce’s back inside...");
        }
    }
}
