// <copyright file="DivisorsAndMultiplesTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

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
        [DataRow(32, 168, 8)]
        [DataRow(0, 5, 5)]
        [DataRow(5, 0, 5)]
        [DataRow(0, 0, 0)]
        [DataRow(18, 24, 6)]
        [DataRow(101, 103, 1)]
        [DataRow(54, 24, 6)]
        [DataRow(20, 100, 20)]
        [DataRow(100, 25, 25)]
        [DataRow(270, 192, 6)]
        [DataRow(7, 13, 1)]
        [DataRow(-48, 18, 6)]
        [DataRow(48, -18, 6)]
        [DataRow(-48, -18, 6)]
        public void TestDivisorsAndMultiples_Gcd(long a, long b, long expectedValue)
        {
            var result = DivisorsAndMultiples.Gcd(a, b);

            Assert.AreEqual(expectedValue, result);
        }

        /// <summary>
        /// Tests the <see cref="DivisorsAndMultiples.cm(long, long)"/> method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="expectedValue">Exppected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(0, 5, 0)]
        [DataRow(5, 0, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(4, 6, 12)]
        [DataRow(21, 6, 42)]
        [DataRow(8, 9, 72)]
        [DataRow(100, 25, 100)]
        [DataRow(25, 100, 100)]
        [DataRow(-4, 6, 12)]
        [DataRow(4, -6, 12)]
        [DataRow(-4, -6, 12)]
        [DataRow(1, 1, 1)]
        [DataRow(13, 17, 221)]
        [DataRow(20, 30, 60)]
        [DataRow(270, 192, 8640)]
        public void TestDivisorsAndMultiples_cm(long a, long b, long expectedValue)
        {
            var result = DivisorsAndMultiples.Lcm(a, b);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
