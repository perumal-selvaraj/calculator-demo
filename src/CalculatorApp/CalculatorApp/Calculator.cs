using System;
using CalculatorApp.Logic.Interface;

namespace CalculatorApp
{
    internal class Calculator
    {
        private readonly ICalculatorService _calculatorService;

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public void Calculate(int num1, int num2)
        {
            Console.WriteLine($"Addition : {_calculatorService.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction : {_calculatorService.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication : {_calculatorService.Multiplication(num1, num2)}");
            Console.WriteLine($"Division : {_calculatorService.Division(num1, num2)}");
        }
    }
}
