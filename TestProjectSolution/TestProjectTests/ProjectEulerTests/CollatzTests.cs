using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Problems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="Collatz"/> class.
	/// </summary>
	[TestClass]
	public class CollatzTests
	{
        /// <summary>
        /// Tests the <see cref="Collatz.FindLongesCollatzSequence(int)"/> method.
        /// </summary>
        /// <param name="bound">The given bound to check the sequence up to.</param>
        /// <param name="expectedKey">The expected key of the returned dictionary.</param>
        /// <param name="expectedValue">The expected value of the returned dictionary.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
		//[DataRow(5, 3, 7)]
		[DataRow(6, 6, 8)]
		public void TestCollatz_FindLongesCollatzSequence(int bound, int expectedKey, int expectedValue)
		{
			var result = Collatz.FindLongesCollatzSequence(bound);
			var kvp = result.First();

			Assert.AreEqual(expectedKey, kvp.Key);
			Assert.AreEqual(expectedValue, kvp.Value);
        }
    }
}
