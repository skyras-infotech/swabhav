using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcLib;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestForCubeEven()
        {
            //Arrange
            int no = 2;
            Calculator c = new Calculator();
            int excepected = 8;

            //Act
            int actual = c.CubeEven(no);

            //Assert
            Assert.AreEqual(excepected, actual);
         }

        [TestMethod]
        public void TestForEven() {

            //Arrange
            int no = 10;
            Calculator c = new Calculator();
            string excepected = "Even";

            //Act
            string actual = c.OddEven(no);

            //Assert
            Assert.AreEqual(excepected, actual);
        }

        [TestMethod]
        public void TestForOdd()
        {

            //Arrange
            int no = 11;
            Calculator c = new Calculator();
            string excepected = "Odd";

            //Act
            string actual = c.OddEven(no);

            //Assert
            Assert.AreEqual(excepected, actual);
        }
    }
}
