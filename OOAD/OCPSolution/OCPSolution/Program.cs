using System;
using OCPSolution.Model;

namespace OCPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(1001, "Sumit Gupta", 50000, 50000, 5, new DiwaliRate());
            PrintInfo(fixedDeposit);
        }

        private static void PrintInfo(FixedDeposit fixedDeposit)
        {
            Console.WriteLine("======= Fixed Deposit Info ========");
            Console.WriteLine("Account Number   :   " + fixedDeposit.AccountNumber);
            Console.WriteLine("Account Name     :   " + fixedDeposit.AccountName);
            Console.WriteLine("Amount           :   " + fixedDeposit.Amount);
            Console.WriteLine("Years            :   " + fixedDeposit.Years);
            Console.WriteLine("Festival Rate    :   " + Math.Round(fixedDeposit.GetFestivalRate.getRate(),2));
            Console.WriteLine("Total Amount     :   " + Math.Round(fixedDeposit.CalculateSimpleInterest(), 2));
        }
    }
}
