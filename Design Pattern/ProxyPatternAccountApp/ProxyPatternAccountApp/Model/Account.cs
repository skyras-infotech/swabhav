using System;

namespace ProxyPatternAccountApp.Model
{
    class Account
    {
        private int _ano;
        private string _name;
        private double _balance;

        public Account(int ano, string name, double balance)
        {
            _ano = ano;
            _name = name;
            _balance = balance;
        }

        public void Deposit(double amount) {
            _balance += amount;
            
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
            Console.WriteLine("Hello");
        }

        public double Balance
        {
            get { return _balance; }
        }


        public string Name
        {
            get { return _name; }
        }


        public int AccountNumber
        {
            get { return _ano; }
        }

    }
}
