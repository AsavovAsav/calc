using System;
using NUnit.Framework;

namespace calc.test.Tests
{
    [TestFixture]
    public class Degreetest
    {
        [TestCase(1, 1, 1)]
        [TestCase(5, 6, 15625)]
        [TestCase(3, 2, 9)]
        public void CalculateTest(double firstNum, double secondNum, double answer)
        {
            // actual result
            Degree degree = new Degree();
            double fullanswer = degree.Calculate(firstNum, secondNum);
            ;
            Assert.AreEqual(answer, fullanswer);
        }
    }
    public class Divisiontest
    {
        [TestCase(1, 1, 1)]
        [TestCase(6, 6, 1)]
        [TestCase(1000, 500, 2)]
        public void CalculateTest(double firstNum, double secondNum, double answer)
        {
            // actual result
            Division division = new Division();
            double fullanswer = division.Calculate(firstNum, secondNum);
            ;
            Assert.AreEqual(answer, fullanswer);
        }
    }
    public class Remaindertest
    {
        [TestCase(1, 1, 0)]
        [TestCase(5, 6, 5)]
        [TestCase(3, 2, 1)]
        public void CalculateTest(double firstNum, double secondNum, double answer)
        {
            // actual result
            Remainder remainder = new Remainder();
            double fullanswer = remainder.Calculate(firstNum, secondNum);
            ;
            Assert.AreEqual(answer, fullanswer);
        }
    }
}