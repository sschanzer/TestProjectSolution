using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="MultiplesOf3And5"/> class.
	/// </summary>
	[TestClass]
	public class MultiplesOf3And5Tests
	{
		/// <summary>
		/// Tests the <see cref="MultiplesOf3And5.GetSumDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumDumb_Test1()
		{
			var getMultiples = new MultiplesOf3And5();
            const int num = 10;
			const int ExpectedResult = 23;

			var result = getMultiples.GetSumDumb(num);
			Assert.AreEqual(ExpectedResult, result);
		}

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumDumb_Test2()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumDumb_Test3()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="MultiplesOf3And5.GetSumStillDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumStillDumb_Test1()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumStillDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumStillDumb_Test2()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumStillDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumStillDumb_Test3()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="MultiplesOf3And5.GetSumAnotherDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumAnotherDumb_Test1()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumAnotherDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumAnotherDumb_Test2()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumAnotherDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumAnotherDumb_Test3()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="MultiplesOf3And5.GetSumSlick(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumSlick_Test1()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumSlick(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumSlick_Test2()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="MultiplesOf3And5.GetSumSlick(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void TestMultiplesOf3And5_GetSumSlick_Test3()
        {
            var getMultiples = new MultiplesOf3And5();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }
    }
}
