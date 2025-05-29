namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="CoinSum"/> class.
    /// </summary>
    [TestClass]
    public class CoinSumTests
    {
        /// <summary>
        /// Tests the <see cref="CoinSum.CountCoins(int[], int)"/> method.
        /// </summary>
        /// <param name="coins">Denomination of coins as an integer array.</param>
        /// <param name="targetSum">The target sum.</param>
        /// <param name="expected">Expected value.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(new int[] { 1, 2 }, 4, 3)]
        [DataRow(new int[] { 1, 5, 10, 25, 100 }, 100, 243)]
        [DataRow(new int[] { 1, 2, 5, 10, 20, 50, 100, 200 }, 200, 73682)]
        public void TestCoinSum_CountCoins(int[] coins, int targetSum, int expected)
        {
            var result = CoinSum.CountCoins(coins, targetSum);
            Assert.AreEqual(expected, result);
        }
    }
}
