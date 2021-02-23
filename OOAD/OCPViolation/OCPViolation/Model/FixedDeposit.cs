using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Model
{
    class FixedDeposit
    {
        private int _accountNo;
        private string _name;
        private double _amount;
        private double _principle;
        private int _years;
        private FestivalType _festival;
        private const float HOLI_RATE = 0.05f;
        private const float DIWALI_RATE = 0.08f;
        private const float NORMAL_RATE = 0.03f;

        public FixedDeposit(int accountNo, string name, double amount, double principle, int years, FestivalType festival)
        {
            _accountNo = accountNo;
            _name = name;
            _amount = amount;
            _principle = principle;
            _years = years;
            _festival = festival;
        }

        public FestivalType Festival
        {
            get { return _festival; }
        }


        public int Years
        {
            get { return _years; }
        }


        public double Principle
        {
            get { return _principle; }
        }


        public double Amount
        {
            get { return _amount; }
        }


        public string AccountName
        {
            get { return _name; }
        }


        public int AccountNumber
        {
            get { return _accountNo; }
        }

        public double CalculateSimpleInterest() {
            if (Festival.Equals(FestivalType.HOLI)) 
            {
                return Amount + (_principle * HOLI_RATE * _years / 100);
            }
            else if (Festival.Equals(FestivalType.DIWALI))
            {
                return Amount + (_principle * DIWALI_RATE * _years / 100);
            }
            else
            {
                return Amount + (_principle * NORMAL_RATE * _years / 100);
            }

        }
    }
}
