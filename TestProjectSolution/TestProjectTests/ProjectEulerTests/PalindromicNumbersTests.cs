// <copyright file="PalindromicNumbersTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="PalindromicNumbers"/> class.
    /// </summary>
    [TestClass]
    public class PalindromicNumbersTests
    {
        /// <summary>
        /// Tests the <see cref="PalindromicNumbers.IsPalindrome(long)"/> method.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="expectedValue">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1001, true)]
        [DataRow(9223372036854775807, false)]
        [DataRow(999999999999999999, true)]
        [DataRow(10000066600001, false)]
        [DataRow(1000066600001, true)]
        [DataRow(1234, false)]
        [DataRow(7, true)]
        public void TestPalindromicNumbers_IsPalindrome(long number, bool expectedValue)
        {
            var isPalindrome = PalindromicNumbers.IsPalindrome(number);

            Assert.AreEqual(expectedValue, isPalindrome);
        }

        /// <summary>
        /// Tests the <see cref="PalindromicNumbers.GetLargestPalindromeProduct(int)"/> method
        /// for various digit counts using data-driven test cases.
        /// </summary>
        /// /// <param name="digits">The digits.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(1, 9)]
        [DataRow(2, 9009)]
        [DataRow(3, 906609)]
        public void TestPalindromicNumbers_GetLargestPalindromeProduct(int digits, long expected)
        {
            long result = PalindromicNumbers.GetLargestPalindromeProduct(digits);
            Assert.AreEqual(expected, result);
        }
    }
}
