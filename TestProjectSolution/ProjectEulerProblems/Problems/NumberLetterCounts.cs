// <copyright file="NumberLetterCounts.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class for Project Euler Problem 17 <see href="https://projecteuler.net/problem=17"/>.
    /// </summary>
    public static class NumberLetterCounts
    {
        /// <summary>
        /// Counts the number of letters are uses to write all numbes out up to the given bound.
        /// </summary>
        /// <param name="bound">The provided bound.</param>
        /// <returns>The number of letters uesed to write all numbes out up to the given bound.</returns>
        public static int CountLettersOfNumbers(int bound)
        {
            Dictionary<int, string> bases = new Dictionary<int, string>()
            {
                { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" },
                { 10, "ten" }, { 11,  "eleven" }, { 12,  "twelve" }, { 13,  "thirteen" }, { 14, "fourteen" }, { 15, "fifteen" }, { 16,  "sixteen" }, { 17, "seventeen" },
                { 18, "eighteen" }, { 19, "nineteen" },
            };

            Dictionary<int, string> tens = new Dictionary<int, string>()
            {
                { 20, "twenty" }, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" },
                { 60, "sixty" }, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" },
            };

            var words = new List<string>();

            for (int i = 1; i <= bound; i++)
            {
                // 1 to 100
                if (i <= 19)
                {
                    words.Add(bases[i]);
                }
                else if (i < 100)
                {
                    var tenss = (i / 10) * 10;
                    var digit = i % tenss;

                    if (digit == 0)
                    {
                        words.Add(tens[i]);
                    }
                    else
                    {
                        words.Add(tens[tenss] + bases[digit]);
                    }
                }
                else if (i < bound)
                {
                    var hundreds = i / 100;
                    var remainder = i % 100;

                    var word = bases[hundreds] + "hundred";

                    if (remainder > 0)
                    {
                        if (remainder <= 19)
                        {
                            word += bases.ContainsKey(remainder) ? $"and{bases[remainder]}" : $"and{tens[remainder]}";

                            words.Add(word);
                        }
                        else
                        {
                            int ten = (remainder / 10) * 10;
                            int digit = remainder % 10;
                            word += $"and{tens[ten]}";

                            if (digit > 0)
                            {
                                word += $"{bases[digit]}";
                            }

                            words.Add(word);
                        }
                    }
                    else
                    {
                        words.Add(word);
                    }
                }
                else
                {
                    words.Add("OneThousand");
                }
            }

            var sum = 0;

            foreach (var word in words)
            {
                sum += word.Length;
            }

            return sum;
        }
    }
}
