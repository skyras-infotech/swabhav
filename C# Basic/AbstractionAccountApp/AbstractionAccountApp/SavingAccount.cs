using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAccountApp
{
    class SavingAccount : Account
    {
        public SavingAccount(string ano, string name, int balance) : base(ano, name, balance)
        {

        }

        public override void Withdraw(int amount)
        {
            if (Balance <= 500)
            {
                ISWithdraw = true;
            }
            else if (amount > Balance)
            {
                ISWithdraw = true;
            }
            else
            {
                Balance -= amount;
                ISWithdraw = false;
            }
          
        }
    }
}
