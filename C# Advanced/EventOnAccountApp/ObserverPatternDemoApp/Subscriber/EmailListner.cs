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
        public void Update(String ano, double balance, bool isWithdraw)
        {
            string str = isWithdraw ? "debited" : "credited";
            Console.WriteLine("Email! Your account no XX" + ano[2] + ano[3] + " is " + str + " with " + balance);
        }
    }
}
