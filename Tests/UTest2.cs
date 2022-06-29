using System;
using NUnit.Framework;

namespace calc.Test
{
    [TestFixture]
    public class TestAddition
    {
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(5, 12, 17)]
        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Addition addition = new Addition();
            double fullanswer = addition.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, fullanswer);
        }
    }

    public class TestSubtraction
    {
        [TestCase(1, 1, 0)]
        [TestCase(2, 2, 0)]
        [TestCase(5, 12, -7)]

        public void CalcTest(double firstNum, double secondNum, double answer)
        {
            Subtraction subtraction = new Subtraction();
            double fullanswer = subtraction.Calculate(firstNum, secondNum);
            Assert.AreEqual(answer, fullanswer);
        }
    }
}