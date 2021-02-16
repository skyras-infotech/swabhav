using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AccountApp.Model;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\account.txt";
            Account a1 = new Account("John Doe",963.23);
            a1.Deposit(1000);
            a1.Withdraw(500);
            a1.Withdraw(1500);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, a1);
            stream.Close();
            Console.WriteLine("Account details saved successfully...\n");

            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            Account account = (Account)formatter.Deserialize(fileStream);
            fileStream.Close();
            PrintAccountInfo(account);
        }

        public static void PrintAccountInfo(Account a) {
            Console.WriteLine("----------User Account Info------------");
            Console.WriteLine($"Account Holder name         :  {a.AccountName}");
            Console.WriteLine($"Your account number         : {a.AccountNo}");
            Console.WriteLine($"No of Transaction Performed : {a.NoOfTransaction}");
            Console.WriteLine($"Your balance                : {a.Balance}");
            if (a.IsWithdraw) {
                Console.WriteLine("Sorry you do not have suffient balance");
            }
            Console.WriteLine();
        }

      
    }
}
