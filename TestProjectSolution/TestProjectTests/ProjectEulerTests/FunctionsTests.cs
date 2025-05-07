// <copyright file="FunctionsTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Utilities;

    /// <summary>
    /// Tests the <see cref="Functions"/> class.
    /// </summary>
    [TestClass]
    public class FunctionsTests
    {
        /// <summary>
        /// Tests the <see cref="Functions.Factorial(int)"/> method.
        /// </summary>
        /// <param name="n">The input.</param>
        /// <param name="answer">The answer</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        [DataRow(6, 720)]
        [DataRow(7, 5040)]
        [DataRow(8, 40320)]
        [DataRow(9, 362880)]
        [DataRow(10, 3628800)]
        [DataRow(12, 479001600)]
        [DataRow(15, 1307674368000)]
        [DataRow(20, 2432902008176640000)]
        public void TestFunctions_Factorial(int n, long answer)
        {
            var result = Functions.Factorial(n);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Tests the <see cref="Functions.Choose(int, int)"/> method.
        /// </summary>
        /// <param name="n">First input.</param>
        /// <param name="k">Second input.</param>
        /// <param name="answer">Expected anser.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(6, 3, 20)]
        [DataRow(5, 2, 10)]
        [DataRow(10, 5, 252)]
        [DataRow(7, 4, 35)]
        [DataRow(8, 4, 70)]
        [DataRow(9, 3, 84)]
        [DataRow(10, 6, 210)]
        [DataRow(11, 2, 55)]
        [DataRow(12, 3, 220)]
        [DataRow(13, 4, 715)]
        [DataRow(15, 5, 3003)]
        [DataRow(20, 10, 184756)]
        public void TestFunctions_Choose(int n, int k, long answer)
        {
            var result = Functions.Choose(n, k);
            Assert.AreEqual(answer, result);
        }
    }
}
