// <copyright file="SumSequence.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class containing methods relating to Summing Sequences of Numbers.
    /// </summary>
    public static class SumSequence
    {
        /// <summary>
        /// Method determines the sum of all multiples of 3 and 5 below n.
        /// </summary>
        /// <param name="n">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        public static int GetSumMultiplesOfThreeAndFiveDumb(int n)
        {
            var multiplesOfThree = new List<int>();
            for (int i = 3; i < n; i += 3)
            {
                multiplesOfThree.Add(i);
            }

            var multiplesOfFive = new List<int>();
            for (int i = 5; i < n; i += 5)
            {
                if (!multiplesOfThree.Contains(i))
                {
                    multiplesOfFive.Add(i);
                }
            }

            var multiples = multiplesOfThree.Union(multiplesOfFive);

            return multiples.Sum();
        }

        /// <summary>
        /// Method determines the sum of all multiples of 3 and 5 below n.
        /// </summary>
        /// <param name="n">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        public static int GetSumMultiplesOfThreeAndFiveStillDumb(int n)
        {
            var multiples = new HashSet<int>();

            for (int i = 3; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }

            return multiples.Sum();
        }

        /// <summary>
        /// Method determines the sum of all multiples of 3 and 5 below n.
        /// </summary>
        /// <param name="n">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        public static int GetSumMultiplesOfThreeAndFiveAnotherDumb(int n)
        {
            int sum = 0;
            for (int i = 3; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        /// <summary>
        /// Method determines the sum of all multiples of 3 and 5 below n.
        /// </summary>
        /// <param name="bound">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        /// <remarks>
        /// This is O(1) runtime.
        /// </remarks>
        public static int GetSumSlick(int bound)
        {
            return SumOfMultiples(3, bound - 1) + SumOfMultiples(5, bound - 1) - SumOfMultiples(15, bound - 1);
        }

        /// <summary>
        /// Gets the sum of all multiples of n up to and including limit, if divisible.
        /// </summary>
        /// <param name="n">The number we want to find the sum of multiples for.</param>
        /// <param name="limit">The upper bound where we should stop.</param>
        /// <returns>the sum of all multiples of n up to and including limit, if divisible.</returns>
        /// <remarks>
        /// Note:
        ///
        ///     Sum_{i}^{k} j = 1 + 2 + 3 + ... + k = k * (k + 1) / 2
        ///
        /// Proof:
        /// Write the sum forwards and backwards:
        ///     S = 1 + 2 + 3 + ... + (k - 1) + k
        ///     S = k + (k - 1) + (k - 2) + ... + 2 + 1
        ///
        /// Then:
        ///     S + S = 2S = (1 + k) + (2 + (k - 1)) + (3 + (k - 2)) + ... + (k + 1)
        ///
        ///                = (1 + k) + (k + 1) + (k + 1) + ... + (k + 1)
        ///
        ///                = k * (1 + k)
        ///
        /// So,
        ///          2S = k * (1 + k)
        ///
        ///          =>
        ///
        ///                      S = k * (k + 1) / 2.
        /// </remarks>
        public static int SumOfMultiples(int n, int limit)
        {
            int k = limit / n;
            var sum = n * k * (k + 1) / 2;

            return sum;
        }

        /// <summary>
        /// Gets the sum of suqares up to n.
        /// </summary>
        /// <param name="n">The upper bound where we should stop.</param>
        /// <returns>The sum of squares up to the limit.</returns>
        /// <remarks>
        /// Note:
        ///
        /// Sum_{k=1}^{n} k^2 = (1/6) * n * (n + 1) * (2n + 1)
        ///
        /// The following identity is the the trick needed for a direct proof:
        ///
        /// (k + 1)^2 - k^3 = 3k^2 + 3k + 1
        ///
        /// Summing the left hand side of the identity above from k = 1 to n we get the telescoping sum:
        ///
        /// Sum_{k=1}^{n} [(k + 1)^3 - k^3] = (n + 1)^3 - 1^3 = n^3 + 3n^2 + 3n
        ///
        /// Summing the right hand side of the identity yeilds:
        ///
        /// Sum_{k=1}^{n} [(k + 1)^3 - k^3] = 3*Sum_{k=1}^{n} k^2 + 3Sum_{k=1}^{n} k + Sum_{k=1}^{n} 1
        ///
        /// So:
        ///
        /// 3Sum_{k=1}^{n} k^2 = n^3 + 3n^2 + 3n - 3/2(n(n + 1)) - n
        ///       = n^3 + 3n^2 + 3n - (3/2)n^2 - (3/2)n - n
        ///       = (1/2)(2n^3 + 3n^2 + n)
        ///
        /// Thus:
        ///
        /// Sum_{k=1}^{n} k² = (1/6) * n * (n + 1) * (2n + 1).
        /// </remarks>
        public static int SumOfSquares(int n)
        {
            var sumOfSuqares = (n * (n + 1) * ((2 * n) + 1)) / 6;

            return sumOfSuqares;
        }
    }
}
