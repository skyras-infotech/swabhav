namespace AccountLib
{
    public class Account
        {
            private string accountNo;
            private static int generateRandomNumber = 1000;
            private string accountName;
            private double balance;
            private int noOfTransaction = 0;
            private bool isWithdraw = false;

            public Account(string accountName, double balance)
            {
                accountNo = "SBI" + generateRandomNumber++;
                this.accountName = accountName;
                this.balance = balance;
            }

            public string AccountNo { get { return accountNo; } }
            public string AccountName { get { return accountName; } }
            public double Balance { get { return balance; } }
            public int NoOfTransaction { get { return noOfTransaction; } }
            public bool IsWithdraw { get { return isWithdraw; } }

            public void Deposit(int amount)
            {
                balance += amount;
                noOfTransaction++;
            }

            public void Withdraw(int amount)
            {
                if (balance <= 500)
                {
                    isWithdraw = true;
                    throw new InsufficientBalanceException("Sorry you do not have suffient balance\n");
                }
                else if (amount > balance)
                {
                    isWithdraw = true;
                    throw new InsufficientBalanceException("Sorry you do not have suffient balance\n");
                }
                else
                {

                    balance -= amount;
                    if (balance < 500)
                    {
                        isWithdraw = true;
                        balance += amount;
                        throw new InsufficientBalanceException("Sorry you do not have suffient balance\n");
                    }
                    noOfTransaction++;
                    isWithdraw = false;
                }
            }
        }
}
