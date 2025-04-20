using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
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
        public void TestPrimes_PrimeSieveToTen()
		{
			var primes = new Primes();
			var primesList = primes.PrimeSieve(10);
            var expected = new List<int> { 2, 3, 5, 7 };

            CollectionAssert.AreEqual(expected, primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes up to 100.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_PrimeSieveToOneHundred()
        {
            var primes = new Primes();
            var primesList = primes.PrimeSieve(100);
            var expected = new List<int>
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97
            };

            CollectionAssert.AreEqual(expected, primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes up to 1000.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_PrimeSieveToOneThousand()
        {
            var primes = new Primes();
            var primesList = primes.PrimeSieve(1000);

            Assert.AreEqual(168, primesList.Count);
            Assert.IsTrue(primesList.Contains(997));
            Assert.IsFalse(primesList.Contains(1000));
        }

        /// <summary>
        /// Tests the <see cref="Primes.PrimeSieve"/> method for primes up to 1000.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_PrimeSieveToTenThousand()
        {
            var primes = new Primes();
            var primesList = primes.PrimeSieve(10000);

            Assert.AreEqual(1229, primesList.Count);
            Assert.IsTrue(primesList.Contains(9973));
            Assert.IsFalse(primesList.Contains(10000));
        }

        /// <summary>
		/// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 10.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetPrimesBruteToTen()
        {
            var primes = new Primes();
            var primesList = primes.GetPrimesBrute(10);
            var expected = new List<int> { 2, 3, 5, 7 };

            CollectionAssert.AreEqual(expected, primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 100.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetPrimesBruteToOneHundred()
        {
            var primes = new Primes();
            var primesList = primes.GetPrimesBrute(100);
            var expected = new List<int>
            {
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97
            };

            CollectionAssert.AreEqual(expected, primesList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 1000.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetPrimesBruteToOneThousand()
        {
            var primes = new Primes();
            var primesList = primes.GetPrimesBrute(1000);

            Assert.AreEqual(168, primesList.Count);
            Assert.IsTrue(primesList.Contains(997));
            Assert.IsFalse(primesList.Contains(1000));
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetPrimesBrute"/> method for primes up to 1000.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetPrimesBruteToTenThousand()
        {
            var primes = new Primes();
            var primesList = primes.GetPrimesBrute(10000);

            Assert.AreEqual(1229, primesList.Count);
            Assert.IsTrue(primesList.Contains(9973));
            Assert.IsFalse(primesList.Contains(10000));
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetFactors(long)"/> of 10.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetFactorsToTen()
        {
            var primes = new Primes();
            var factorList = primes.GetFactors(10);
            var expected = new List<long>() { 1, 2, 5, 10 };

            CollectionAssert.AreEqual(expected, factorList);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetFactors(long)"/> of 12.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetFactors_PositiveNumber_ReturnsAllFactors()
        {
            var primes = new Primes();
            var result = primes.GetFactors(12);
            var expected = new List<long> { 1, 2, 3, 4, 6, 12 };
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetFactors(long)"/> of 7.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetFactors_PrimeNumber_ReturnsOneAndItself()
        {
            var primes = new Primes();
            var result = primes.GetFactors(7);
            var expected = new List<long> { 1, 7 };
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetFactors(long)"/> of 1.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetFactors_One_ReturnsOnlyOne()
        {
            var primes = new Primes();
            var result = primes.GetFactors(1);
            var expected = new List<long> { 1 };
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetFactors(long)"/> of 0.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetFactors_Zero_ReturnsEmptyList()
        {
            var primes = new Primes();
            var result = primes.GetFactors(0);
            var expected = new List<long>(); // Zero has no proper factors in this implementation
            CollectionAssert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Primes.GetLargestPrimeFactors(long)"/> of 600851475143.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPrimes_GetLargestPrimeFactors_For_Problem3ProjectEuler()
        {
            var primes = new Primes();
            var largestFactor = primes.GetLargestPrimeFactors(600851475143);

            Assert.AreEqual(6857, largestFactor);
        }

        /// <summary>
        /// Tests the <see cref="Primes.IsPrime(long)"/> method with a variety of inputs.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(2, true)]                         // Smallest prime number
        [DataRow(3, true)]                         // Small prime number
        [DataRow(4, false)]                        // First composite number
        [DataRow(7, true)]                         // Prime number
        [DataRow(9, false)]                        // Odd composite number
        [DataRow(29, true)]                        // Larger prime number
        [DataRow(1234, false)]                     // Even non-prime
        [DataRow(600851475143, false)]            // Large non-prime (used in Euler Problem 3)
        [DataRow(982451653, true)]                // Large prime number
        [DataRow(1, false)]                        // Not prime
        [DataRow(0, false)]                        // Not prime
        [DataRow(-7, false)]                       // Negative number, not prime
        [DataRow(1000066600001, false)]             // Large non-prime
        //[DataRow(1000000000000066600000000000001, false)]             // Belphegor's prime is too large for the current implementation :(
        public void TestPrimes_IsPrime(long num, bool expectedValue)
        {
            var primes = new Primes();
            Assert.AreEqual(expectedValue, primes.IsPrime(num));
        }
    }
}
