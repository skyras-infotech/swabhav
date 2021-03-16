using System;
using System.Reflection;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Person);
            Console.WriteLine("------- All Methods ---------");
            PrintMembers(t);
            Console.WriteLine("------- All Get Methods -------");
            PrintGetMembers(t);
            Console.WriteLine("------- All Set Methods -------");
            PrintSetMembers(t);
        }
        static void PrintMembers(Type t) {
            MethodInfo[] listOfMethod = t.GetMethods();
            foreach (var method in listOfMethod)
            {
                Console.WriteLine("Methods : " + method.Name);
            }
            Console.WriteLine();
        }

        static void PrintGetMembers(Type t)
        {
            PropertyInfo[] listOfGetMethod = t.GetProperties();
            foreach (var method in listOfGetMethod)
            {
                Console.WriteLine("Get Method : " + method.GetGetMethod().Name);
            }
            Console.WriteLine();
        }

        static void PrintSetMembers(Type t)
        {
            PropertyInfo[] listOfGetMethod = t.GetProperties();
            foreach (var method in listOfGetMethod)
            {
                Console.WriteLine("Set Method : " + method.GetSetMethod().Name);
            }
            Console.WriteLine();
        }
    }
}
