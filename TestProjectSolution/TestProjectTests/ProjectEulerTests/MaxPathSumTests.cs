// <copyright file="MaxPathSumTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests the <see cref="MaxPathSum"/> class.
    /// </summary>
    [TestClass]
    public class MaxPathSumTests
    {
        /// <summary>
        /// Tests the <see cref="MaxPathSum.FindMaxPathSum_BottomUp(string)"/> method.
        /// </summary>
        /// <param name="inputFile">The triagular array we input.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DeploymentItem(@"ProjectEulerTests\TestData\ProjectEulerProblemEighteen.txt")]
        [DeploymentItem(@"ProjectEulerTests\TestData\PEP18Case1.txt")]
        [DataRow("ProjectEulerProblemEighteen.txt", 1074)]
        [DataRow("PEP18Case1.txt", 23)]
        public void TestMaxPathSum_FindMaxPathSum_BottomUp(string inputFile, int expected)
        {
            var result = MaxPathSum.FindMaxPathSum_BottomUp(inputFile);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="MaxPathSum.FindMaxPathSum_TopDown(string)"/> method.
        /// </summary>
        /// <param name="inputFile">The triagular array we input.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DeploymentItem(@"ProjectEulerTests\TestData\ProjectEulerProblemEighteen.txt")]
        [DeploymentItem(@"ProjectEulerTests\TestData\PEP18Case1.txt")]
        [DataRow("ProjectEulerProblemEighteen.txt", 1074)]
        [DataRow("PEP18Case1.txt", 23)]
        public void TestMaxPathSum_FindMaxPathSum_TopDown(string inputFile, int expected)
        {
            var result = MaxPathSum.FindMaxPathSum_TopDown(inputFile);
            Assert.AreEqual(expected, result);
        }
    }
}
