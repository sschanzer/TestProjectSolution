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
    }
}
