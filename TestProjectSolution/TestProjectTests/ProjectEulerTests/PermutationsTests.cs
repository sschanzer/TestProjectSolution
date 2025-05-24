namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
        public void TestPermutations_GetLexicographicPermutations(string numString, int num, long answer)
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
        public void TestPermutations_PermutationsViaHeaps(string input, int num, long expected)
        {
            var permutation = Permutations.PermutationsViaHeaps(input, num);
            var result = long.Parse(permutation[0]);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Tests the <see cref="Permutations.PermutationsViaHeaps(string, int)"/>.
        /// </summary>
        /// <param name="filePath">File path to permutation test case csv.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DeploymentItem(@"ProjectEulerTests\TestData\PermutationTestCases.csv")]
        [DataRow("PermutationTestCases.csv")]
        public void TestPermutations_PermutationsViaHeaps_PermutationsCheck(string filePath)
        {
            var testCase = LoadPermutationCSV(filePath);

            foreach (var test in testCase)
            {
                var result = Permutations.PermutationsViaHeaps(test.Input);
                CollectionAssert.AreEqual(test.Expected, result);
            }
        }

        /// <summary>
        /// Tests the <see cref="Permutations.GetPermutations(string, string, List{string})"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("201", new int[] { 012, 021, 102, 120, 201, 210 })]
        public void TestPermutations_GetPermutations_PermutationsCheck(string input, int[] expected)
        {
            var permutations = new List<string>();
            Permutations.GetPermutations(input, string.Empty, permutations);
            CollectionAssert.AreEqual(expected, permutations);
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
        public void TestPermutations_GetNthPermutation(string input, int num, long expected)
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
        public void TestPermutations_GetPermutations(string input, long expected)
        {
            var permutations = new List<string>();
            Permutations.GetPermutations(input, string.Empty, permutations);
            Assert.AreEqual(expected, permutations.Count);
        }

        private static List<(string Input, List<string> Expected)> LoadPermutationCSV(string filePath)
        {
            var lines = File.ReadAllLines(filePath).Skip(1);

            var testCases = new List<(string input, List<string> expected)>();

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                var input = parts[0];
                var expectedRaw = parts.Length > 1 ? parts[1] : string.Empty;
                var expected = expectedRaw.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                testCases.Add((input, expected));
            }

            return testCases;

        }
    }
}
