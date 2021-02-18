using System;

namespace OOADChapter2
{
    class Bark
    {
        private String sound;

        public Bark(String sound)
        {
            this.sound = sound;
        }

        public string GetSound
        {
            get { return sound; }
        }

        public bool CheckBarkEquals(Object bark)
        {
            if (bark is Bark) {
                Bark otherBark = (Bark)bark;
                if (this.sound.Equals(otherBark.sound))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
