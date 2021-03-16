using System;

namespace CustomExceptionApp.Model
{
    class Temperature
    {
        readonly int temperature = 0;
        public void ShowTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
}
