using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemoApp.Model
{
    class EmailListner : IListner
    {
        public void Update(String ano, double balance, bool isWithdraw)
        {
            string str = isWithdraw ? "debited" : "credited";
            Console.WriteLine("SMS! Your account no XX" + ano[2] + ano[3] + " is " + str + " with " + balance);
        }
    }
}
