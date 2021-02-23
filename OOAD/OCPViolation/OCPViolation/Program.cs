using System;
using OCPViolation.Model;

namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(1001,"Sumit Gupta",50000,50000,5,FestivalType.DIWALI);
            PrintInfo(fixedDeposit);
        }

        private static void PrintInfo(FixedDeposit fixedDeposit)
        {
            Console.WriteLine("======= Fixed Deposit Info ========");
            Console.WriteLine("Account Number   :   " + fixedDeposit.AccountNumber);
            Console.WriteLine("Account Name     :   " + fixedDeposit.AccountName);
            Console.WriteLine("Amount           :   " + fixedDeposit.Amount);
            Console.WriteLine("Years            :   " + fixedDeposit.Years);
            Console.WriteLine("Festival Type     :   " + fixedDeposit.Festival);
            Console.WriteLine("Total Amount     :   " + Math.Round(fixedDeposit.CalculateSimpleInterest(),2));
        }
    }
}
