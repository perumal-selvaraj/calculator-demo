using System;
using Microsoft.Extensions.DependencyInjection;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Calculator Demo ===============");

            var serviceProvider = ServiceManager.CreateServiceProvider();
            var calculator = serviceProvider.GetRequiredService<Calculator>();

            Console.WriteLine("Number #1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number #2 : ");
            int num2 = int.Parse(Console.ReadLine());
            calculator.Calculate(num1, num2);

            Console.ReadLine();
        }
    }
}
