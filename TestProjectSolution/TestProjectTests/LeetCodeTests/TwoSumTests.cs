using System;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectTests.LeetCodeTests
{
	/// <summary>
	/// Tests for the <see cref="TwoSum"/> class.
	/// </summary>
	[TestClass]
	public class TwoSumTests
	{
		/// <summary>
		/// Tests the <see cref="TwoSum.TwoSum1(int[], int)"/> method.
		/// </summary>
		[TestMethod]
		[TestCategory(TestList.Validation)]
		public void TestTwoSum_TwoSum1()
		{
			var twoSum = new TwoSum();
			int[] nums = { 2, 7, 11, 15 };
			int target = 9;

			var result = twoSum.TwoSum1(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum1(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestTwoSum_TwoSum2()
        {
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            var result = twoSum.TwoSum2(nums, target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}
