using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="Fibonacci"/> class.
	/// </summary>
	[TestClass]
	public class FibonacciTests
	{
        /// <summary>
        /// Tests the <see cref="Fibonacci.GetFibonacciNumbers(int)"/> method.
        /// </summary>
        [TestMethod]
		[TestCategory(TestList.Validation)]
		public void TestFibonacci_GetFirstTenFibonacciNumbers()
		{
			var fib = new Fibonacci();
			var fibList = fib.GetFibonacciNumbers(10);

			var expectedList = new List<BigInteger> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

			Assert.IsTrue(expectedList.SequenceEqual(fibList));
		}

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetFibonacciNumbers(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestFibonacci_GetTheHundredthTermOfTheFibonacciSequence()
        {
            var fib = new Fibonacci();
            var fibList = fib.GetFibonacciNumbers(100);

            BigInteger expectedNumber = BigInteger.Parse("218922995834555169026");

            Assert.AreEqual(expectedNumber, fibList.Last());
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetFibonacciNumbers(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestFibonacci_GetTheThousandthTermOfTheFibonacciSequence()
        {
            var fib = new Fibonacci();
            var fibList = fib.GetFibonacciNumbers(1000);

            BigInteger expectedNumber = BigInteger.Parse("26863810024485359386146727202142923967616609318986952340123175997617981700247881689338369654483356564191827856161443356312976673642210350324634850410377680367334151172899169723197082763985615764450078474174626");

            Assert.AreEqual(expectedNumber, fibList.Last());
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetEvenFibSum(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestFibonacci_GetEvenFibSum()
        {
            var fib = new Fibonacci();
            var fibSum = fib.GetEvenFibSum(34);

            const int ExpectedValue = 4613732;

            Assert.AreEqual(ExpectedValue, fibSum);
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetEvenFibSumRedux(int)"/> method.
        /// </summary>
        /// <param name="numberOfTerms">Number of terms to generate.</param>
        /// <param name="maxValue">Max value for a single term.</param>
        /// <param name="expectedOutput">The answer</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(34, 4000000,4613732)]
        [DataRow(10, 4000000, 44)]
        [DataRow(20, 4000000, 3382)]
        [DataRow(100, 4000000, 4613732)]
        [DataRow(100, 1000, 798)]
        [DataRow(100, 10, 10)]
        [DataRow(100, 1, 0)]
        [DataRow(10, 34, 44)]
        [DataRow(0, 4000000, 0)]
        [DataRow(-5, 4000000, -1)]
        public void TestFibonacci_GetEvenFibSumRedux(int numberOfTerms, int maxValue, int expectedOutput)
        {
            var fib = new Fibonacci();
            var fibSum = fib.GetEvenFibSumRedux(numberOfTerms, maxValue);

            Assert.AreEqual(expectedOutput, fibSum);
        }
    }
}
