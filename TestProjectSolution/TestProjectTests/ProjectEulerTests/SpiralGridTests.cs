namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="SpiralGrid"/> class.
    /// </summary>
    [TestClass]
    public class SpiralGridTests
    {
        /// <summary>
        /// Tests the <see cref="SpiralGrid.GetDiagonalSumOfSpiralGrid(int)"/> method.
        /// </summary>
        /// <param name="size">The number of rows and columns of the grid.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(5, 101)]
        [DataRow(1001, 669171001)]
        public void TestSpiralGrid_GetDiagonalSumOfSpiralGrid(int size, int expected)
        {
            var result = SpiralGrid.GetDiagonalSumOfSpiralGrid(size);
            Assert.AreEqual(expected, result);
        }
    }
}
