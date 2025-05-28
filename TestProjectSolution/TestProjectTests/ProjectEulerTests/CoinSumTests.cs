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
        /// Tests the <see cref="CoinSum.CountCoinPermutations(int[], int)"/> method.
        /// </summary>
        /// <param name="coins">Denomination of coins as an integer array.</param>
        /// <param name="targetSum">The target sum.</param>
        /// <param name="expected">Expected value.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(new int[] { 1, 2 }, 4, 4)]
        public void TestCoinSum_CountCoinPermutations(int[] coins, int targetSum, int expected)
        {
            var result = CoinSum.CountCoinPermutations(coins, targetSum);
            Assert.AreEqual(expected, result);
        }
    }
}
