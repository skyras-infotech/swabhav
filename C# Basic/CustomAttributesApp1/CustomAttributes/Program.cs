using CustomAttributes.Model;
using System;
using System.Reflection;

namespace CustomAttributes
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Type t = typeof(Foo);
            PrintMethods(t);
        }
        static void PrintMethods(Type t)
        {
            int trueCount = 0;
            int falseCount = 0;
            MethodInfo[] listOfMethod = t.GetMethods();
            foreach (var method in listOfMethod)
            {
               ;
                object[] attributeArray = method.GetCustomAttributes(true);
                foreach (Attribute item1 in attributeArray)
                {
                    if (item1 is Test)
                    {
                        Test customAttribute = (Test)item1;
                        bool returnValue = (Boolean)method.Invoke(new Foo(), new object[] { });
                        if (returnValue) {
                            trueCount++;
                        }
                        else {
                            falseCount++;
                        }
                    }
                }
            }
            Console.WriteLine("Returning true methods is "+trueCount);
            Console.WriteLine("Returning false methods is " + falseCount);
            Console.WriteLine();
        }
    }
}
