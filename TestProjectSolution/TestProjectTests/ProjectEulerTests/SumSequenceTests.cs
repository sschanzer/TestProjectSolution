using System;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="SumSequence"/> class.
	/// </summary>
	[TestClass]
	public class SumSequenceTests
	{
		/// <summary>
		/// Tests the <see cref="SumSequence.GetSumMultiplesOfThreeAndFiveDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, 23)]
        [DataRow(20, 78)]
        [DataRow(1000, 233168)]
        public void TestSumSequence_GetSumDumb(int num, int expectedResult)
		{
            var result = SumSequence.GetSumMultiplesOfThreeAndFiveDumb(num);
            Assert.AreEqual(expectedResult, result);
		}

        /// <summary>
		/// Tests the <see cref="SumSequence.GetSumMultiplesOfThreeAndFiveStillDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, 23)]
        [DataRow(20, 78)]
        [DataRow(1000, 233168)]
        public void TestSumSequence_GetSumStillDumb(int num, int expectedResult)
        {
            var result = SumSequence.GetSumMultiplesOfThreeAndFiveStillDumb(num);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="SumSequence.GetSumMultiplesOfThreeAndFiveAnotherDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, 23)]
        [DataRow(20, 78)]
        [DataRow(1000, 233168)]
        public void TestSumSequence_GetSumAnotherDumb(int num, int expectedResult)
        {
            var result = SumSequence.GetSumMultiplesOfThreeAndFiveAnotherDumb(num);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="SumSequence.GetSumSlick(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, 23)]
        [DataRow(20, 78)]
        [DataRow(1000, 233168)]
        public void TestSumSequence_GetSumSlick(int num, int expectedResult)
        {
            var result = SumSequence.GetSumSlick(num);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Tests <see cref="SumSequence.SumOfMultiples(int, int)"/> for various inputs to validate the sum of multiples calculation.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(3, 9, 18)]
        [DataRow(5, 20, 50)]
        [DataRow(7, 28, 70)]
        [DataRow(1, 5, 15)]
        [DataRow(10, 100, 550)]
        [DataRow(2, 1, 0)]
        public void TestSumSequence_SumOfMultiples_ValidCases(int n, int limit, int expectedResult)
        {
            var result = SumSequence.SumOfMultiples(n, limit);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Tests <see cref="SumSequence.SumOfSquares(int)"/> for various inputs to validate the sum of squares formula.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1, 1)]
        [DataRow(3, 14)]
        [DataRow(5, 55)]
        [DataRow(10, 385)]
        [DataRow(0, 0)]
        public void TestSumSequence_SumOfSquares_ValidCases(int n, int expectedResult)
        {
            var result = SumSequence.SumOfSquares(n);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385.
        /// The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025.
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, 2640)]
        [DataRow(100, 25164150)]
        public void TestSumSequence_ProjectEulerProblemSix(int num, int expectedResult)
        {
            int sumOfNumbersUpToNum = SumSequence.SumOfMultiples(1, num);
            int sumOfSquares = SumSequence.SumOfSquares(num);

            var squareOfSum = Math.Pow(sumOfNumbersUpToNum, 2);

            var difference = squareOfSum - sumOfSquares;

            Assert.AreEqual(expectedResult, difference);
        }
    }
}
