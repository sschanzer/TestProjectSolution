// <copyright file="PrimesTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
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
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes up to 10.
        /// </summary>
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
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes up to 1000.
        /// </summary>
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
		/// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 10.
		/// </summary>
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
        /// Tests the <see cref="Primes.GetFactors(long)"/> method for various inputs.
        /// </summary>
        [DataTestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(10, new long[] { 1, 2, 5, 10 })]
        [DataRow(12, new long[] { 1, 2, 3, 4, 6, 12 })]
        [DataRow(7, new long[] { 1, 7 })]
        [DataRow(1, new long[] { 1 })]
        [DataRow(0, new long[] { })]
        public void TestPrimes_GetFactors_VariousInputs(long number, long[] expected)
        {
            var result = Primes.GetFactors(number);
            CollectionAssert.AreEqual(expected.ToList(), result);
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
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(2, true)]                                                // Smallest prime number
        [DataRow(3, true)]                                                // Small prime number
        [DataRow(4, false)]                                               // First composite number
        [DataRow(7, true)]                                                // Prime number
        [DataRow(9, false)]                                               // Odd composite number
        [DataRow(29, true)]                                               // Larger prime number
        [DataRow(1234, false)]                                            // Even non-prime
        [DataRow(600851475143, false)]                                    // Large non-prime (used in Euler Problem 3)
        [DataRow(982451653, true)]                                        // Large prime number
        [DataRow(1, false)]                                               // Not prime
        [DataRow(0, false)]                                               // Not prime
        [DataRow(-7, false)]                                              // Negative number, not prime
        [DataRow(1000066600001, false)]                                   // Large non-prime
        //[DataRow(1000000000000066600000000000001, false)]                 // Belphegor's prime is too large for the current implementation :(
        public void TestPrimes_IsPrime(long num, bool expectedValue)
        {
            Assert.AreEqual(expectedValue, Primes.IsPrime(num));
        }

        /// <summary>
        /// By listing the first six prime numbers: $2, 3, 5, 7, 11$, and $13$, we can see that the $6$th prime is $13$.
        /// What is the $10001$st prime number?
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
    }
}
