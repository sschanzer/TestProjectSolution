// <copyright file="MaxPathSum.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ProjectEulerProblems.Utility;

    /// <summary>
    /// Class for <see href="https://projecteuler.net/problem=18"/>.
    /// </summary>
    public static class MaxPathSum
    {
        /// <summary>
        /// Finds the sum of the path of a triangular array whose sum is maximal.
        /// </summary>
        /// <param name="filePath">File path of the array.</param>
        /// <returns>The max path's total.</returns>
        public static int FindMaxPathSum(string filePath)
        {
            var input = File.ReadAllLines(filePath);

            int[][] grid = input.Select(line => line.Split(' ').Select(int.Parse).ToArray()).ToArray();

            const int maxSum = 0;

            var bottom = (int[])grid[grid.Length - 1].Clone();

            for (int row = grid.Length - 2; row >= 0; row--)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    bottom[col] = grid[row][col] + Math.Max(bottom[col], bottom[col + 1]);
                }
            }

            var sum = bottom[0];

            return maxSum;
        }
    }
}
