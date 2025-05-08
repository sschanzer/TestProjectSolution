// <copyright file="TriangularNumbers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System.Collections.Generic;
    using System.Numerics;
    using ProjectEulerProblems.Utilities;

    /// <summary>
    /// Class containing methods related to Triangular Numbers.
    /// </summary>
    public static class TriangularNumbers
    {
        /// <summary>
        /// Gets the first n triangular numbers.
        /// </summary>
        /// <param name="num">Bound.</param>
        /// <returns>A list of Triangular numbers of length num.</returns>
        public static List<int> GetTriangularNumbers(int num)
        {
            var triangularNumberList = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                int triangularNumber = i * (i + 1) / 2;
                triangularNumberList.Add(triangularNumber);
            }

            return triangularNumberList;
        }

        /// <summary>
        /// Gets the first triangular number having at minimum n factors.
        /// </summary>
        /// <param name="num">The amount of factors we're looking for.</param>
        /// <returns>The first triangular number having n factors.</returns>
        public static int GetFirstTriangularNumberWithAtLeastNFactors(int num)
        {
            BigInteger factorCount = 0;
            int current = 1;

            while (factorCount <= num)
            {
                int triangularNumber = current * (current + 1) / 2;

                factorCount = GetFactorCount(triangularNumber);

                if (factorCount >= num)
                {
                    return triangularNumber;
                }

                current++;
            }

            return 0;
        }

        /// <summary>
        /// Gets the number of factors of a given list as a dictionary.
        /// </summary>
        /// <param name="numList">The list of numbers.</param>
        /// <returns>A dictionary with Keys = number, Values = number of factors.</returns>
        public static Dictionary<int, int> GetNumberOfFactorsDict(List<int> numList)
        {
            var factorCountDic = new Dictionary<int, int>();

            for (int i = 0; i < numList.Count; i++)
            {
                int factorCount = 1;

                for (int j = 1; j < numList[i]; j++)
                {
                    if (numList[i] % j == 0)
                    {
                        factorCount++;
                    }
                }

                factorCountDic[numList[i]] = factorCount;
            }

            return factorCountDic;
        }

        /// <summary>
        /// Gets the number of factors for the given number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The total number of factors the number has.</returns>
        private static BigInteger GetFactorCount(int number)
        {
            BigInteger factorCount = 0;
            BigInteger squareRoot = BigIntegerExtensions.IntegerSqrt(number);

            for (BigInteger i = 1; i <= squareRoot; i++)
            {
                if (number % i == 0)
                {
                    BigInteger pair = number / i;
                    factorCount += (i == pair) ? 1 : 2;
                }
            }

            return factorCount;
        }
    }
}
