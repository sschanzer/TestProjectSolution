namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for <see cref="PandigitalNumbers"/> class.
    /// </summary>
    [TestClass]
    public class PandigitalNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="PandigitalNumbers.PandigitalProduct(int)"/> method.
        /// </summary>
        /// <param name="n">Number inputted.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(5, 52)]
        [DataRow(9, 45228)]
        public void TestPandigitalNumbers_PandigitalProducts(int n, int expected)
        {
            var result = PandigitalNumbers.PandigitalProduct(n);
            Assert.AreEqual(expected, result);
        }
    }
}
