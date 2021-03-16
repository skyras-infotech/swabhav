using System;
using CustomExceptionApp.Model;

namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.ShowTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: "+e.Message);
            }
        }
    }
}
