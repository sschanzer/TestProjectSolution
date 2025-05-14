// <copyright file="Functions.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing some usful special/common mathematical functions.
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Calculates the factorial of the given input.
        /// </summary>
        /// <param name="input">Input.</param>
        /// <returns>FactorialLarge of the input.</returns>
        public static long Factorial(int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("Input cannot be negative.");
            }

            if (input == 0 || input == 1)
            {
                return 1;
            }

            long result = 1;

            for (int i = input; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Calculates the binomial coefficients of two positive integers.
        /// </summary>
        /// <param name="n">First number.</param>
        /// <param name="k">Second number.</param>
        /// <returns>The binomial coefficients of two positive integers.</returns>
        public static long Choose(int n, int k)
        {
            if (n < 0 || k < 0 || n < k)
            {
                throw new ArgumentOutOfRangeException();
            }

            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        /// <summary>
        /// Calculates the sum of the digits in a factorial.
        /// </summary>
        /// <param name="n">The number.</param>
        /// <returns>The sum of the digits in n!.</returns>
        public static int GetFactSum(this int n)
        {
            int sum = 0;
            var num = BigIntegerExtensions.Factorial(n);
            var numString = num.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                sum += int.Parse(numString[i].ToString());
            }

            return sum;
        }
    }
}
