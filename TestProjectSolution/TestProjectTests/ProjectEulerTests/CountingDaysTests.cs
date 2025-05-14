// <copyright file="CountingDaysTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;

    /// <summary>
    /// Tests for the <see cref="CountingDays"/> class.
    /// </summary>
    [TestClass]
    public class CountingDaysTests
    {
        /// <summary>
        /// Tests the <see cref="CountingDays.CountNumberOfDays(string, int, string)"/> method.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week.</param>
        /// <param name="dayOfMonth">Day of the month we want the day of the week to fall on.</param>
        /// <param name="dateRange">The range of dates we're interested in.</param>
        /// <param name="expectedOutput">The expected result.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("Sunday", 1, "1 Jan 1901 to 31 Dec 2000", 171)]
        [DataRow("Monday", 15, "1 Jan 2000 to 31 Dec 2020", 34)]
        [DataRow("Friday", 13, "1 Jan 1990 to 31 Dec 2000", 18)]
        [DataRow("Wednesday", 1, "1 Jan 2020 to 31 Dec 2023", 9)]
        [DataRow("Saturday", 31, "1 Jan 2000 to 31 Dec 2020", 21)]
        [DataRow("Tuesday", 29, "1 Jan 2000 to 31 Dec 2020", 35)]
        [DataRow("Monday", 1, "1 Jan 1900 to 31 Dec 1900", 2)]
        [DataRow("Thursday", 15, "1 Jan 2100 to 31 Dec 2100", 2)]
        [DataRow("Saturday", 1, "1 Jan 2000 to 1 Jan 2000", 1)]
        [DataRow("Sunday", 2, "1 Jan 2000 to 1 Jan 2000", 0)]
        public void TestCountingDays_CountNumberOfDays(string dayOfWeek, int dayOfMonth, string dateRange, int expectedOutput)
        {
            var result = CountingDays.CountNumberOfDays(dayOfWeek, dayOfMonth, dateRange);
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
