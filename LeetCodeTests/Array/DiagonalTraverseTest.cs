using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using LeetCode.Array;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class DiagonalTraverseTest
    {
        [TestMethod]
        public void DiagonalTraverse_Test()
        {
            int[,] nums = new int[3,3] { { 1, 2, 3 }, 
                                        { 4, 5, 6 },
                                        { 7, 8, 9 } };

            var traverse = DiagonalTraverse.Traverse(nums);

            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 }, traverse);


            int[,] nums2 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            var traverse2 = DiagonalTraverse.Traverse(nums2);

            CollectionAssert.AreEqual(new int[] { 1, 2, 5, 9, 6, 3, 4, 7, 10, 11, 8, 12 }, traverse2);
        }
    }
}
