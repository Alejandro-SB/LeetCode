using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class MoveZeroesTest
    {
        [TestMethod]
        public void EmptyArrayTest()
        {
            int[] nums = new int[] { };

            ArrayProgram.MoveZeroes(nums);

            CollectionAssert.AreEqual(new int[] { }, nums);
        }

        [TestMethod]
        public void SimpleArrayTest()
        {
            int[] nums = new int[] { 1, 0, 2, 0, 3, 0 };

            ArrayProgram.MoveZeroes(nums);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 0, 0, 0 }, nums);
        }

        [TestMethod]
        public void ComplexArrayTest()
        {
            int[] nums = new int[] { 0, 0, 0, 1, 0, 0, 2, 0, 3, 5, 67, 4, 5, 6, 0, 3, 4, 3, 6, 7 };

            ArrayProgram.MoveZeroes(nums);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 67, 4, 5, 6, 3, 4, 3, 6, 7, 0, 0, 0, 0, 0, 0, 0 }, nums);
        }
    }
}
