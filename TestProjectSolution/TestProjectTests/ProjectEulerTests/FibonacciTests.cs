// <copyright file="FibonacciTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="Fibonacci"/> class.
    /// </summary>
    [TestClass]
    public class FibonacciTests
    {
        /// <summary>
        /// Tests the <see cref="Fibonacci.GetFibonacciNumbers(int)"/> method with various inputs.
        /// </summary>
        /// <param name="n">The number of terms to get.</param>
        /// <param name="expected">Expected value.</param>
        [DataTestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, "0,1,1,2,3,5,8,13,21,34")]
        public void TestFibonacci_GetFibonacciNumbers(int n, string expected)
        {
            var fibList = Fibonacci.GetFibonacciNumbers(n);
            var expectedList = expected.Split(',').Select(BigInteger.Parse).ToList();
            CollectionAssert.AreEqual(expectedList, fibList);
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetEvenFibSum(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestFibonacci_GetEvenFibSum()
        {
            var fibSum = Fibonacci.GetEvenFibSum(34);

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
        [DataRow(34, 4000000, 4613732)]
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
            var fibSum = Fibonacci.GetEvenFibSumRedux(numberOfTerms, maxValue);

            Assert.AreEqual(expectedOutput, fibSum);
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetNthFib(int)"/> method.
        /// </summary>
        /// <param name="n">The term of the sequence we want.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1, "1")]
        [DataRow(2, "1")]
        [DataRow(3, "2")]
        [DataRow(4, "3")]
        [DataRow(12, "144")]
        [DataRow(100, "354224848179261915075")]
        [DataRow(1000, "43466557686937456435688527675040625802564660517371780402481729089536555417949051890403879840079255169295922593080322634775209689623239873322471161642996440906533187938298969649928516003704476137795166849228875")]
        public void TestFibonacci_GetNthFib(int n, string expected)
        {
            var result = Fibonacci.GetNthFib(n);
            var expectedInt = BigInteger.Parse(expected);
            Assert.AreEqual(expectedInt, result);
        }

        /// <summary>
        /// Tests the <see cref="Fibonacci.GetFirstFibsWithNDigits(int)"/> method.
        /// </summary>
        /// <param name="n">The number of digits we want in the term.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(3, 12)]
        public void TestFibonacci_GetFirstFibsWithNDigits(int n, int expected)
        {
            var result = Fibonacci.GetFirstFibsWithNDigits(n);
            Assert.AreEqual(expected, result);
        }
    }
}
