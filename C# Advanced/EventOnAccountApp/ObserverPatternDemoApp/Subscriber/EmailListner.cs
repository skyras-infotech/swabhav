using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventOnAccountApp.Publisher;

namespace EventOnAccountApp.Subscriber
{
    class EmailListner : IListner
    {
        public EmailListner(Account account) 
        {
            account.NotifyOnTransactionPerformed += Update;
        }
        public void Update(Account account)
        {
            string str = account.IsWithdraw ? "debited" : "credited";
            Console.WriteLine("Email! Your account no XX" + account.AccountNo[2] + account.AccountNo[3] + " is " + str + " with " + account.Balance);
        }
    }
}
