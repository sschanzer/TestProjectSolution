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
        /// Finds the sum of the path of a triangular array whose sum is maximal using a bottom up approach.
        /// </summary>
        /// <param name="filePath">File path of the array.</param>
        /// <returns>The max path's total.</returns>
        public static int FindMaxPathSum_BottomUp(string filePath)
        {
            var input = File.ReadAllLines(filePath);

            int[][] grid = input.Select(line => line.Split(' ').Select(int.Parse).ToArray()).ToArray();

            var bottom = (int[])grid[grid.Length - 1].Clone();

            for (int row = grid.Length - 2; row >= 0; row--)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    bottom[col] = grid[row][col] + Math.Max(bottom[col], bottom[col + 1]);
                }
            }

            return bottom[0];
        }

        /// <summary>
        /// Finds the sum of the path of a triangular array whose sum is maximal using a top down approach.
        /// </summary>
        /// <param name="filePath">File path of the array.</param>
        /// <returns>The max path's total.</returns>
        public static int FindMaxPathSum_TopDown(string filePath)
        {
            var input = File.ReadAllLines(filePath);

            int[][] grid = input.Select(line => line.Split(' ').Select(int.Parse).ToArray()).ToArray();

            var dynamicRow = new int[grid.Length];
            var path = new List<int>();

            // Add top element to dr
            dynamicRow[0] = grid[0][0];

            for (int r = 1; r < grid.Length; r++)
            {
                // Go right to left.
                for (int c = grid[r].Length - 1; c >= 0; c--)
                {
                    if (c == 0)
                    {
                        dynamicRow[c] = dynamicRow[c] + grid[r][c];
                    }
                    else if (c == grid[r].Length - 1)
                    {
                        dynamicRow[c] = dynamicRow[c - 1] + grid[r][c];
                    }
                    else
                    {
                        dynamicRow[c] = grid[r][c] + Math.Max(dynamicRow[c - 1], dynamicRow[c]);
                    }
                }
            }

            return dynamicRow.Max();
        }
    }
}
