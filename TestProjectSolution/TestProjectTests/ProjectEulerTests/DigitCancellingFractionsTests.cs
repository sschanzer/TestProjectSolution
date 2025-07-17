// <copyright file="DigitCancellingFractionsTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Test class for the <see cref="DigitCancellingFractions"/> class.
    /// </summary>
    [TestClass]
    public class DigitCancellingFractionsTests
    {
        /// <summary>
        /// Tests the <see cref="DigitCancellingFractions.FindDigitCancelingFractions(int)"/> method.
        /// </summary>
        /// <param name="bound">The number we want to find digit cancelling fractions up to.</param>
        /// <param name="expected">The expected result.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(64, new int[] { 16, 64 })]
        public void TestDigitCancellingFractions_FindDigitCancelingFractions_OnlyOne(int bound, int[] expected)
        {
            var result = DigitCancellingFractions.FindDigitCancelingFractions(bound);

            var resultList = new List<int>();

            foreach (var pair in result)
            {
                resultList.Add(pair.numerator);
                resultList.Add(pair.denominator);
            }

            CollectionAssert.AreEqual(expected, resultList);
        }

        /// <summary>
        /// Tests the <see cref="DigitCancellingFractions.FindDigitCancelingFractions(int)"/> method.
        /// </summary>
        /// <param name="bound">The number we want to find digit cancelling fractions up to.</param>
        /// <param name="expected">The expected result.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, new int[] { 16, 64, 19, 95, 26, 65, 49, 98 })]
        public void TestDigitCancellingFractions_FindDigitCancelingFractions_ToOneHundred(int bound, int[] expected)
        {
            var result = DigitCancellingFractions.FindDigitCancelingFractions(bound);

            var resultList = new List<int>();

            foreach (var pair in result)
            {
                resultList.Add(pair.numerator);
                resultList.Add(pair.denominator);
            }

            CollectionAssert.AreEqual(expected, resultList);
        }

        /// <summary>
        /// Tests the <see cref="DigitCancellingFractions.GetProductOfDenominators(int)"/> method.
        /// </summary>
        /// <param name="bound">The number we want to find the denominator product of digit cancelling fractions up to.</param>
        /// <param name="expected">The expected result.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(100, 100)]
        public void TestDigitCancellingFractions_GetProductOfDenominators_ToOneHundred(int bound, int expected)
        {
            var result = DigitCancellingFractions.GetProductOfDenominators(bound);
            Assert.AreEqual(expected, result);
        }
    }
}
