// <copyright file="IntegerCyclesTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for <see cref="IntegerCycles"/> class.
    /// </summary>
    [TestClass]
    public class IntegerCyclesTests
    {
        /// <summary>
        /// Tests the <see cref="IntegerCycles.GetIntegerCycles(int)"/> method.
        /// </summary>
        /// <param name="input">Number we want the cycle of.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(123, new int[] { 123, 312, 231 })]
        [DataRow(23, new int[] { 23, 32 })]
        [DataRow(66, new int[] { 66 })]
        public void TestIntegerCycles_GetIntegerCycles(int input, int[] expected)
        {
            var result = IntegerCycles.GetIntegerCycles(input);
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="IntegerCycles.GetPrimeCycles(int)"/> method.
        /// </summary>
        /// <param name="bound">Bound we want to go up to.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, new int[] { 2, 3, 5, 7 })]
        [DataRow(20, new int[] { 2, 3, 5, 7, 11, 13, 17 })]
        [DataRow(100, new int[] { 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, 97 })]
        public void TestIntegerCycles_GetPrimeCycles(int bound, int[] expected)
        {
            var result = IntegerCycles.GetPrimeCycles(bound);
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="IntegerCycles.CountPrimeCycles(int)"/> method.
        /// </summary>
        /// <param name="bound">Bound we want to go up to.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, 13)]
        [DataRow(1000000, 55)]
        public void TestIntegerCycles_CountPrimeCycles(int bound, int expected)
        {
            var result = IntegerCycles.CountPrimeCycles(bound);
            Assert.AreEqual(expected, result);
        }
    }
}
