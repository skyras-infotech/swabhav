using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAccountApp
{
    abstract class Account
    {
        private string accountNo;
        private string accountName;
        private double balance;
        private bool isWithdraw = false;

        public Account(string accountNo, string accountName, double balance)
        {
            this.accountNo = accountNo;
            this.accountName = accountName;
            this.balance = balance;
        }

        public bool ISWithdraw { get { return isWithdraw; } set { isWithdraw = value; } }
        public string AccountNo { get { return accountNo; } }
        public string AccountName { get { return accountName; } }
        public double Balance { get { return balance; } set { balance = value; } }

        public abstract void Withdraw(int amount);

        public void deposit(int amount) {
            balance = balance + amount;
        }
        }
 }
