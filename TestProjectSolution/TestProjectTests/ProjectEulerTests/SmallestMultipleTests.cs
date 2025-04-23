using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectTests.ProjectEulerTests
{
    [TestClass]
    public class SmallestMultipleTests
    {
        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with various inputs.
        /// </summary>
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
            var smallestMultiple = new SmallestMultiple();
            var result = smallestMultiple.FindSmallestMultiple(input.ToList());
            Assert.AreEqual(expected, result);
        }
    }
}
