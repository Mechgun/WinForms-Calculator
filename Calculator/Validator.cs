///////////////////////////31927 Application Development with C# .NET//////////////////////////////
///////////////////////////////////////Assignment 2////////////////////////////////////////////////
//////////////////////////////////Jizhen Zhang 99209126////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Validator
    {
        /// This method is to split the input string into array.
        /// The idea is use regular expression to seperate numbers and operators
        /// and then combine them together in right order
        /// <param name="str"></param>
        /// <returns></returns>
        public static string[] splitExpression(string str)
        {
            string[] numbers = Regex.Split(str, @"[\+\-\×\/\%\^]+");
            string[] operators = Regex.Split(str, @"[^\+\-\×\/\%\^]+");
            string[] expressionSet = new string[numbers.Length + operators.Length];

            int n = 0;      ///Index parameters
            int m = 0;      ///Index parameters

            if (numbers[0] == "")
            {
                for (int i = 0; i < expressionSet.Length; i += 2)
                {
                    expressionSet[i] = numbers[n];
                    n++;
                }
                for (int j = 1; j < expressionSet.Length; j += 2)
                {
                    expressionSet[j] = operators[m];
                    m++;
                }
            }
            else
            {
                for (int i = 0; i < expressionSet.Length; i += 2)
                {
                    expressionSet[i] = operators[n];
                    n++;
                }
                for (int j = 1; j < expressionSet.Length; j += 2)
                {
                    expressionSet[j] = numbers[m];
                    m++;
                }
            }
            expressionSet = expressionSet.Skip(1).ToArray();
            string[] finalExpression = expressionSet.Take(expressionSet.Length - 1).ToArray();
            return finalExpression;
        }

        /// This method is used to check expression validate or not
        /// <param name="args"></param>
        /// <returns></returns>
        public static Boolean checkExpValidation(ref string[] args)
        {
            if (!isNumber(args[args.Length - 1]))
            {
                return false;
            }
            if (!(isNumber(args[0]) || args[0] == "+" || args[0] == "-"))
            {
                return false;
            }
            if (isNumber(args[0]))
            {
                return checkOperator(args);
            }
            else
            {
                List<string> temp = args.ToList();         ///Add 0 in front of the expression to make
                temp.Insert(0, "0");                       /// sure all the expression is starts with 
                args = temp.ToArray();                     ///a number and also won't affect the result.
                return checkOperator(args);                ///
            }
        }

        /// This method is used to check the elements that contains operator will valiate 
        /// for the opeartion. Use regular expression to make sure opretors only contains
        /// the operation sign. 
        /// <param name="args"></param>
        /// <returns></returns>
        private static Boolean checkOperator(string[] args)
        {
            Regex regex = new Regex(@"[^\+\-\×\/\%\^]");
            for (int i = 0; i < args.Length; i += 2)
            {
                if (!isNumber(args[i]))
                {
                    return false;
                }
            }

            for (int j = 1; j < args.Length - 1; j += 2)
            {
                Match match = regex.Match(args[j]);
                if ((match.Success))
                {
                    return false;
                }
                else if (args[j].Length > 2)
                {
                    return false;
                }
                else if (args[j] == "+×" ||
                    args[j] == "-×" ||
                    args[j] == "+/" ||
                    args[j] == "-/" ||
                    args[j] == "+%" ||
                    args[j] == "-%" ||
                    args[j] == "+^" ||
                    args[j] == "-^")
                {
                    return false;
                }
            }
            return true;
        }

        /// Add "+" to single operator. "+" will not affect the calculation, however it will
        /// make every operator contains two operation sign. Therefore 6 basic operators has become to 12
        /// and this make the calculator has ability to deal with unary operators.
        /// <param name="args"></param>
        public static void addOperator(string[] args)
        {
            for (int i = 1; i < args.Length - 1; i += 2)
            {
                if (args[i].Length == 1)
                {
                    args[i] += "+";    ///Add + for single operator
                }

            }
        }

        /// For normal expression, the only possiblilities that has division by zero happen
        /// is input zero at the first time. The final validation is to check if zeros was
        /// inputed after / or % sign.
        /// <param name="args"></param>
        /// <returns></returns>
        public static Boolean checkZero(string[] args)
        {
            for (int j = 1; j < args.Length - 1; j += 2)
            {
                if ((args[j] == "/" ||
                   args[j] == "%" ||
                   args[j] == "/+" ||
                   args[j] == "/-" ||
                   args[j] == "%+" ||
                   args[j] == "%-") && double.Parse(args[j + 1]) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// Return true if input string is a double.
        /// <param name="str"></param>
        /// <returns></returns>
        private static Boolean isNumber(string str)
        {
            double number = 0;
            return double.TryParse(str, out number);
        }
    }
}
