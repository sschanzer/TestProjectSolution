namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="Sequence"/> class.
    /// </summary>
    [TestClass]
    public class SequenceTests
    {
        /// <summary>
        /// Tests the <see cref="Sequence.FindDistinctPowers(int, int)"/> method.
        /// </summary>
        /// <param name="baseBound">Bound of the base.</param>
        /// <param name="expBound">Bound of the exponent.</param>
        /// <param name="expected">Expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(5, 5, 15)]
        [DataRow(100, 100, 9183)]
        public void SequenceTest_FindDistinctPowers(int baseBound, int expBound, int expected)
        {
            var result = Sequence.FindDistinctPowers(baseBound, expBound);
            Assert.AreEqual(expected, result);
        }
    }
}
