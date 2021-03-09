using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventOnAccountApp.Publisher;
using EventOnAccountApp.Subscriber;

namespace EventOnAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account a1 = new Account("1578","John Doe", 963.23);
            new SMSListner(a1);
            new EmailListner(a1);
          //  a1.AddListner(new SMSListner(a1));
          //  a1.AddListner(new EmailListner(a1));
            a1.Deposit(1000);
            a1.Withdraw(500);
            a1.Withdraw(800);
            a1.Deposit(500);
            PrintAccountInfo(a1);
        }

        private static void PrintAccountInfo(Account a)
        {
            Console.WriteLine("\n----------User Account Info------------");
            Console.WriteLine($"Account Holder name         : {a.AccountName}");
            Console.WriteLine($"Your account number         : {a.AccountNo}");
            Console.WriteLine($"No of Transaction Performed : {a.NoOfTransaction}");
            Console.WriteLine($"Your balance                : {a.Balance}");
            if (!a.IsWithdraw)
            {
                Console.WriteLine("Sorry you do not have suffient balance");
            }
            Console.WriteLine();
        }
    }
}
