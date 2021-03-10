using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountsLib.Tests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void WithdrawTest()
        {
            double expected = 600;
            AccountLib.Account account = new AccountLib.Account("John Doe", 900);

            account.Withdraw(300);

            Assert.AreEqual(account.Balance, expected);

        }

        [TestMethod]
        public void DepositTest()
        {
            double expected = 1000;
            AccountLib.Account account = new AccountLib.Account("John Doe", 900);

            account.Deposit(100);

            Assert.AreEqual(account.Balance, expected);

        }
        [TestMethod]
        [ExpectedException(typeof(AccountLib.InsufficientBalanceException), "Sorry you do not have suffient balance")]
        public void ExceptionTest()
        {
            double expected = 1000;
            AccountLib.Account account = new AccountLib.Account("John Doe", 900);

            account.Withdraw(800);

            Assert.AreEqual(account.Balance, expected);

        }
    }
}
