namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods related to summing the targetValue of coins.
    /// </summary>
    public static class CoinSum
    {
        /// <summary>
        /// Counts the number of ways to arrange coins that sum to the target targetValue.
        /// </summary>
        /// <param name="coins">Integer array of the coin values.</param>
        /// <param name="targetValue">The target value.</param>
        /// <returns>The number of ways to create the target value.</returns>
        public static int CountCoinPermutations(int[] coins, int targetValue)
        {
            int length = coins.Length;
            int[] dynamicRow = new int[targetValue + 1];
            dynamicRow[0] = 1;

            for (int i = 0; i < length; i++)
            {
                for (int j = coins[i]; j <= targetValue; j++)
                {
                    dynamicRow[j] += dynamicRow[j - coins[i]];
                }
            }

            return dynamicRow[targetValue];
        }
    }
}
