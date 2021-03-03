using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternAccountDemoApp.Model
{
    class Account
    {
        private int _accountNo;
        private string _name;
        private string _branch;
        private double _interest;
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        public double Interest
        {
            get { return _interest; }
            set { _interest = value; }
        }


        public string Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public int AccountNumber
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }

        
    }
}
