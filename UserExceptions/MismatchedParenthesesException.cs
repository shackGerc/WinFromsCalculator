using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptions
{
    [Serializable]
    public class MismatchedParenthesesException : Exception
    {
        private static string defaultMessagge = "Can't find a " +
            "left parenthesis for a right parenthesis, there are mismatched parentheses in the expression";
        public MismatchedParenthesesException(): base(defaultMessagge) { }
        public MismatchedParenthesesException(string message) : base(message) { }
        public MismatchedParenthesesException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}
