using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemoApp.Model
{
    interface IListner
    {
        void Update(String ano,double balance,bool isWithdraw);
    }
}
