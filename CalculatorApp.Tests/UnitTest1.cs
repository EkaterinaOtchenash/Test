using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValues_ReturnsCorrectResult()
        {
            // Arrangement: Подготовка объектов
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Action: Действие, которое мы тестируем
            int result = calculator.Add(a, b);

            // Assertion: Проверяем результат
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_SimpleValues_ReturnsCorrectResult()
        {
            var calculator = new Calculator();
            int a = 10;
            int b = 5;

            int result = calculator.Subtract(a, b);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
