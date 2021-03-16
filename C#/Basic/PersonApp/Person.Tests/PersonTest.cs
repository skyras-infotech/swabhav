using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Person.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestForPersonWorkout()
        {
            PersonApp.Model.Person person = new PersonApp.Model.Person("McKay", "Male", 25, 1.5f, 60);
            float expected = 61.20f;

            float result = person.Workout();
            float actual = (float)Math.Round(result * 100f) / 100f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForPersonEat()
        {
            PersonApp.Model.Person person = new PersonApp.Model.Person("McKay", "Male", 25, 1.5f, 60);
            float expected = 63.00f;

            float result = person.Eat();
            float actual = (float)Math.Round(result * 100f) / 100f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForPersonCalaculateBMIIndex()
        {
            PersonApp.Model.Person person = new PersonApp.Model.Person("McKay", "Male", 25, 1.5f, 60);
            double expected = 29.99;

            person.Eat();
            person.Eat();
            person.Workout();
            double result = person.CalculateBMIIndex();

            double actual = Math.Round((Double)result, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
