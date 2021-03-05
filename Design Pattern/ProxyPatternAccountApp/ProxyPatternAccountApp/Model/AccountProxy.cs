using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProxyPatternAccountApp.Model
{
    class AccountProxy : Account
    {
        public AccountProxy(int ano, string name, double balance) : base(ano, name, balance)
        {
        }

        public void Deposit(int amount) {
            Console.WriteLine("Before depositing date time is " + DateTime.Now);
            Console.WriteLine("Before depositing balance is "+ Balance);
            Thread.Sleep(10000);
            base.Deposit(amount);
            Console.WriteLine("After depositing date time is " + DateTime.Now);
            Console.WriteLine("After depositing balance is " + Balance);

        }
    }
}
