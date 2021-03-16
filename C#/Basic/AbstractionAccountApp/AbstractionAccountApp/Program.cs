using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount("1001","John Dae",3000);
            CurrentAccount c1 = new CurrentAccount("1002","John Cena",2000);
            PrintAccountInfo(s1);
            s1.Withdraw(1000);
            PrintTransactionInfo(s1);
            s1.deposit(500);
            PrintTransactionInfo(s1);
            s1.Withdraw(3500);
            PrintTransactionInfo(s1);
        }
        public static void PrintAccountInfo(Account a)
        {
            Console.WriteLine("----------User Account Info------------");
            Console.WriteLine($"Welcome {a.AccountName}");
            Console.WriteLine($"Your account number is {a.AccountNo}");
            Console.WriteLine($"Your balance is {a.Balance}");
            Console.WriteLine();
        }

        public static void PrintTransactionInfo(Account a) {
            if (a.ISWithdraw)
            {
                Console.WriteLine("Sorry you do not have suffient balance");
                Console.WriteLine();
            }
            else {
               
                Console.WriteLine("Transaction Successfull");
                Console.WriteLine($"After transaction balance is {a.Balance}");
                Console.WriteLine();
            }
            
        }
    }
}
