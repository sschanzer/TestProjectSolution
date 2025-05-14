// <copyright file="TriangularNumbersTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="TriangularNumbers"/> class.
    /// </summary>
    [TestClass]
    public class TriangularNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="TriangularNumbers.GetTriangularNumbers(int)"/> method.
        /// </summary>
        /// <param name="num">Number of terms.</param>
        /// <param name="expected">Expected values.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(5, new int[] { 1, 3, 6, 10, 15 })]
        [DataRow(10, new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 })]
        [DataRow(15, new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91, 105, 120 })]

        public void TestTriangularNumbers_GetTriangularNumbers(int num, int[] expected)
        {
            var result = TriangularNumbers.GetTriangularNumbers(num);

            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="TriangularNumbers.GetNumberOfFactorsDict(List{int})"/> method.
        /// </summary>
        /// <param name="num">Number of terms.</param>
        /// <param name="expected">Expected values of the dictionary.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 }, new int[] { 1, 2, 4, 4, 4, 4, 6, 9, 6, 4 })]
        [DataRow(new int[] { 66, 78, 91, 105 }, new int[] { 8, 8, 4, 8 })]
        [DataRow(new int[] { 136, 153, 171, 190 }, new int[] { 8, 8, 6, 12 })]
        public void TestTriangularNumbers_GetNumberOfFactorsDict(int[] num, int[] expected)
        {
            var result = TriangularNumbers.GetNumberOfFactorsDict(num.ToList());

            Assert.AreEqual(expected.Length, result.Count, "The number of results does not match the expected number of results.");

            for (int i = 0; i < expected.Length; i++)
            {
                var expectedFactorCount = expected[i];
                var actualFactorCount = result[num[i]];

                Assert.AreEqual(expectedFactorCount, actualFactorCount, $"Mismatch for number {num[i]}: expected {expectedFactorCount}, got {actualFactorCount}");
            }
        }

        /// <summary>
        /// Tests the <see cref="TriangularNumbers.GetFirstTriangularNumberWithAtLeastNFactors(int)"/> method.
        /// </summary>
        /// <param name="num">Number of terms.</param>
        /// <param name="expected">Expected values of the dictionary.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(5, 28)]
        [DataRow(500, 76576500)]
        public void TestTriangularNumbers_GetFirstTriangularNumberWithNFactors(int num, int expected)
        {
            var result = TriangularNumbers.GetFirstTriangularNumberWithAtLeastNFactors(num);

            Assert.AreEqual(expected, result);
        }
    }
}
