// <copyright file="Products.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ProjectEulerProblems.Data;
    using ProjectEulerProblems.Utility;

    /// <summary>
    /// Class containing methods relating to the Products of Numbers.
    /// </summary>
    public static class Products
    {
        /// <summary>
        /// Find the largest product of a substring of a given length broken down step-by-step.
        /// </summary>
        /// <param name="lengthOfSubstring">Desired length.</param>
        /// <param name="number">Number to extract largest product from.</param>
        /// <returns>The max product of the substrings.</returns>
        public static long FindLargestSubstringProduct_BreakDown(int lengthOfSubstring, string number)
        {
            // Generates the starting indices for all possible substrings of length 'length' within 'bigNum'.
            var startingIndexes = Enumerable.Range(0, number.Length - lengthOfSubstring + 1);

            // Create all substrings of length 'length' starting from each index in 'startingIndexes'.
            var allSubstringsOfProvidedLength = startingIndexes.Select(x => number.Substring(x, lengthOfSubstring));

            // allSubstringsOfProvidedLength.Select(sub => sub.Select(x => x - '0')) converts each substring into an integer array of size = 'length' which we cast to a long to avoid overflow.
            // The linq statement .Select(sub => sub.Select(x => x - '0')) subtracts the ASCII value of '0' (which is 48) from the ASCII value of the digit x, which directly gives us the integer value.
            // we then aggregate it and get the product of the array entries.
            var allProducts = allSubstringsOfProvidedLength.Select(sub => sub.Select(x => (long)(x - '0')).Aggregate(1L, (a, b) => a * b));

            // Takes the maximum of all the products we calculated.
            var maxProduct = allProducts.Max();

            return maxProduct;
        }

        /// <summary>
        /// Find the largest product of a substring of a given length broken down step-by-step.
        /// </summary>
        /// <param name="lengthOfSubstring">Desired length.</param>
        /// <param name="number">Number to extract largest product from.</param>
        /// <returns>The max product of the substrings.</returns>
        public static long FindLargestSubstringProduct(int lengthOfSubstring, string number)
        {
            // We can combined the above steps into a single linq statement.
            var maxProduct = Enumerable.Range(0, number.Length - lengthOfSubstring + 1).Select(x => number.Substring(x, lengthOfSubstring)).Max(sub => sub.Select(y => (long)(y - '0')).Aggregate(1L, (a, b) => a * b));

            return maxProduct;
        }

        /// <summary>
        /// Determines the largest product of the given integer array.
        /// </summary>
        /// <param name="filePath">The path to the file containing the grid.</param>
        /// <param name="digits">Specifies the amount of entries our product should be.</param>
        /// <returns>The largest product found in the grid.</returns>
        public static long FindLargestProductOfGrid(string filePath, int digits)
        {
            var fileParser = new FileParser(filePath);

            int[,] grid = fileParser.ParseTextFileAsIntegerGrid();

            var rows = grid.GetLength(0);
            var columns = grid.GetLength(1);
            long maxProduct = 0;

            for (var row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    long prodRight = 1;
                    long prodLeft = 1;
                    long prodUp = 1;
                    long prodDown = 1;
                    long prodDiagonalDownRight = 1;
                    long prodDiagonalDownLeft = 1;
                    long prodDiagonalUpRight = 1;

                    // Check for product to the right
                    if (col + digits <= columns)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodRight *= grid[row, col + i];
                        }

                        maxProduct = Math.Max(maxProduct, prodRight);
                    }

                    // Check for product to the left
                    if (col - digits + 1 >= 0)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodLeft *= grid[row, col - i];
                        }

                        maxProduct = Math.Max(maxProduct, prodLeft);
                    }

                    // Check for product upwards
                    if (row - digits + 1 >= 0)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodUp *= grid[row - i, col];
                        }

                        maxProduct = Math.Max(maxProduct, prodUp);
                    }

                    // Check for product downwards
                    if (row + digits <= rows)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodDown *= grid[row + i, col];
                        }

                        maxProduct = Math.Max(maxProduct, prodDown);
                    }

                    // Check the diagonal product down and to the right
                    if (row + digits <= rows && col + digits <= columns)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodDiagonalDownRight *= grid[row + i, col + i];
                        }

                        maxProduct = Math.Max(maxProduct, prodDiagonalDownRight);
                    }

                    // Check diagonal down to the left
                    if (row + digits <= rows && col - digits + 1 >= 0)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodDiagonalDownLeft *= grid[row + i, col - i];
                        }

                        maxProduct = Math.Max(maxProduct, prodDiagonalDownLeft);
                    }

                    // Check diagonal up to the right
                    if (row >= digits && col + digits <= columns)
                    {
                        for (int i = 0; i < digits; i++)
                        {
                            prodDiagonalUpRight *= grid[row - i, col + i];
                        }

                        maxProduct = Math.Max(maxProduct, prodDiagonalUpRight);
                    }
                }
            }

            return maxProduct;
        }
    }
}
