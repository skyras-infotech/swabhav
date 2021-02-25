using System;

namespace PigGameUsingOOADApp.Model
{
    class Die
    {
        private int _value;

        public int Value
        {
            get { return _value; }
        }

        public void Roll() {
            _value = new Random().Next(1, 6);
        }

    }
}
