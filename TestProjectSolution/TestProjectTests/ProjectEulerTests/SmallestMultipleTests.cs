// <copyright file="SmallestMultipleTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="SmallestMultiple"/> class.
    /// </summary>
    [TestClass]
    public class SmallestMultipleTests
    {
        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with various inputs.
        /// </summary>
        /// /// <param name="input">The input array.</param>
        /// <param name="expected">Expected output.</param>
        [DataTestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2520)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, 232792560)]
        [DataRow(new int[] { 7 }, 7)]
        [DataRow(new int[] { 3, 3, 3 }, 3)]
        [DataRow(new int[] { 2, 3, 5, 7 }, 210)]
        [DataRow(new int[] { 1, 9 }, 9)]
        public void TestSmallestMultiple_FindSmallestMultiple_VariousInputs(int[] input, int expected)
        {
            var result = SmallestMultiple.FindSmallestMultiple(input.ToList());
            Assert.AreEqual(expected, result);
        }
    }
}
