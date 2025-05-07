// <copyright file="BigIntegerExtensionsTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Diagnostics;
    using System.Numerics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Utilities;

    /// <summary>
    /// Tests for the <see cref=""/> class.
    /// </summary>
    [TestClass]
    public class BigIntegerExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="BigIntegerExtensions.IntegerSqrt(BigInteger)"/> method.
        /// </summary>
        /// <param name="num">String representation of the test number.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("100000000000000000000000000000000", "10000000000000000")]
        [DataRow("123456789123456789123456789", "11111111066111")]
        [DataRow("9999999999999999999999999999999999", "99999999999999999")]
        [DataRow("18446744073709551615", "4294967295")]
        [DataRow("1000000000000000000000000000000000000", "1000000000000000000")]
        [DataRow("9223372036854775808", "3037000499")]
        [DataRow("340282366920938463463374607431768211455", "18446744073709551615")]
        public void TestBigIntegerExtensions_IntegerSqrt(string num, string expected)
        {
            var number = BigInteger.Parse(num);

            var result = BigIntegerExtensions.IntegerSqrt(number);

            Assert.AreEqual(BigInteger.Parse(expected), result);
        }

        /// <summary>
        /// Tests the <see cref="BigIntegerExtensions.IntegerRoot(BigInteger, int)"/> method.
        /// </summary>
        /// <param name="num">String representation of the test number.</param>
        /// <param name="exp">The expected output.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("1", 2, "1")]
        [DataRow("64", 3, "4")]
        [DataRow("81", 4, "3")]
        [DataRow("1000000000000000000", 2, "1000000000")]
        [DataRow("1000000000000000000000000000000000", 3, "100000000000")]
        [DataRow("18446744073709551616", 2, "4294967296")]
        [DataRow("340282366920938463463374607431768211456", 4, "4294967296")]
        [DataRow("9999999999999999999999999999999999", 2, "99999999999999999")]
        [DataRow("100000000000000000000000000000000000000", 5, "39810717")]

        public void TestBigIntegerExtensions_IntegerRoot(string num, int exp, string expected)
        {
            var number = BigInteger.Parse(num);

            var result = BigIntegerExtensions.IntegerRoot(number, exp);

            Assert.AreEqual(BigInteger.Parse(expected), result);
        }

        /// <summary>
        /// Tests the <see cref="BigIntegerExtensions.Choose(int, int)"/> method.
        /// </summary>
        /// <param name="n">First integer.</param>
        /// <param name="k">Second integer.</param>
        /// <param name="answer">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(30, 15, "155117520")]
        [DataRow(50, 25, "126410606437752")]
        public void TestBigIntegerExtensions_Choose(int n, int k, string answer)
        {
            var result = BigIntegerExtensions.Choose(n, k);
            Assert.AreEqual(BigInteger.Parse(answer), result);
        }

        /// <summary>
        /// Benchmark for the <see cref="BigIntegerExtensions.FactorialLarge(BigInteger)"/> and <see cref="BigIntegerExtensions.Factorial(BigInteger)"/> methods.
        /// </summary>
        /// <param name="inputStr">Given input.</param>
        [TestMethod]
        [TestCategory(TestList.Benchmark)]
        [DataRow("5000")]
        [DataRow("7000")]
        [DataRow("10000")]
        [DataRow("15000")]
        public void TestBigIntegerExtensions_FactorialPerformance(string inputStr)
        {
            var input = BigInteger.Parse(inputStr);

            // Serial computation
            var swSerial = Stopwatch.StartNew();
            var resultSerial = BigIntegerExtensions.Factorial(input);
            swSerial.Stop();
            var timeSerial = swSerial.ElapsedMilliseconds;

            // Parallel computation
            var swParallel = Stopwatch.StartNew();
            var resultParallel = BigIntegerExtensions.FactorialLarge(input);
            swParallel.Stop();
            var timeParallel = swParallel.ElapsedMilliseconds;

            // Ensure both methods yield the same result
            Assert.AreEqual(resultSerial, resultParallel, "Parallel result does not match serial result.");

            if (timeParallel <= timeSerial * 1.05)
            {
                Console.WriteLine($"Parallel was more than 5% slower for {inputStr}. Serial: {timeSerial} ms, Parallel: {timeParallel} ms");
            }
        }
    }
}
