using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptions
{
    public class PoorlyWrittenExpressionException : Exception
    {
        private static string defaultMessage = "The expression cannot be processed because there are errors in it," +
            "please check the spaces between operators, operands and parentheses"; 
        public PoorlyWrittenExpressionException() : base(defaultMessage) { }
        public PoorlyWrittenExpressionException(string message) : base(message) { }
        public PoorlyWrittenExpressionException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
