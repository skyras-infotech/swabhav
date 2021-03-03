using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemoApp.Model
{
    
    class Account
    {
        private string _accountNo;
        private string _accountName;
        private double _balance;
        private int _noOfTransaction;
        private bool _isWithdraw;
        private List<IListner> _listners; 
        public Account(string accountNo, string accountName, double balance)
        {
            _accountNo = accountNo;
            _accountName = accountName;
            _balance = balance;
            _isWithdraw = false;
            _noOfTransaction = 0;
            _listners = new List<IListner>();
        }

        public string AccountNo { get { return _accountNo; } }
        public string AccountName { get { return _accountName; } }
        public double Balance { get { return _balance; } }
        public int NoOfTransaction { get { return _noOfTransaction; } }
        public bool IsWithdraw { get { return _isWithdraw; } }


        public void Deposit(int amount) {
            _balance += amount;
            _noOfTransaction++;
            NotifyListner();
        }

        public void Withdraw(int amount) {
            if (_balance <= 500)
            {
                _isWithdraw = false;
            }
            else if (amount > _balance) {
                _isWithdraw = false;
            }
            else
            {
                _balance -= amount;
                if (_balance < 500)
                {
                    _isWithdraw = false;
                    _balance += amount;
                }
                _noOfTransaction++;
                _isWithdraw = true;
                NotifyListner();
            }
        }

        public void AddListner(IListner listner) {
            _listners.Add(listner);
        }

        public void NotifyListner() {
            foreach (var item in _listners)
            {
                item.Update(_accountNo,_balance,_isWithdraw);
            }
        }
    }
}
