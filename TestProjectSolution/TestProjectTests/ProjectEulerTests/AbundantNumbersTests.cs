namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="AbundantNumbers"/> class.
    /// </summary>
    [TestClass]
    public class AbundantNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="AbundantNumbers.GetAllNumbersNotASumOfTwoAbundantNumbers(System.Collections.Generic.List{int})"/> method.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, new int[] { 1, 2 })]
        public void TestAbundantNumbers_GetAbundantDeficientAndPerfectNumbers(int bound, int[] expected)
        {
            var result = AbundantNumbers.GetAbundantDeficientAndPerfectNumbers(bound);
            var waitUp = 1;
            Assert.AreEqual(expected, result);
        }
    }
}
