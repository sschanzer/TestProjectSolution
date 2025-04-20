using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems;

namespace TestProjectTests.ProjectEulerTests
{
	/// <summary>
	/// Tests for the <see cref="SumNums"/> class.
	/// </summary>
	[TestClass]
	public class SumNumsTests
	{
		/// <summary>
		/// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumDumb_Test1()
		{
			var getMultiples = new SumNums();
            const int num = 10;
			const int ExpectedResult = 23;

			var result = getMultiples.GetSumMultiplesOfThreeAndFiveDumb(num);
			Assert.AreEqual(ExpectedResult, result);
		}

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumDumb_Test2()
        {
            var getMultiples = new SumNums();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumDumb_Test3()
        {
            var getMultiples = new SumNums();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveStillDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumStillDumb_Test1()
        {
            var getMultiples = new SumNums();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveStillDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumStillDumb_Test2()
        {
            var getMultiples = new SumNums();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveStillDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumStillDumb_Test3()
        {
            var getMultiples = new SumNums();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveStillDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveAnotherDumb(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumAnotherDumb_Test1()
        {
            var getMultiples = new SumNums();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveAnotherDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumAnotherDumb_Test2()
        {
            var getMultiples = new SumNums();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumMultiplesOfThreeAndFiveAnotherDumb(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumAnotherDumb_Test3()
        {
            var getMultiples = new SumNums();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumMultiplesOfThreeAndFiveAnotherDumb(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
		/// Tests the <see cref="SumNums.GetSumSlick(int)"/> method.
		/// </summary>
		[TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumSlick_Test1()
        {
            var getMultiples = new SumNums();
            const int num = 10;
            const int ExpectedResult = 23;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumSlick(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumSlick_Test2()
        {
            var getMultiples = new SumNums();
            const int num = 20;
            const int ExpectedResult = 78;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the <see cref="SumNums.GetSumSlick(int)"/> method.
        /// </summary>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        public void SumNums_GetSumSlick_Test3()
        {
            var getMultiples = new SumNums();
            const int num = 1000;
            const int ExpectedResult = 233168;

            var result = getMultiples.GetSumSlick(num);
            Assert.AreEqual(ExpectedResult, result);
        }
    }
}
