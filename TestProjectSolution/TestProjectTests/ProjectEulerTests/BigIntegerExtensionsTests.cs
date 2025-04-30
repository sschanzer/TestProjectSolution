using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerProblems.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectTests.ProjectEulerTests
{
    /// <summary>
    /// Tests for the <see cref=""/> class.
    /// </summary>
    [TestClass]
    public class BigIntegerExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="BigIntegerExtensions.IntegerSqrt(BigInteger)"/> method.
        /// </summary>
        /// <param name="num">String representation of the test number.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("100000000000000000000000000000000", "10000000000000000")]                 // sqrt(1e32)
        [DataRow("123456789123456789123456789", "11111111066111")]                          // ~sqrt(1.5e26)
        [DataRow("9999999999999999999999999999999999", "99999999999999999")]                // sqrt(1e34 - 1)
        [DataRow("18446744073709551615", "4294967295")]                                     // sqrt(ulong.MaxValue)
        [DataRow("1000000000000000000000000000000000000", "1000000000000000000")]           // sqrt(1e36)
        [DataRow("9223372036854775808", "3037000499")]                                      // sqrt(long.MaxValue + 1)
        [DataRow("340282366920938463463374607431768211455", "18446744073709551615")]        // sqrt(2^128 - 1)
        public void TestBigIntegerExtensions_IntegerSqrt(string num, string expected)
        {
            var number = BigInteger.Parse(num);

            var result = BigIntegerExtensions.IntegerSqrt(number);

            Assert.AreEqual(BigInteger.Parse(expected), result);
        }

        /// <summary>
        /// Tests the <see cref="BigIntegerExtensions.IntegerRoot(BigInteger, int)"/> method.
        /// </summary>
        /// <param name="num">String representation of the test number.</param>
        /// <param name="expected">The expected output.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow("1", 2, "1")]
        [DataRow("64", 3, "4")]
        [DataRow("81", 4, "3")]
        [DataRow("1000000000000000000", 2, "1000000000")]
        [DataRow("1000000000000000000000000000000000", 3, "100000000000")]
        [DataRow("18446744073709551616", 2, "4294967296")]
        [DataRow("340282366920938463463374607431768211456", 4, "4294967296")]
        [DataRow("9999999999999999999999999999999999", 2, "99999999999999999")]
        [DataRow("100000000000000000000000000000000000000", 5, "39810717")]

        public void TestBigIntegerExtensions_IntegerRoot(string num, int exp, string expected)
        {
            var number = BigInteger.Parse(num);

            var result = BigIntegerExtensions.IntegerRoot(number, exp);

            Assert.AreEqual(BigInteger.Parse(expected), result);
        }
    }
}
