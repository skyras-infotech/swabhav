using System;
using System.Timers;

namespace OOADChapter2
{
    class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton() {
            Console.WriteLine("Pressing the remote control button..");
            if (door.IsOpen())
            {
                door.Close();
            }
            else {
                door.Open();
                Timer timer = new Timer();
                timer.Interval = 5000;
                timer.AutoReset = false;
                timer.Elapsed += (s, args) => StopTimer(timer);
                timer.Start();
            }
        }

        private void StopTimer(Timer timer)
        {
            timer.Stop();
            door.Close();
        }
    }
}
