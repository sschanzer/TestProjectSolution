namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Test for <see cref="Permutations"/> class.
    /// </summary>
    [TestClass]
    public class PermutationsTests
    {
        /// <summary>
        /// Tests the <see cref="Permutations.GetLexicographicPermutations(string, int)"/> method.
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
            var permutation = Permutations.GetLexicographicPermutations(numString, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(answer, result);
        }

        /// <summary>
        /// Tests the <see cref="Permutations.PermutationsViaHeaps(string, int)"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="num">Element we want.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("201", 3, 102)]
        [DataRow("0123456789", 1000000, 2783915460)]
        public void TestLexicographicPermutations_PermutationsViaHeaps(string input, int num, long expected)
        {
            var permutation = Permutations.PermutationsViaHeaps(input, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Permutations.GetNthPermutation(string, int)"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="num">Element we want.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("201", 3, 102)]
        [DataRow("0123456789", 1000000, 2783915460)]
        public void TestLexicographicPermutations_GetNthPermutation(string input, int num, long expected)
        {
            var permutation = Permutations.GetNthPermutation(input, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Permutations.GetPermutations(string, string, System.Collections.Generic.List{string})"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("201", 6)]
        [DataRow("abc2", 24)]
        public void TestLexicographicPermutations_GetPermutations(string input, long expected)
        {
            var permutations = new List<string>();
            Permutations.GetPermutations(input, string.Empty, permutations);
            Assert.AreEqual(expected, permutations.Count);
        }
    }
}
