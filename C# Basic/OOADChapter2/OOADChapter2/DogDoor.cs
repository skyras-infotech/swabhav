using System;
using System.Timers;

namespace OOADChapter2
{
    class DogDoor
    {
        private bool open;

        public void Open() {
            Console.WriteLine("The dog door opens.");
            open = true;
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.AutoReset = false;
            timer.Elapsed += (s, args) => StopTimer(timer);
            timer.Start();
        }
        private void StopTimer(Timer timer)
        {
            timer.Stop();
            Close();
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
