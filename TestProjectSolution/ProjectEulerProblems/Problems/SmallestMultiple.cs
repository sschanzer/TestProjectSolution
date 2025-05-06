// <copyright file="SmallestMultiple.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Project Euler Problem 5.
    /// 2520 is the smallest number that can be divided by each of the numbers from $1$ to $10$ without any remainder.
    /// What is the smallest positive number that is evenly divisible with no remainder by all of the numbers from
    /// 1 to 20.
    /// </summary>
    public static class SmallestMultiple
    {
        /// <summary>
        /// Finds the smallest multiple of a list of numbers.
        /// </summary>
        /// <param name="numList">The list of numbers.</param>
        /// <returns>The smallest number evenly dividible by all numbers in the list.</returns>
        public static long FindSmallestMultiple(List<int> numList)
        {
            if (numList == null || numList.Count == 0)
            {
                return 0;
            }

            var result = (long)numList[0];

            for (int i = 1; i < numList.Count; i++)
            {
                result = DivisorsAndMultiples.Lcm(result, numList[i]);
            }

            return result;
        }
    }
}
