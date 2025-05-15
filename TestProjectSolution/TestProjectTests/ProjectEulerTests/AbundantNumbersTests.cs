// <copyright file="AbundantNumbersTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

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
        /// <param name="expectedLengths">Expected lengths of the lists.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, new int[] { 21, 75, 2 })]
        public void TestAbundantNumbers_GetAbundantDeficientAndPerfectNumbers(int bound, int[] expectedLengths)
        {
            var result = AbundantNumbers.GetAbundantDeficientAndPerfectNumbers(bound);

            Assert.AreEqual(expectedLengths[0], result.abundantList.Count);
            Assert.AreEqual(expectedLengths[1], result.deficientList.Count);
            Assert.AreEqual(expectedLengths[2], result.perfectList.Count);
        }
    }
}
