using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAccountDemoApp.Model;

namespace BuilderPatternAccountDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Builder(101)
                .BuildName("Sumit")
                .BuildInterest(5.2)
                .BuildBalance(2000)
                .BuildBranch("Navsari")
                .Build();

            PrintInfo(account);
        }
        private static void PrintInfo(Account account)
        {
            Console.WriteLine("Account Number   :   " + account.AccountNumber);
            Console.WriteLine("Account Name     :   " + account.Name);
            Console.WriteLine("Balance          :   " + account.Balance);
            Console.WriteLine("Branch           :   " + account.Branch);
            Console.WriteLine("Interest         :   " + account.Interest);
        }
    }
}
