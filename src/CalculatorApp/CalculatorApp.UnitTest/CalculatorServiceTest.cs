using CalculatorApp.Logic;
using CalculatorApp.Logic.Interface;
using NUnit.Framework;

namespace CalculatorApp.UnitTest
{
    public class CalculatorServiceTest
    {
        private ICalculatorService _calculatorService;

        [SetUp]
        public void Setup()
        {
            _calculatorService = new CalculatorService();
        }

        [TestCase(1, 2, 3)]
        [TestCase(11, 22, 33)]
        [TestCase(100, 200, 300)]
        [TestCase(111, 222, 333)]
        public void Test_Addition_Operation_Should_Return_Correct_Value(int num1, int num2, int expectedValue)
        {
            //Arrange
            // Act
            int actualValue = _calculatorService.Addition(num1, num2);

            //Assert
            Assert.True(actualValue == expectedValue, $"Expected : {expectedValue} - Actual : {actualValue}");
        }

        [TestCase(2, 1, 1)]
        [TestCase(22, 11, 11)]
        [TestCase(200, 100, 100)]
        [TestCase(222, 111, 111)]
        public void Test_Subtraction_Operation_Should_Return_Correct_Value(int num1, int num2, int expectedValue)
        {
            //Arrange
            // Act
            int actualValue = _calculatorService.Subtraction(num1, num2);

            //Assert
            Assert.True(actualValue == expectedValue, $"Expected : {expectedValue} - Actual : {actualValue}");
        }

        [TestCase(2, 2, 4)]
        [TestCase(10, 20, 200)]
        [TestCase(100, 200, 20000)]
        public void Test_Multiplication_Operation_Should_Return_Correct_Value(int num1, int num2, int expectedValue)
        {
            //Arrange
            // Act
            int actualValue = _calculatorService.Multiplication(num1, num2);

            //Assert
            Assert.True(actualValue == expectedValue, $"Expected : {expectedValue} - Actual : {actualValue}");
        }

        [TestCase(2, 2, 1)]
        [TestCase(20, 10, 2)]
        [TestCase(200, 2, 100)]
        public void Test_Division_Operation_Should_Return_Correct_Value(int num1, int num2, int expectedValue)
        {
            //Arrange
            // Act
            int actualValue = _calculatorService.Division(num1, num2);

            //Assert
            Assert.True(actualValue == expectedValue, $"Expected : {expectedValue} - Actual : {actualValue}");
        }
    }
}