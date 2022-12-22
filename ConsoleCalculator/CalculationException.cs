using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
     public class CalculationException : Exception
    {
        private const string DefaultMessage = "An error occurd during calculation tht the values are wtiin the valis ranges for the requested operation";
        /// <summary>
        /// create a new <see cref="CalculationException"/> with a predefined message
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {

        }
        /// <summary>
        /// create a new <see cref="CalculationException"/> with a user-supplied message
        /// </summary>
        public CalculationException(string message) : base(message) { 
            
        }
        /// <summary>
        /// create a new <see cref="CalculationException"/> 
        /// with a predefined message and a wrapped inner exception.
        /// </summary>
        public CalculationException(Exception innerException) : base(DefaultMessage)
        {

        }

        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
