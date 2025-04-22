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
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with numbers from 1 to 10.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_OneToTen()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = Enumerable.Range(1, 10).ToList();
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(2520, result);
        }

        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with numbers from 1 to 10.
        /// </summary>
        /// <remarks>
        /// This assert verifies Project Euler Problem 5.
        /// </remarks>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_OneToTwenty()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = Enumerable.Range(1, 10).ToList();
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(2520, result);
        }

        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with a single number in the list.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_SingleElement()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = new List<int> { 7 };
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(7, result);
        }

        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with identical elements.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_DuplicateElements()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = new List<int> { 3, 3, 3 };
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(3, result);
        }

        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method with prime numbers.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_PrimeNumbers()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = new List<int> { 2, 3, 5, 7 };
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(210, result);
        }

        /// <summary>
        /// Tests the <see cref="SmallestMultiple.FindSmallestMultiple(List{int})"/> method when list contains 1 and another number.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestSmallestMultiple_FindSmallestMultiple_OneAndAnotherNumber()
        {
            var smallestMultiple = new SmallestMultiple();
            var input = new List<int> { 1, 9 };
            var result = smallestMultiple.FindSmallestMultiple(input);
            Assert.AreEqual(9, result);
        }
    }
}
