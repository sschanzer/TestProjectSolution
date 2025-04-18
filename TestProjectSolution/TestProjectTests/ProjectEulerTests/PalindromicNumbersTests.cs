using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="PalindromicNumbers"/> class.
	/// </summary>
	[TestClass]
	public class PalindromicNumbersTests
	{
		/// <summary>
		/// Tests the <see cref="PalindromicNumbers.IsPalindrome(long)"/> method.
		/// </summary>
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
			var palindrome = new PalindromicNumbers();
			var isPalindrome = palindrome.IsPalindrome(number);

			Assert.AreEqual(expectedValue, isPalindrome);
		}

        /// <summary>
        /// Tests the <see cref="PalindromicNumbers.GetLargestPalindromeProduct(int)"/> method for 2-digit numbers.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPalindromicNumbers_GetLargestPalindromeProduct_TwoDigitNumbers()
        {
            var palindromicNumbers = new PalindromicNumbers();
            long result = palindromicNumbers.GetLargestPalindromeProduct(2);
            Assert.AreEqual(9009, result);
        }

        /// <summary>
        /// Tests the <see cref="PalindromicNumbers.GetLargestPalindromeProduct(int)"/> method for 3-digit numbers.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPalindromicNumbers_GetLargestPalindromeProduct_ThreeDigitNumbers()
        {
            var palindromicNumbers = new PalindromicNumbers();
            long result = palindromicNumbers.GetLargestPalindromeProduct(3);
            Assert.AreEqual(906609, result);
        }

        /// <summary>
        /// Tests the <see cref="PalindromicNumbers.GetLargestPalindromeProduct(int)"/> method when the digit count is 1.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestPalindromicNumbers_GetLargestPalindromeProduct_SingleDigit()
        {
            var palindromicNumbers = new PalindromicNumbers();
            long result = palindromicNumbers.GetLargestPalindromeProduct(1);
            Assert.AreEqual(9, result);
        }
    }
}
