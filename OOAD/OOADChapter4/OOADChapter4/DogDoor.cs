using System;
using System.Collections.Generic;
using System.Timers;

namespace OOADChapter2
{
    class DogDoor
    {
        private bool open;
        private List<Bark> allowedBarks;

        public DogDoor()
        {
            this.open = false;
            this.allowedBarks = new List<Bark>();
        }
        public void AddAllowedBark(Bark bark)
        {
            allowedBarks.Add(bark);
        }

        public List<Bark> getAllowedBarks()
        {
            return allowedBarks;
        }

        public void Open() {
            Console.WriteLine("The dog door opens.");
            open = true;
            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.AutoReset = false;
            timer.Elapsed += (s, args) => StopTimer(timer);
            timer.Start();
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
        private void StopTimer(Timer timer)
        {
            timer.Stop();
            Close();
        }
    }
}
