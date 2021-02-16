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
            int count = 0;
            MethodInfo[] listOfMethod = t.GetMethods();
            foreach (var method in listOfMethod)
            {
                object[] attributeArray = method.GetCustomAttributes(true);
                foreach (Attribute item1 in attributeArray)
                {
                    if (item1 is NeedToFactor)
                    {
                        NeedToFactor customAttribute = (NeedToFactor)item1;
                        Console.WriteLine("Method name : " + method.Name);
                        count++;
                    }
                }
            }
            Console.WriteLine("Number of method which have annotation is "+count);
            Console.WriteLine();
        }
    }
}
