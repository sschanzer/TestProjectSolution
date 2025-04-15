using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    /// <summary>
    /// Project Euler Problem 1.
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
    /// The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    public class MultiplesOf3And5
    {
        /// <summary>
        /// Method determines the sum of all multiples of 3 and 5 below n.
        /// </summary>
        /// <param name="n">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        public int GetSumDumb(int n)
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
        public int GetSumStillDumb(int n)
        {
            var multiples = new HashSet<int>();

            for (int i = 3; i < n; i ++)
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
        public int GetSumAnotherDumb(int n)
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
        /// <param name="n">The number to check up to.</param>
        /// <returns>The sum of all multiples of 3 and 5 below n.</returns>
        /// <remarks>
        /// This is O(1) runtime.
        /// </remarks>
        public int GetSumSlick(int n)
        {
            return this.SumOfMultiples(3, n - 1) + this.SumOfMultiples(5, n - 1) - this.SumOfMultiples(15, n - 1);
        }

        /// <summary>
        /// Gets the sum of all multiples of n up to and including limit, if divisible.
        /// </summary>
        /// <param name="n">The number we want to find the sum of multiples for.</param>
        /// <param name="limit">The upper bound where we should stop.</param>
        /// <returns>the sum of all multiples of n up to and including limit, if divisible.</returns>
        private int SumOfMultiples(int n, int limit)
        {
            int k = limit / n;

            // Note:
            //
            //     Sum_{i}^{k} i = 1 + 2 + 3 + ... + k = k * (k + 1) / 2
            //
            // Proof:
            // Write the sum forwards and backwards:
            //     S = 1 + 2 + 3 + ... + (k - 1) + k
            //     S = k + (k - 1) + (k - 2) + ... + 2 + 1
            //
            // Then:
            //     S + S = 2S = (1 + k) + (2 + (k - 1)) + (3 + (k - 2)) + ... + (k + 1)
            // 
            //                = (1 + k) + (k + 1) + (k + 1) + ... + (k + 1)
            //
            //                = k * (1 + k)
            //
            // So,
            //          2S = k * (1 + k)
            //
            //          =>
            //
            //                      S = k * (k + 1) / 2.

            var sum = n * k * (k + 1) / 2;

            return sum;


        }
    }
}
