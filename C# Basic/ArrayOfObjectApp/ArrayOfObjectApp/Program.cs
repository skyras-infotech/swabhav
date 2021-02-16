using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //In array we can define a same type of value for all elements. but if we want 
            //to display different type of varible in same array we can use object array.
            object[] arrayOfObj = new object[5];
            arrayOfObj[0] = "abc";
            arrayOfObj[1] = 1;
            arrayOfObj[2] = 1.2;
            arrayOfObj[3] = true;
            arrayOfObj[4] = 's';
          
            Console.WriteLine($"string type     : {arrayOfObj[0]}");
            Console.WriteLine($"integer type    : {arrayOfObj[1]}");
            Console.WriteLine($"float type      : {arrayOfObj[2]}");
            Console.WriteLine($"boolean type    : {arrayOfObj[3]}");
            Console.WriteLine($"character type  : {arrayOfObj[4]}");
        }
    }
}

