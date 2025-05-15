// <copyright file="UnitTest1.cs" company="MyTestProject">
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
    /// Tests for the <see cref="AmicableNumbers"/> class.
    /// </summary>
    [TestClass]
    public class AmicableNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="AmicableNumbers.GetAmicableNumbers(int)"/> method.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(300, new int[] { 220, 284 })]
        [DataRow(1211, new int[] { 220, 284, 1184, 1210 })]
        [DataRow(10000, new int[] { 220, 284, 1184, 1210, 2620, 2924, 5020, 5564, 6232, 6368 })]
        public void TestAmicableNumbers_GetAmicableNumbers(int input, int[] expected)
        {
            var result = AmicableNumbers.GetAmicableNumbers(input);
            var resultAsList = new List<int>();
            foreach (var kvp in result)
            {
                resultAsList.Add(kvp.Key);
                resultAsList.Add(kvp.Value);
            }

            CollectionAssert.AreEqual(expected, resultAsList);
        }

        /// <summary>
        /// Tests the <see cref="AmicableNumbers.GetSumOfAmicableNumbers(int)"/> method.
        /// </summary>
        /// <param name="input">The bound.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(285, 504)]
        [DataRow(1211, 2898)]
        [DataRow(10000, 31626)]
        public void TestAmicableNumbers_GetSumOfAmicableNumbers(int input, int expected)
        {
            var result = AmicableNumbers.GetSumOfAmicableNumbers(input);
            Assert.AreEqual(expected, result);
        }
    }
}
