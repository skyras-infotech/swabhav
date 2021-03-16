using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CreditBasedSelectionApp.Model;

namespace CandidateApp.Tests
{
    [TestClass]
    public class CandidateAppTest
    {
        [TestMethod]
        public void TestWhoIsBetter()
        {
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "John Dae";
            e1.CreditPoint = "A Grade";
            e1.Age = 25;

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.Age = 30;
            e2.Name = "McKay";
            e2.CreditPoint = "B Grade";

            Employee expected = e1;
            Employee actual = e1.WhoIsBetter(e2);

            Assert.AreEqual(expected.Name, actual.Name);
        }

        [TestMethod]
        public void TestWhoIsElder()
        {
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "John Dae";
            e1.CreditPoint = "A Grade";
            e1.Age = 25;

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.Age = 30;
            e2.Name = "McKay";
            e2.CreditPoint = "B Grade";

            Employee expected = e2;
            Employee actual = e1.WhoIsElder(e2);

            Assert.AreEqual(expected.Name, actual.Name);
        }
    }
}
