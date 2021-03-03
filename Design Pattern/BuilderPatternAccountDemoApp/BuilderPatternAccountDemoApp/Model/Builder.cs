using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternAccountDemoApp.Model
{
    class Builder
    {
        private int _accountNo;
        private string _name;
        private string _branch;
        private double _interest;
        private double _balance;

        public Builder(int accountNo)
        {
            _accountNo = accountNo;
        }

        public Builder BuildName(string name)
        {
            _name = name;
            return this;
        }

        public Builder BuildBranch(string branch)
        {
            _branch = branch;
            return this;
        }
        public Builder BuildInterest(double interest)
        {
            _interest = interest;
            return this;
        }   
        public Builder BuildBalance(double balance)
        {
            _balance = balance;
            return this;
        }

        public Account Build() {
            Account account = new Account();
            account.AccountNumber = _accountNo;
            account.Name = _name;
            account.Balance = _balance;
            account.Branch = _branch;
            account.Interest = _interest;
            return account;
        }   
    }
}
