using System;
using static ConsoleCalculator.Enumerator;

namespace ConsoleCalculator
{
    class Calculator
    {
        public static double Calculate(double firstNum, double secondNum, Operator oper)
        {
            double result;

            switch (oper)
            {
                case Operator.Addition:
                    {
                        result = firstNum + secondNum;
                        return Math.Round(result, 2);
                    }
                case Operator.Subtraction:
                    {
                        result = firstNum - secondNum;
                        return Math.Round(result, 2);
                    }
                case Operator.Multiplication:
                    {
                        result = firstNum * secondNum;
                        return Math.Round(result, 2);
                    }
                case Operator.Division:
                    {
                        result = firstNum / secondNum;
                        return Math.Round(result, 2);
                    }
                case Operator.Percentage:
                    {
                        result = firstNum / secondNum * 100;
                        return Math.Round(result, 2);
                    }
                case Operator.Exponentiation:
                    {
                        result = Math.Pow(firstNum, secondNum);
                        return Math.Round(result, 2);
                    }
                case Operator.Root:
                    {
                        result = Math.Pow(firstNum, 1.0 / secondNum);
                        return Math.Round(result, 2);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
