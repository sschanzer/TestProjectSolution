using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Data;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
    /// <summary>
    /// Tests for the <see cref="Products"/> class.
    /// </summary>
	[TestClass]
	public class ProductsTests
	{
        /// <summary>
        /// Gets the number used in Project Euler Problem 8.
        /// </summary>
        private string BigNum
        {
            get
            {
                return ProblemData.ProblemEightNumber;
            }
        }

        /// <summary>
        /// Test the <see cref="Products.FindLargestSubstringProduct_BreakDown(int, string)"/> method.
        /// </summary>
        /// <param name="length">Requested length of the substring.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(4, 5832)]
        [DataRow(13, 23514624000)]
        public void TestProducts_FindLargestSubstringProduct_BreakDown(int length, long answer)
        {
            var maxProduct = Products.FindLargestSubstringProduct_BreakDown(length, BigNum);
            Assert.AreEqual(answer, maxProduct);
        }

        /// <summary>
        /// Test the <see cref="Products.FindLargestSubstringProduct(int, string)"/> method.
        /// </summary>
        /// <param name="length">Requested length of the substring.</param>
        /// <param name="answer">The answer.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(4, 5832)]
        [DataRow(13, 23514624000)]
        public void TestProducts_FindLargestSubstringProduct(int length, long answer)
        {
            var maxProduct = Products.FindLargestSubstringProduct(length, BigNum);
            Assert.AreEqual(answer, maxProduct);
        }
    }
}
