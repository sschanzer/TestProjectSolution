// <copyright file="AbundantNumbers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ProjectEulerProblems.Utilities;

    /// <summary>
    /// Class containing methods related to abundant, deficient, and perfect numbers.
    /// </summary>
    public static class AbundantNumbers
    {
        /// <summary>
        /// Get a tuple with list of abundant numbers up to the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>List of abundant numbers up to the bound.</returns>
        public static List<int> GetAbundantNumbers(int bound)
        {
            var abundantList = new List<int>();

            for (int num = 2; num < bound; num++)
            {
                var sum = Functions.GetProperDivisorSum(num);

                if (sum > num)
                {
                    abundantList.Add(num);
                }
            }

            return abundantList;
        }

        /// <summary>
        /// Get a tuple with list of deficient numbers up to the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>List of deficient numbers up to the bound.</returns>
        public static List<int> GetDeficientNumbers(int bound)
        {
            var deficient = new List<int>();

            for (int num = 2; num < bound; num++)
            {
                var sum = Functions.GetProperDivisorSum(num);

                if (sum < num)
                {
                    deficient.Add(num);
                }
            }

            return deficient;
        }

        /// <summary>
        /// Get a tuple with list of perfect numbers up to the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>List of perfect numbers up to the bound.</returns>
        public static List<int> GetPerfectNumbers(int bound)
        {
            var perfect = new List<int>();

            for (int num = 2; num < bound; num++)
            {
                var sum = Functions.GetProperDivisorSum(num);

                if (sum == num)
                {
                    perfect.Add(num);
                }
            }

            return perfect;
        }

        /// <summary>
        /// Gets a the sum of numbers not expressible as a sum of two abundant numbers up to the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>The sum of integers that cannot be expressed as the sum of two abundant numbers.</returns>
        public static int GetAllNumbersNotASumOfTwoAbundantNumbers(int bound)
        {
            var sum = 0;
            var abundantNums = GetAbundantNumbers(bound).ToHashSet();

            for (int i = 1; i <= bound; i++)
            {
                bool isExpressableAsASumOfTwoAbundantNums = false;

                foreach (var num in abundantNums)
                {
                    if (num > i)
                    {
                        break;
                    }

                    if (abundantNums.Contains(i - num))
                    {
                        isExpressableAsASumOfTwoAbundantNums = true;
                        break;
                    }
                }

                if (!isExpressableAsASumOfTwoAbundantNums)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
