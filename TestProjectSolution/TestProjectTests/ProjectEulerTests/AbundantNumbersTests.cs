// <copyright file="AbundantNumbersTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="AbundantNumbers"/> class.
    /// </summary>
    [TestClass]
    public class AbundantNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="AbundantNumbers.GetAbundantNumbers(int)"/> method.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="expectedLengths">Expected lengths of the lists.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, 21)]
        public void TestAbundantNumbers_GetAbundantNumbers(int bound, int expectedLengths)
        {
            var result = AbundantNumbers.GetAbundantNumbers(bound);
            Assert.AreEqual(expectedLengths, result.Count);
        }

        /// <summary>
        /// Tests the <see cref="AbundantNumbers.GetDeficientNumbers(int)"/> method.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="expectedLengths">Expected lengths of the lists.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, 75)]
        public void TestAbundantNumbers_GetDeficientNumbers(int bound, int expectedLengths)
        {
            var result = AbundantNumbers.GetDeficientNumbers(bound);
            Assert.AreEqual(expectedLengths, result.Count);
        }

        /// <summary>
        /// Tests the <see cref="AbundantNumbers.GetPerfectNumbers(int)"/> method.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="expectedLengths">Expected lengths of the lists.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, 2)]
        public void TestAbundantNumbers_GetPerfectNumbers(int bound, int expectedLengths)
        {
            var result = AbundantNumbers.GetPerfectNumbers(bound);
            Assert.AreEqual(expectedLengths, result.Count);
        }

        /// <summary>
        /// Tests the <see cref="AbundantNumbers.GetAllNumbersNotASumOfTwoAbundantNumbers(int)"/> method.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="expectedSum">The expected sum of the entries on the list.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(28123, 4179871)]
        public void TestAbundantNumbers_GetAllNumbersNotASumOfTwoAbundantNumbers(int bound, int expectedSum)
        {
            var result = AbundantNumbers.GetAllNumbersNotASumOfTwoAbundantNumbers(bound);
            Assert.AreEqual(expectedSum, result);
        }
    }
}
