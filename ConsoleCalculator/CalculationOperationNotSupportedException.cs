using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMessage = "Specified operation was out of the " +
            "range of valid values.";
        public string Operation { get; }

        public CalculationOperationNotSupportedException() : base(DefaultMessage)
        {
        
        }
        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage, innerException)
        {

        }

        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(DefaultMessage)
        {

        }
        public CalculationOperationNotSupportedException(string operation) :
            base(DefaultMessage) => Operation= operation;
        public CalculationOperationNotSupportedException(string operation, string message) :
          base(message) => Operation = operation;
        public override string ToString()
        {
            if(Operation ==null)
            {
                return base.ToString();
            }
            return base.ToString() + Environment.NewLine + $"Unsupported operaton : {Operation}";
        }
    }
}
