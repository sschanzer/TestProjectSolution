// <copyright file="PythagoreanTests.cs" company="MyTestProject">
// Copyright (c) MyTestProject. All rights reserved.
// </copyright>

namespace TestProjectTests.ProjectEulerTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEulerProblems.Problems;
    using TestProjectTests.ProjectEulerTests.TestData;

    /// <summary>
    /// Tests the <see cref="Pythagorean"/> class.
    /// </summary>
    [TestClass]
    public class PythagoreanTests
    {
        /// <summary>
        /// Tests the <see cref="Pythagorean.IsPythagoreanTriple(int, int, int)"/> method.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <param name="c">Thrid number.</param>
        /// <param name="expectedValue">Answer.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(8, 15, 17, true)]
        [DataRow(7, 24, 25, true)]
        [DataRow(9, 40, 41, true)]
        [DataRow(11, 60, 61, true)]
        [DataRow(20, 21, 29, true)]
        [DataRow(12, 16, 20, true)]
        [DataRow(6, 8, 10, true)]
        [DataRow(1, 2, 3, false)]
        [DataRow(10, 6, 8, true)]
        [DataRow(5, 5, 5, false)]
        [DataRow(0, 0, 0, false)]
        [DataRow(0, 1, 1, false)]
        [DataRow(-3, -4, -5, false)]
        [DataRow(9, 12, 15, true)]
        [DataRow(100, 240, 260, true)]
        [DataRow(33, 56, 65, true)]
        [DataRow(13, 84, 85, true)]
        public void TestPythagorean_IsPythagoreanTriple(int a, int b, int c, bool expectedValue)
        {
            var isTriple = Pythagorean.IsPythagoreanTriple(a, b, c);

            Assert.AreEqual(expectedValue, isTriple);
        }

        /// <summary>
        /// Tests the <see cref="Pythagorean.GeneratePythagoreanTriples(int)"/> method.
        /// </summary>
        /// <param name="bound">Provided bound.</param>
        /// <param name="expectedValue">Expected value.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DynamicData(nameof(PythagoreanTestData.PythagoreanTripleData), typeof(PythagoreanTestData))]
        public void TestPythagorean_GeneratePythagoreanTriples(int bound, List<(int a, int b, int c)> expectedValue)
        {
            var listOfTriples = Pythagorean.GeneratePythagoreanTriples(bound);

            CollectionAssert.AreEqual(expectedValue, listOfTriples);
        }

        /// <summary>
        /// Tests the <see cref="Pythagorean.GeneratePrimitivePythagoreanTriples(int)"/> method.
        /// </summary>
        /// <param name="bound">The provided bound.</param>
        /// <param name="nonPrimitiveTriples">List of Non-primitive Pythagorean triples.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DynamicData(nameof(PythagoreanTestData.PythagoreanTripleData), typeof(PythagoreanTestData))]
        public void TestPythagorean_GeneratePrimitivePythagoreanTriples(int bound, List<(int a, int b, int c)> nonPrimitiveTriples)
        {
            var primitiveTriplesFromTestData = new List<(int a, int b, int c)>();

            // Extract the primitive triples from our list.
            foreach (var triple in nonPrimitiveTriples)
            {
                if (DivisorsAndMultiples.Gcd(triple.a, DivisorsAndMultiples.Gcd(triple.b, triple.c)) == 1)
                {
                    primitiveTriplesFromTestData.Add(triple);
                }
            }

            var primitiveTriples = Pythagorean.GeneratePrimitivePythagoreanTriples(bound);

            CollectionAssert.AreEqual(primitiveTriplesFromTestData, primitiveTriples);
        }

        /// <summary>
        /// Tests the <see cref="Pythagorean.GetTargetTripleProduct(int)"/> method.
        /// </summary>
        /// <param name="targetSum">Target sum.</param>
        /// <param name="expectedA">Expected 'a' value.</param>
        /// <param name="expectedB">Expected 'b' value.</param>
        /// <param name="expectedC">Expected 'c' value.</param>
        /// <param name="expectedProduct">Expected product of the triple.</param>
        [TestMethod]
        [TestCategory(TestList.Validation)]
        [DataRow(12, 3, 4, 5, 60)]
        [DataRow(30, 5, 12, 13, 780)]
        [DataRow(1000, 200, 375, 425, 31875000)]
        public void TestPythagorean_GetTargetTripleProduct(int targetSum, int expectedA, int expectedB, int expectedC, long expectedProduct)
        {
            var (a, b, c, product) = Pythagorean.GetTargetTripleProduct(targetSum);

            Assert.AreEqual(expectedA, a, "a mismatch");
            Assert.AreEqual(expectedB, b, "b mismatch");
            Assert.AreEqual(expectedC, c, "c mismatch");
            Assert.AreEqual(expectedProduct, product, "product mismatch");
        }
    }
}
