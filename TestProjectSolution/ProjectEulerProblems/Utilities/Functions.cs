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
        public static int GetFactorialDigitsSum(this int n)
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

        /// <summary>
        /// Gets all factors of the given number.
        /// </summary>
        /// <param name="num">The numer to determine it's factors.</param>
        /// <returns>A list of factors of num.</returns>
        public static List<long> GetFactors(long num)
        {
            bool negativeNum = num < 0;

            if (negativeNum)
            {
                num *= -1;
            }

            var factors = new List<long>();

            if (num == 0)
            {
                return factors;
            }

            if (num == 1)
            {
                factors.Add(1);
                return factors;
            }

            for (int i = 1; i <= Math.Pow(num, 0.5); i++)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                    factors.Add(num / i);
                }
            }

            if (negativeNum)
            {
                for (int i = 0; i < factors.Count; i++)
                {
                    factors[i] *= -1;
                }
            }

            var result = factors.ToList();
            result.Sort();

            return result;
        }

        /// <summary>
        /// Calculates the sum of proper divisors of a number.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>Sum of proper divisors.</returns>
        public static int GetProperDivisorSum(int num)
        {
            if (num == 1)
            {
                return 0;
            }

            var sum = 1;
            for (int i = 2; i <= Math.Pow(num, 0.5); i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                    var pair = num / i;

                    if (pair != i)
                    {
                        sum += pair;
                    }
                }
            }

            return sum;
        }
    }
}
