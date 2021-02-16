using System;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account a1 = new Account("John Doe",963.23);
            try
            {
                a1.Deposit(1000);
                PrintTransactionInfo(a1);
                a1.Withdraw(500);
                PrintTransactionInfo(a1);
                a1.Withdraw(1300);
                PrintTransactionInfo(a1);

            }
            catch (InsufficientBalanceException e) {
                Console.WriteLine(e.Message);
            }
            PrintAccountInfo(a1);
        }

        public static void PrintAccountInfo(Account a) {
            Console.WriteLine("----------User Account Info------------");
            Console.WriteLine($"Account Holder name         : {a.AccountName}");
            Console.WriteLine($"Your account number         : {a.AccountNo}");
            Console.WriteLine($"No of Transaction Performed : {a.NoOfTransaction}");
            Console.WriteLine($"Your balance                : {a.Balance}");
          
            Console.WriteLine();
        }
        public static void PrintTransactionInfo(Account a)
        {
            if (!a.IsWithdraw)
            {
                Console.WriteLine("Transaction Successfull");
                Console.WriteLine($"After transaction balance is {a.Balance}");
                Console.WriteLine();
            }

        }


    }
}
