using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class FindSingleTest
    {
        [TestMethod]
        public void SimpleArrayTest()
        {
            int[] nums = new int[] {1,1,2,2,3,3,4,4,5 };

            Assert.AreEqual(5, ArrayProgram.FindSingle(nums));
        }

        [TestMethod]
        public void ComplexArrayTest()
        {
            int[] nums = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5,5,6,6,11,11,22,22,33,33,15,77,77,66,66,88,88,111,222,111,222 };

            Assert.AreEqual(15, ArrayProgram.FindSingle(nums));
        }
    }
}
