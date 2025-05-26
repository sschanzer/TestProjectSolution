namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="DigitPowers"/> class.
    /// </summary>
    [TestClass]
    public class DigitPowersTests
    {
        /// <summary>
        /// Tests the <see cref="DigitPowers.GetDigitPowers(int)"/> method.
        /// </summary>
        /// <param name="exp">The exponent.</param>
        /// <param name="expected">The expected value.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(4, new[] { 1634, 8208, 9474 })]
        [DataRow(5, new[] { 4150, 4151, 54748, 92727, 93084, 194979 })]
        public void TestDigitPowers_GetDigitPowers(int exp, int[] expected)
        {
            var result = DigitPowers.GetDigitPowers(exp);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
