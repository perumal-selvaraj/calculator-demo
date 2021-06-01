using System;
using CalculatorApp.Logic.Interface;

namespace CalculatorApp.Logic
{
    public class CalculatorService : ICalculatorService
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentNullException(nameof(num2), "Divider should not be 0");
            }

            return num1 / num2;
        }
    }
}
