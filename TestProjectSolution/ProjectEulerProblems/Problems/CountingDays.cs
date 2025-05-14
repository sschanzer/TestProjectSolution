// <copyright file="CountingDays.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A class containing methods related to counting time and dates.
    /// </summary>
    public static class CountingDays
    {
        /// <summary>
        /// Counts the number of times a specified day of the week falls on a certain date.
        /// </summary>
        /// <param name="dayOfWeek">Day of the week.</param>
        /// <param name="dayOfMonth">Day of the month we want the day of the week to fall on.</param>
        /// <param name="dateRange">The range of dates we're interested in.</param>
        /// <returns>The number of times the day of the week falls on the day of the month in the given date range.</returns>
        public static int CountNumberOfDays(string dayOfWeek, int dayOfMonth, string dateRange)
        {
            var dateRangeList = dateRange.Split(new string[] { "to" }, StringSplitOptions.None);
            var startDate = DateTime.Parse(dateRangeList[0]);
            var endDate = DateTime.Parse(dateRangeList[1]);
            var count = 0;

            // Check each year
            for (int year = startDate.Year; year <= endDate.Year; year++)
            {
                // Check each month
                for (int month = 1; month <= 12; month++)
                {
                    if (DateTime.DaysInMonth(year, month) < dayOfMonth)
                    {
                        continue;
                    }

                    var date = new DateTime(year, month, dayOfMonth);

                    if (date < startDate || date > endDate)
                    {
                        continue;
                    }

                    if (date.DayOfWeek.ToString() == dayOfWeek)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
