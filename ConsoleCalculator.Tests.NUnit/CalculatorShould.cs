using NUnit.Framework;

namespace ConsoleCalculator.Tests.NUnit
{
    public class CalculatorShould
    {

        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();

            Assert.That(() => sut.Calculate(1, 2, "/"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());
        }
    }
}