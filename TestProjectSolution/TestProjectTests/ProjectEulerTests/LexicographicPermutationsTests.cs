namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Test for <see cref="LexicographicPermutations"/> class.
    /// </summary>
    [TestClass]
    public class LexicographicPermutationsTests
    {
        /// <summary>
        /// Tests the <see cref="LexicographicPermutations.GetLexicographicPermutations(string)"/> method.
        /// </summary>
        /// <param name="numString">The number as a string.</param>
        /// <param name="num">Element of permutation we want.</param>
        /// <param name="answer">The expected answer.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("201", 3, 102)]
        [DataRow("0123456789", 1000000, 2783915460)]
        public void TestLexicographicPermutations_GetLexicographicPermutations(string numString, int num, long answer)
        {
            var permutation = LexicographicPermutations.GetLexicographicPermutations(numString, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(answer, result);
        }
    }
}
