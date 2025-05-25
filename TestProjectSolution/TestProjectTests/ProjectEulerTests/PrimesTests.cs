// <copyright file="PrimesTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System.Linq;
    using System.Numerics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="Primes"/> class.
    /// </summary>
    [TestClass]
    public class PrimesTests
    {
        /// <summary>
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes 1-10, 1-20.
        /// </summary>
        /// <param name="num">Number.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, new int[] { 2, 3, 5, 7 })]
        [DataRow(100, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 })]
        public void TestPrimes_PrimeSieve(int num, int[] expected)
        {
            var primesList = Primes.PrimeSieve(num);

            CollectionAssert.AreEqual(expected.ToList(), primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes 1-100, 1-1000.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="count">The count.</param>
        /// <param name="includes">A prime we'd expect to see in the output.</param>
        /// <param name="doesNotInclude">A number we expect to be absent from the outpue.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1000, 168, 997, 1000)]
        [DataRow(10000, 1229, 9973, 10000)]
        public void TestPrimes_PrimeSieveLarge(int bound, int count, int includes, int doesNotInclude)
        {
            var primesList = Primes.PrimeSieve(bound);

            Assert.AreEqual(count, primesList.Count);
            Assert.IsTrue(primesList.Contains(includes));
            Assert.IsFalse(primesList.Contains(doesNotInclude));
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetPrimesBrute(int)"/> method for primes 1-10, 1-20.
        /// </summary>
        /// <param name="num">Number to go to.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, new int[] { 2, 3, 5, 7 })]
        [DataRow(100, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 })]
        public void TestPrimes_GetPrimesBrute(int num, int[] expected)
        {
            var primesList = Primes.GetPrimesBrute(num);

            CollectionAssert.AreEqual(expected.ToList(), primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 100.
        /// </summary>
        /// <param name="bound">The bound.</param>
        /// <param name="count">The count.</param>
        /// <param name="includes">A prime we'd expect to see in the output.</param>
        /// <param name="doesNotInclude">A number we expect to be absent from the outpue.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1000, 168, 997, 1000)]
        [DataRow(10000, 1229, 9973, 10000)]
        public void TestPrimes_GetPrimesBruteLarge(int bound, int count, int includes, int doesNotInclude)
        {
            var primesList = Primes.GetPrimesBrute(bound);

            Assert.AreEqual(count, primesList.Count);
            Assert.IsTrue(primesList.Contains(includes));
            Assert.IsFalse(primesList.Contains(doesNotInclude));
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetLargestPrimeFactors(long)"/> of 600851475143.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetLargestPrimeFactors_For_Problem3ProjectEuler()
        {
            var largestFactor = Primes.GetLargestPrimeFactors(600851475143);

            Assert.AreEqual(6857, largestFactor);
        }

        /// <summary>
        /// Tests the <see cref="Primes.IsPrime(long)"/> method with a variety of inputs.
        /// </summary>
        /// <param name="num">Test input.</param>
        /// <param name="expectedValue">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(2, true)]
        [DataRow(3, true)]
        [DataRow(4, false)]
        [DataRow(7, true)]
        [DataRow(9, false)]
        [DataRow(29, true)]
        [DataRow(1234, false)]
        [DataRow(600851475143, false)]
        [DataRow(982451653, true)]
        [DataRow(1, false)]
        [DataRow(0, false)]
        [DataRow(-7, false)]
        [DataRow(1000066600001, false)]
        ////[DataRow(1000000000000066600000000000001, false)]                 // Belphegor's prime is too large for the current implementation :(
        public void TestPrimes_IsPrime(long num, bool expectedValue)
        {
            Assert.AreEqual(expectedValue, Primes.IsPrime(num));
        }

        /// <summary>
        /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        /// Find the 10001st prime number.
        /// </summary>
        /// <param name="bound">The position (index) of the prime number to find (e.g., 6 for the 6th prime).</param>
        /// <param name="expectedValue">The expected prime number at the given position (e.g., 13 for the 6th prime).</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(6, 13)]
        [DataRow(10001, 104743)]
        public void TestPrimes_ProjectEulerProblemSeven(int bound, int expectedValue)
        {
            var primeList = Primes.PrimeSieveForNumberOfPrimes(bound);

            Assert.AreEqual(expectedValue, primeList.Last());
        }

        /// <summary>
        /// Tests the <see cref="Primes.SumOfPrimes(int)"/> method.
        /// </summary>
        /// <param name="bound">Where we want the sum to stop.</param>
        /// <param name="expectedSumString">The expected output as a string since Data Rows don't how to convert an int to a BigInteger.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(2, "2")]
        [DataRow(3, "5")]
        [DataRow(5, "10")]
        [DataRow(10, "17")]
        [DataRow(500, "21536")]
        [DataRow(1000, "76127")]
        [DataRow(5000, "1548136")]
        [DataRow(10000, "5736396")]
        [DataRow(50000, "121013308")]
        [DataRow(100000, "454396537")]
        [DataRow(2000000, "142913828922")]
        public void TestPrimes_SumOfPrimes(int bound, string expectedSumString)
        {
            var expectedSum = BigInteger.Parse(expectedSumString);
            var mySum = Primes.SumOfPrimes(bound);
            Assert.AreEqual(expectedSum, mySum);
        }

        /// <summary>
        /// Tests the <see cref="Primes.ProductOfQuadradicCoefficientsProducingMaximalConsecutivePrimes(int)"/> method.
        /// </summary>
        /// <param name="bound">Bound for the first order and constant coefficients.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(41, -41)]
        [DataRow(1000, -59231)]
        public void TestPrimes_ProductOfQuadradicCoefficientsProducingMaximalConsecutivePrimes(int bound, int expected)
        {
            var (a, b) = Primes.ProductOfQuadradicCoefficientsProducingMaximalConsecutivePrimes(bound);
            var product = a * b;
            Assert.AreEqual(expected, product);
        }
    }
}
