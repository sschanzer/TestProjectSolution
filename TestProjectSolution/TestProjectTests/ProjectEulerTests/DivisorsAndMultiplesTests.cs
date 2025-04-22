using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;
using System;

namespace TestProjectTests.ProjectEulerTests
{
    /// <summary>
    /// Tests for the <see cref="DivisorsAndMultiples"/> class.
    /// </summary>
    [TestClass]
    public class DivisorsAndMultiplesTests
    {
        /// <summary>
        /// Tests the <see cref="DivisorsAndMultiples.Gcd(long, long)"/> method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="expectedValue">Exppected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(32L, 168L, 8L)]
        [DataRow(0L, 5L, 5L)]
        [DataRow(5L, 0L, 5L)]
        [DataRow(0L, 0L, 0L)]
        [DataRow(18L, 24L, 6L)]
        [DataRow(101L, 103L, 1L)]
        [DataRow(54L, 24L, 6L)]
        [DataRow(20L, 100L, 20L)]
        [DataRow(100L, 25L, 25L)]
        [DataRow(270L, 192L, 6L)]
        [DataRow(7L, 13L, 1L)]
        [DataRow(-48L, 18L, 6L)]
        [DataRow(48L, -18L, 6L)]
        [DataRow(-48L, -18L, 6L)]
        public void TestDivisorsAndMultiples_Gcd(long a, long b, long expectedValue)
        {
            var result = DivisorsAndMultiples.Gcd(a, b);

            Assert.AreEqual(expectedValue, result);
        }

        /// <summary>
        /// Tests the <see cref="DivisorsAndMultiples.Lcm(long, long)"/> method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="expectedValue">Exppected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(0L, 5L, 0L)]
        [DataRow(5L, 0L, 0L)]
        [DataRow(0L, 0L, 0L)]
        [DataRow(4L, 6L, 12L)]
        [DataRow(21L, 6L, 42L)]
        [DataRow(8L, 9L, 72L)]
        [DataRow(100L, 25L, 100L)]
        [DataRow(25L, 100L, 100L)]
        [DataRow(-4L, 6L, 12L)]
        [DataRow(4L, -6L, 12L)]
        [DataRow(-4L, -6L, 12L)]
        [DataRow(1L, 1L, 1L)]
        [DataRow(13L, 17L, 221L)]
        [DataRow(20L, 30L, 60L)]
        [DataRow(270L, 192L, 8640L)]
        public void TestDivisorsAndMultiples_Lcm(long a, long b, long expectedValue)
        {
            var result = DivisorsAndMultiples.Lcm(a, b);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
