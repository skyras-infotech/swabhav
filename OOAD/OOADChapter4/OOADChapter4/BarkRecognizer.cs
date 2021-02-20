using System;
using System.Collections.Generic;

namespace OOADChapter2
{
    class BarkRecognizer
    {
        private DogDoor door;
        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }
        public void recognize(Bark bark)
        {
            Console.WriteLine("  BarkRecognizer: Heard a '" + bark.GetSound+ "'");
            List<Bark> allowedBarks = door.getAllowedBarks();
            foreach (var bark1 in allowedBarks)
            {
                Bark allowedBark = (Bark)bark1;
                if (allowedBark.CheckBarkEquals(bark))
                {
                    door.Open();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed.");
        }
    }
}
