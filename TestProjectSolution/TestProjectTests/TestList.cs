using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectTests
{
    /// <summary>
    /// Defines the possible test lists the tests could belong to.
    /// </summary>
    internal struct TestList
    {
        /// <summary>
        /// Benchmark tests.
        /// </summary>
        public const string Benchmark = "Benchmark";

        /// <summary>
        /// Feedback Tests.
        /// </summary>
        public const string Feedback = "Feedback";

        /// <summary>
        /// Validation Tests.
        /// </summary>
        public const string Validation = "Validation";

        /// <summary>
        /// Contain the Project Euler problems.
        /// </summary>
        public const string ProjectEulerTests = "ProjectEulerTests";
    }
}
