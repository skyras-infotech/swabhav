using System;

namespace ThreeDifferentExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                int c = a / b;
                Console.WriteLine("a / b : " + c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace + " : Can not divided by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " : Enter only non decimal number");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.GetType() + " : Please enter two numbers atleast");
            }
            finally
            {
                Console.WriteLine("End of the program\n");
            }
        }
    }
}
