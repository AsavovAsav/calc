using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public static class TwoArgumentsFactory
    {
        public static double firstNum, secondNum;
        public static double Creatror(string calculatorName)

        {
            switch (calculatorName)
            {
                case "+":
                    Addition addition = new Addition();
                    return addition.Calculate(firstNum, secondNum);

                case "-":
                    Subtraction subtraction = new Subtraction();
                    return subtraction.Calculate(firstNum, secondNum);

                case "*":
                    Multiplication multiplication = new Multiplication();
                    return multiplication.Calculate(firstNum, secondNum);

                case "/":
                    Division division = new Division();
                    return division.Calculate(firstNum, secondNum);

                case "Степень":
                    Degree degree = new Degree();
                    return degree.Calculate(firstNum, secondNum);

                case "Остаток от деления":
                    Remainder remainder = new Remainder();
                    return remainder.Calculate(firstNum, secondNum);

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
