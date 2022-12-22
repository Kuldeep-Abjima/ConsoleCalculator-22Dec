using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //throw new ArgumentNullException(paramName: nameof(number1));
            string nonNullOperation = 
                operation ?? throw new ArgumentNullException(nameof(operation));
            //if(operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(".....logging......");

                    //throw;
                    throw new CalculationException(ex);

                }
            }
            else if(nonNullOperation == "+")
            {
                return add(number1, number2);
            }
            else
            {
                throw new CalculationOperationNotSupportedException(nonNullOperation);
                //throw new ArgumentOutOfRangeException(nameof(operation));
                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
        private int add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

