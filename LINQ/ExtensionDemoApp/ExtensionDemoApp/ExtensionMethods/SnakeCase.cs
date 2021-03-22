using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionDemoApp.ExtensionMethods
{
    public static class SnakeCase
    {
        public static string ToSnackCase(this string str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    s += "_";
                }
                else {
                    s += str[i];
                }
            }
            return s;
        }
    }
}
