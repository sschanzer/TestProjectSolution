// <copyright file="AmicableNumbers.cs" company="PlaceholderCompany">
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
    /// Class containing methods related to amicable numbers.
    /// </summary>
    public static class AmicableNumbers
    {
        /// <summary>
        /// Gets the amicable number pairs less than n.
        /// </summary>
        /// <param name="n">The bound.</param>
        /// <returns>A dictionary of amicable number pairs less than the bound.</returns>
        public static Dictionary<int, int> GetAmicableNumbers(int n)
        {
            var numFactorSumDict = new Dictionary<int, int>();
            var result = new Dictionary<int, int>();

            for (int i = 4; i < n; i++)
            {
                var sum = Functions.GetProperDivisorSum(i);

                if (sum != 1)
                {
                    numFactorSumDict.Add(i, sum);
                }
            }

            foreach (var kvp in numFactorSumDict)
            {
                if (numFactorSumDict.ContainsKey(kvp.Value) && kvp.Key != kvp.Value)
                {
                    if (Functions.GetProperDivisorSum(kvp.Key) == kvp.Value && Functions.GetProperDivisorSum(kvp.Value) == kvp.Key)
                    {
                        if (!result.ContainsKey(kvp.Value))
                        {
                            result.Add(kvp.Key, kvp.Value);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the sum of the amicable numbers less than the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>The sum of the amicable numbers less than the bound.</returns>
        public static int GetSumOfAmicableNumbers(int bound)
        {
            var sum = 0;
            var amicableNumbers = GetAmicableNumbers(bound);

            foreach (var kvp in amicableNumbers)
            {
                sum += kvp.Key + kvp.Value;
            }

            return sum;
        }
    }
}
