// <copyright file="DigitCancellingFractions.cs" company="PlaceholderCompany">
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
    /// A class containing methods related to digit cancelling fractions.
    /// </summary>
    /// <see href="https://projecteuler.net/problem=33">Problem 33 description.</see>
    public static class DigitCancellingFractions
    {
        /// <summary>
        /// Finds digit cancelling fractions up to num.
        /// </summary>
        /// <returns>A list of digit cancelling fractions</returns>
        public static List<(int numerator, int denominator)> FindDigitCancelingFractions(int num)
        {
            var results = new List<(int numerator, int denominator)>();

            for (int i = 11; i < num; i++)
            {
                for (int j = i + 10; j <= num; j++)
                {
                    var numeratorString = i.ToString();
                    var denominatorString = j.ToString();

                    var oldFraction = (double)i / j;

                    if (int.Parse(numeratorString[1].ToString()) != 0)
                    {
                        for (int k = 0; k < numeratorString.Length; k++)
                        {
                            var c = numeratorString[k];
                            int indexInDenometator = denominatorString.IndexOf(c);

                            if (indexInDenometator != -1)
                            {
                                var newNumerator = int.Parse(numeratorString.Remove(numeratorString.IndexOf(c), 1));
                                var newDenominator = int.Parse(denominatorString.Remove(indexInDenometator, 1));

                                var newFraction = (double)newNumerator / newDenominator;

                                if (newFraction == oldFraction)
                                {
                                    results.Add((numerator: i, denominator: j));
                                }
                            }
                        }
                    }
                }
            }

            return results;
        }
    }
}
