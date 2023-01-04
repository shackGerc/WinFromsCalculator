using System;
using System.Collections.Generic;
using System.Linq;
using UserExceptions;

namespace WinFormsCalculator
{
    internal class Calculator
    {
        private static int TakePrecedence(string function)
        {
            int precedence = 0;
            if (new[] { "*", "/" }.Contains(function))
                precedence = 2;
            else if (new[] { "+", "-" }.Contains(function))
                precedence = 1;

            return precedence;
        }

        private static bool IsANumber(string token)
        {
            bool result = true;
            if (!double.TryParse(token, out _))
                result = false;

            return result;
        }

        private static bool IsAnOperator(string token)
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
        /// <returns>A double that is the result of the calculation</returns
        static public double ComputeInfixedExpression(string expression)
        {
            string postFixExpression = ShuntingYard(expression);
            return ComputePostFixedExpression(postFixExpression);
        }

        /// <summary>
        /// Computes a postfixed mathematical expression, in which each digit has a space between them.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>A double that is the result of the calculation</returns>
        static public double ComputePostFixedExpression(string expression)
        {
            // It is necessary to have spaces between the operators, operands and perentheses of the expression
            // to be processed due to the following Split
            string[] tokens = expression.Split(' ');
            Stack<double> operands = new Stack<double>();

            foreach (string token in tokens)
            {
                if (IsAnOperator(token))
                {
                    // If there are an operator in the expression and there are not at least two operands
                    // behind it, it means that the expression is wrong.
                    if(operands.Count > 1)
                    {
                        double operand2 = operands.Pop();
                        double operand1 = operands.Pop();
                        operands.Push(PerformOperation(token, operand1, operand2));
                    }
                    else
                        throw new PoorlyWrittenExpressionException();
                }
                else
                {
                    if (IsANumber(token))
                        operands.Push(double.Parse(token));
                    else
                        // If the token not is an operator or a number the expression is wrong.
                        throw new PoorlyWrittenExpressionException();
                }
            }
            return operands.Pop();
        }

        /// <summary>
        /// Converts a infix mathematical expression into a post fix mathematical expresion using Shunting Yard algorithm.
        /// </summary>
        /// <param name="inFixExpression"></param>
        /// <returns>A string of a post fixed expression</returns>
        /// <exception cref="MismatchedParenthesesException"></exception>
        /*
        This method is a simple implementation of the Maneuvering Platform algorithm, 
        you can see more data on it in the following link: 
        https://es.wikipedia.org/wiki/Algoritmo_shunting_yard
         */
        static public string ShuntingYard(string inFixExpression)
        {
            string[] tokens = inFixExpression.Split(' ');
            Stack<string> operators = new Stack<string>();
            Queue<string> postFixExpression = new Queue<string>();

            foreach (string token in tokens)
            {
                if (IsANumber(token))
                {
                    postFixExpression.Enqueue(token);
                }
                else if (IsAnOperator(token))
                {
                    while (operators.Count > 0 && IsAnOperator(operators.Peek()) &&
                        TakePrecedence(token) <= TakePrecedence(operators.Peek()))
                    {
                        postFixExpression.Enqueue(operators.Pop());

                    }
                    operators.Push(token);
                }
                else if (token == "(")
                    operators.Push(token);

                else if (token == ")")
                {
                    do
                    {
                        if (operators.Count == 1 && operators.Peek() != "(")
                            throw new MismatchedParenthesesException();

                        postFixExpression.Enqueue(operators.Pop());

                    } while (operators.Peek() != "(");

                    operators.Pop();
                }
            }
            while (operators.Count > 0)
                postFixExpression.Enqueue(operators.Pop());

            return string.Join(" ", postFixExpression);
        }
    }
}
