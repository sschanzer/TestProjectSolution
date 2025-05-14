// <copyright file="BigIntegerExtensions.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Utilities
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods that extend the computational utility of BigIntegers.
    /// </summary>
    public static class BigIntegerExtensions
    {
        /// <summary>
        /// Calculates the integer square root of a non-negative BigInteger; i.e. the greatest integer less than or equal to the true square root of the input.
        /// </summary>
        /// <param name="num">Argument of the square root function.</param>
        /// <returns>The integer square root of <paramref name="num"/>.</returns>
        /// <remarks>
        /// Uses binary search to efficiently find the floor of the square root.
        /// Should converge in O(log num) steps.
        /// </remarks>
        public static BigInteger IntegerSqrt(this BigInteger num)
        {
            if (num < 0)
            {
                return -1;
            }

            if (num == 0 || num == 1)
            {
                return num;
            }

            BigInteger low = 0;
            BigInteger high = num;

            while (low <= high)
            {
                BigInteger mid = (low + high) / 2;
                BigInteger midSquared = mid * mid;

                if (midSquared == num)
                {
                    return mid;
                }
                else if (midSquared < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return high;
        }

        /// <summary>
        /// Calculates the integer floor of the n-th root of a non-negative BigInteger.
        /// For example, IntegerRoot(27, 3) returns 3, since 3^3 = 27.
        /// </summary>
        /// <param name="value">The BigInteger whose root is to be calculated.</param>
        /// <param name="num">The degree of the root.</param>
        /// <returns>The largest integer r such that r^n ≤ input; or -1 if bad input is provided.</returns>
        public static BigInteger IntegerRoot(this BigInteger value, int num)
        {
            if (num == 1)
            {
                return value;
            }

            if (num < 1)
            {
                return -1;
            }

            if (value < 0)
            {
                return -1;
            }

            if (value == 0 || value == 1)
            {
                return value;
            }

            BigInteger low = 0;
            BigInteger high = value;

            while (low <= high)
            {
                BigInteger mid = (low + high) / 2;
                BigInteger midPow = BigInteger.Pow(mid, num);

                int comparer = midPow.CompareTo(value);

                if (comparer == 0)
                {
                    return mid;
                }
                else if (comparer < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return high;
        }

        /// <summary>
        /// Calculates the factorial of the given input.
        /// </summary>
        /// <param name="input">Input.</param>
        /// <returns>FactorialLarge of the input.</returns>
        public static BigInteger Factorial(this BigInteger input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("Input cannot be negative.");
            }

            if (input == 0 || input == 1)
            {
                return input;
            }

            BigInteger result = 1;

            for (BigInteger i = input; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Calculates the factorial of a larger input faster than <see cref="BigIntegerExtensions.Factorial(BigInteger)"/>.
        /// </summary>
        /// <param name="input">Input.</param>
        /// <returns>Factorial of the input.</returns>
        public static BigInteger FactorialLarge(this BigInteger input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException("Input cannot be negative.");
            }

            if (input == 0 || input == 1)
            {
                return input;
            }

            int processorCount = Environment.ProcessorCount;
            BigInteger n = input;

            BigInteger chunkSize = n / processorCount;
            if (chunkSize == 0)
            {
                chunkSize = 1;
            }

            var ranges = new List<(BigInteger start, BigInteger end)>();
            BigInteger start = 2;

            while (start <= n)
            {
                BigInteger end = BigInteger.Min(start + chunkSize - 1, n);
                ranges.Add((start, end));
                start = end + 1;
            }

            var partialResults = new ConcurrentBag<BigInteger>();

            Parallel.ForEach(ranges, range =>
            {
                BigInteger localProduct = 1;
                for (BigInteger i = range.start; i <= range.end; i++)
                {
                    localProduct *= i;
                }

                partialResults.Add(localProduct);
            });

            BigInteger result = 1;
            foreach (var part in partialResults)
            {
                result *= part;
            }

            return result;
        }

        /// <summary>
        /// Calculates the binomial coefficients of two positive integers.
        /// </summary>
        /// <param name="n">First number.</param>
        /// <param name="k">Second number.</param>
        /// <returns>The binomial coefficients of two positive integers.</returns>
        public static BigInteger Choose(this int n, int k)
        {
            if (n < 0 || k < 0 || n < k)
            {
                throw new ArgumentOutOfRangeException();
            }

            var result = Factorial(n) / (Factorial(k) * Factorial(n - k));

            return result;
        }
    }
}
