using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCalculator
{
    internal class Calculator
    {
        private static bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private static double PerformOperation(string operatorString, double operand1, double operand2)
        {
            switch (operatorString)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                default:
                    throw new InvalidOperationException("Invalid operator: " + operatorString);
            }
        }

        /// <summary>
        /// Computes a infixed mathematical expression, in which each digit has a space between them.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>The result of the calculation</returns>

        static public double ComputeInfixedExpression(string expression)
        {
            string postFixExpression = ShuntingYard(expression);
            return ComputePostFixedExpression(postFixExpression);
        }

        /// <summary>
        /// Computes a postfixed mathematical expression, in which each digit has a space between them.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>The result of the calculation</returns>
        static public double ComputePostFixedExpression(string expression)
        {
            string[] tokens = expression.Split(' ');
            Stack<double> operands = new Stack<double>();

            foreach (string token in tokens)
            {
                if (IsOperator(token))
                {
                    double operand2 = operands.Pop();
                    double operand1 = operands.Pop();

                    operands.Push(PerformOperation(token, operand1, operand2));
                }
                else
                {
                    operands.Push(double.Parse(token));
                }
            }
            return operands.Pop();
        }

        /// <summary>
        /// Converts a infix mathematical expression into a post fix mathematical expresion.
        /// </summary>
        /// <param name="postFixExpression"></param>
        /// <returns>A string of a post fixed expression</returns>
        /// <exception cref="NotImplementedException"></exception>
        static public string ShuntingYard(string postFixExpression)
        {
            throw new NotImplementedException();
        }
    }
}
