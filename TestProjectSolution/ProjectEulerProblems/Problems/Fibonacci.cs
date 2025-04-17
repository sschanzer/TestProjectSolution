﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems
{
    /// <summary>
    /// Class containing methods relating to the Fibonacci sequence.
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// Compiles a list of Fibonacci numbers.
        /// </summary>
        /// <param name="count">Number of terms of the seqeunce.</param>
        /// <returns>A list of Fibonacci numbers.</returns>
        public List<BigInteger> GetFibonacciNumbers(int count)
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
        /// Project Euler Problem 2.
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms.
        /// By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million,
        /// find the sum of the even-valued terms.
        /// </summary>
        public int GetEvenFibSum(int count)
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
    }
}
