namespace OCPSolution.Model
{
    class FixedDeposit
    {
        private int _accountNo;
        private string _name;
        private double _amount;
        private double _principle;
        private int _years;
        private IFestivalRate _festivalRate;

        public FixedDeposit(int accountNo, string name, double amount, double principle, int years, IFestivalRate festivalRate)
        {
            _accountNo = accountNo;
            _name = name;
            _amount = amount;
            _principle = principle;
            _years = years;
            _festivalRate = festivalRate;
        }

        public IFestivalRate GetFestivalRate {
            get { return _festivalRate;  }
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

        public double CalculateSimpleInterest()
        {
            return Amount + (_principle * GetFestivalRate.getRate() * _years / 100);
        }
    }
}
