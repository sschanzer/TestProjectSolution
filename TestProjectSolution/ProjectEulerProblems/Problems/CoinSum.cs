namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class containing methods related to summing the targeted sum of the coins.
    /// </summary>
    public static class CoinSum
    {
        /// <summary>
        /// Counts the number of ways to arrange coins that sum to the target targetSum.
        /// </summary>
        /// <param name="coins">Integer array of the coin values.</param>
        /// <param name="targetSum">The target value.</param>
        /// <returns>The number of ways to create the target value.</returns>
        public static int CountCoins(int[] coins, int targetSum)
        {
            int length = coins.Length;
            int[] dynamicRow = new int[targetSum + 1];
            dynamicRow[0] = 1;

            for (int i = 0; i < length; i++)
            {
                for (int j = coins[i]; j <= targetSum; j++)
                {
                    dynamicRow[j] += dynamicRow[j - coins[i]];
                }
            }

            return dynamicRow[targetSum];
        }
    }
}
