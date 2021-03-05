using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPatternAccountApp.Model;

namespace ProxyPatternAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountProxy proxy = new AccountProxy(101, "Sumit", 1000);
            proxy.Deposit(200);
        }
    }
}
