using System.Linq;
using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Array;

namespace LeetCodeTests.Array
{
    /// <summary>
    /// Summary description for SpiralMatrixTests
    /// </summary>
    [TestClass]
    public class SpiralMatrixTests
    {
        [TestMethod]
        public void SpiralMatrixTest()
        {
            var nums = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            var spiral = SpiralMatrix.Spiral(nums);

            IList<int> result = new List<int> { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            CollectionAssert.AreEqual(result.ToArray(), spiral.ToArray());
        }

        [TestMethod]
        public void BiggerMatrixTest()
        {
            var nums = new int[,] { { 1, 2, 3, 12, 13 }, { 4, 5, 6, 45, 46 }, { 7, 8, 9, 78, 79 } };

            var spiral = SpiralMatrix.Spiral(nums);

            var result = new List<int> { 1, 2, 3, 12, 13, 46, 79, 78, 9, 8, 7, 4, 5, 6, 45 };

            CollectionAssert.AreEqual(result.ToArray(), spiral.ToArray());
        }
    }
}
