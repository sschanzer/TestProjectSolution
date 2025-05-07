// <copyright file="TwoSumTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestProjectTests.LeetCodeTests
{
    using System.Linq;
    using LeetCodeProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void TestTwoSum_TwoSum1_Test1()
        {
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            const int Target = 9;
            var expectedSolution = new int[] { 0, 1 };

            var result = twoSum.TwoSum1(nums, Target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum1(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TwoSum_TwoSum1_Test2()
        {
            var twoSum = new TwoSum();
            int[] nums = { 3, 2, 4 };
            const int Target = 6;
            var expectedSolution = new int[] { 1, 2 };

            var result = twoSum.TwoSum1(nums, Target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum1(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TwoSum_TwoSum1_Test3()
        {
            var twoSum = new TwoSum();
            int[] nums = { 3, 3 };
            const int Target = 6;
            var expectedSolution = new int[] { 0, 1 };

            var result = twoSum.TwoSum1(nums, Target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum1(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TwoSum_TwoSum1_Test4()
        {
            var twoSum = new TwoSum();
            int[] nums = { 2, 5, 5, 11 };
            const int Target = 10;
            var expectedSolution = new int[] { 1, 2 };

            var result = twoSum.TwoSum1(nums, Target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum2(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestTwoSum_TwoSum2_Test1()
        {
            var twoSum = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            const int Target = 9;
            var expectedSolution = new int[] { 0, 1 };

            var result = twoSum.TwoSum2(nums, Target);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum2(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestTwoSum_TwoSum2_Test2()
        {
            var twoSum = new TwoSum();
            int[] nums = { 3, 2, 4 };
            const int Target = 6;
            var expectedSolution = new int[] { 1, 2 };

            var result = twoSum.TwoSum2(nums, Target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum2(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestTwoSum_TwoSum2_Test3()
        {
            var twoSum = new TwoSum();
            int[] nums = { 3, 3 };
            const int Target = 6;
            var expectedSolution = new int[] { 0, 1 };

            var result = twoSum.TwoSum2(nums, Target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }

        /// <summary>
        /// Tests the <see cref="TwoSum.TwoSum2(int[], int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestTwoSum_TwoSum2_Test4()
        {
            var twoSum = new TwoSum();
            int[] nums = { 2, 5, 5, 11 };
            const int Target = 10;
            var expectedSolution = new int[] { 1, 2 };

            var result = twoSum.TwoSum2(nums, Target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.IsTrue(expectedSolution.SequenceEqual(result));
        }
    }
}
