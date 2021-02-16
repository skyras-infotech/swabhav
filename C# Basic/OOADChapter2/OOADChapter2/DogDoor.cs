using System;

namespace OOADChapter2
{
    class DogDoor
    {
        private bool open;

        public void Open() {
            Console.WriteLine("The dog door opens.");
        }
       
        public void Close()
        {
            Console.WriteLine("The dog door closes");
            open = false;
        }
        public bool IsOpen()
        {
            return open;
        }
    }
}
