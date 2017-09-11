///////////////////////////31927 Application Development with C# .NET//////////////////////////////
///////////////////////////////////////Assignment 2////////////////////////////////////////////////
//////////////////////////////////Jizhen Zhang 99209126////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Calculator
    {
        //Main method to calculate the expression
        //The evaluation is devided into three parts
        //First order is to calculate the power operators
        //Second order is to calculate all the high opeartors
        //Then calculates all + and - and then return results to main programs
        public static string evaluation(string[] args)
        {

            List<string> expression = args.ToList();

            string[] firstOperator = {"^+", "^-" };
            string[] secondOperator = { "×-", "/-", "%-", "×+", "/+", "%+" };
            string[] thirdOperator = { "+-", "--", "++", "-+" };

            for (int i = 1; i < expression.Count; i += 2)
            {
                if (firstOperator.Contains(expression[i]))
                {
                    expression[i - 1] = compute(expression[i], double.Parse(expression[i - 1]), double.Parse(expression[i + 1])).ToString();
                    expression.RemoveAt(i);
                    expression.RemoveAt(i);
                    i -= 2;
                }
            }

            for (int i = 1; i < expression.Count; i += 2)
            {
                if (secondOperator.Contains(expression[i]))
                {
                    expression[i - 1] = compute(expression[i], double.Parse(expression[i - 1]), double.Parse(expression[i + 1])).ToString();
                    expression.RemoveAt(i);
                    expression.RemoveAt(i);
                    i -= 2;
                }
            }

            for (int j = 1; j < expression.Count; j += 2)
            {
                if (thirdOperator.Contains(expression[j]))
                {
                    expression[j - 1] = compute(expression[j], double.Parse(expression[j - 1]), double.Parse(expression[j + 1])).ToString();
                    expression.RemoveAt(j);
                    expression.RemoveAt(j);
                    j -= 2;
                }
            }

            string result = expression[0];
            return result;
        }

        //This method is to compute results between two numbers.
        private static double compute(string op, double num1, double num2)
        {
            switch (op)
            {
                case "^+": return Math.Pow(num1, num2);
                case "^-": return Math.Pow(num1, (num2 * -1));
                case "×-": return num1 * (num2 * -1);
                case "/-": return num1 / (num2 * -1);
                case "%-": return num1 % (num2 * -1);
                case "+-": return num1 - num2;
                case "--": return num1 + num2;
                case "×+": return num1 * num2;
                case "/+": return num1 / num2;
                case "%+": return num1 % num2;
                case "++": return num1 + num2;
                case "-+": return num1 - num2;
                default: return 0;
            }
        }
    }
}
