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
        /// Get a tuple with list of abundant, deficient, and perfect numbers up to the bound.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <returns>List of abundant, deficient, and perfect numbers up to the bound.</returns>
        public static (List<int> abundantList, List<int> deficientList, List<int> perfectList) GetAbundantDeficientAndPerfectNumbers(int bound)
        {
            var numFactorSumDict = new Dictionary<int, int>();
            var deficientList = new List<int>();
            var perfectList = new List<int>();
            var abundantList = new List<int>();

            for (int i = 2; i < bound; i++)
            {
                var sum = Functions.GetProperDivisorSum(i);
                numFactorSumDict.Add(i, sum);
            }

            foreach (var kvp in numFactorSumDict)
            {
                if (kvp.Key > kvp.Value)
                {
                    deficientList.Add(kvp.Key);
                }
                else if (kvp.Key == kvp.Value)
                {
                    perfectList.Add(kvp.Key);
                }
                else
                {
                    abundantList.Add(kvp.Key);
                }
            }

            return (abundantList, deficientList, perfectList);
        }

        /////// <summary>
        /////// Gets a list of numbers not expressible as a sum of two abundant numbers.
        /////// </summary>
        /////// <param name="abundantNumList">num</param>
        /////// <returns></returns>
        ////public static List<int> GetAllNumbersNotASumOfTwoAbundantNumbers(List<int> abundantNumList)
        ////{
        ////    int sum = 0;
        ////    var result = new List<int>();

        ////    for (int i = 0; i < abundantNumList.Count; i++)
        ////    {
        ////        for (int j = i; j < abundantNumList.Count; j++)
        ////        {
        ////            sum = abundantNumList[i] + abundantNumList[j];
        ////            result.Add(sum);
        ////        }
        ////    }

        ////    return result;
        ////}
    }
}
