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
    }
}
