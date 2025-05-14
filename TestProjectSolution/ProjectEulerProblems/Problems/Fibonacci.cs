// <copyright file="Fibonacci.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods relating to the Fibonacci sequence.
    /// </summary>
    public static class Fibonacci
    {
        /// <summary>
        /// Compiles a list of Fibonacci numbers.
        /// </summary>
        /// <param name="count">Number of terms of the seqeunce.</param>
        /// <returns>A list of Fibonacci numbers.</returns>
        public static List<BigInteger> GetFibonacciNumbers(int count)
        {
            if (count <= 0)
            {
                return new List<BigInteger>();
            }

            var fibList = new List<BigInteger>() { 0 };

            if (count == 1)
            {
                return fibList;
            }

            fibList.Add(1);

            while (fibList.Count < count)
            {
                var nextTerm = fibList[fibList.Count - 2] + fibList[fibList.Count - 1];
                fibList.Add(nextTerm);
            }

            return fibList;
        }

        /// <summary>
        /// Calculates the sum of even Fibonacci numbers up to the specified count,
        /// stopping early if a term exceeds 4,000,000. Returns -1 if count is negative.
        /// </summary>
        /// <param name="count">The number of Fibonacci terms to generate.</param>
        /// <returns>The sum of even-valued terms in the generated Fibonacci sequence,
        /// or -1 if the input is invalid.</returns>
        public static int GetEvenFibSum(int count)
        {
            var fibSum = 0;

            if (count < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return 0;
            }

            var fibList = new List<int>() { 0 };

            if (count == 1)
            {
                return 1;
            }

            fibList.Add(1);

            while (fibList.Count < count)
            {
                var nextTerm = fibList[fibList.Count - 2] + fibList[fibList.Count - 1];

                if (nextTerm > 4000000)
                {
                    return fibSum;
                }

                if (nextTerm % 2 == 0)
                {
                    fibSum += nextTerm;
                }

                fibList.Add(nextTerm);
            }

            return fibSum;
        }

        /// <summary>
        /// Calculates the sum of even Fibonacci numbers up to the specified count,
        /// stopping if a term exceeds 4,000,000. Returns -1 if count is negative.
        /// </summary>
        /// <param name="count">The number of Fibonacci terms to generate.</param>
        /// <param name="maxValue">The maximum Fibonacci value allowed (default is 4,000,000) since that is what the Project Euler Problem asks for.</param>
        /// <returns>The sum of the even-valued terms in the Fibonacci sequence; -1 if the input is invalid.</returns>
        public static int GetEvenFibSumRedux(int count, int maxValue = 4000000)
        {
            if (count < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return 0;
            }

            int a = 0;
            int b = 1;
            int sum = 0;

            for (int generatedTerms = 1; generatedTerms < count; generatedTerms++)
            {
                var nextTerm = a + b;

                if (nextTerm > maxValue)
                {
                    break;
                }

                if (nextTerm % 2 == 0)
                {
                    sum += nextTerm;
                }

                a = b;
                b = nextTerm;
            }

            return sum;
        }
    }
}
