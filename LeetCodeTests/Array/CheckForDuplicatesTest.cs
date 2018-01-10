using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class CheckForDuplicatesTest
    {
        [TestMethod]
        public void EmptyArrayTest()
        {
            int[] nums = new int[] { };

            Assert.AreEqual(false, ArrayProgram.HasDuplicates(nums));
        }

        [TestMethod]
        public void SimpleArrayTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Assert.AreEqual(false, ArrayProgram.HasDuplicates(nums));
        }

        [TestMethod]
        public void ComplexArrayTest()
        {
            int[] nums = new int[] { 1, 2, 4, 5, 6, 3, 2, 5, 2, 3, 4, 56, 21, 487, 675, 76576, 554, 34, 53, 65, 76, 76, 43, 43, 34, 423, 23, 3243, 3, 244, 5, 6, 43, 3, 3, 3, 3, 2, 33, 1, 3, 3, 3, 3, 3, 3, 3, 3, 1, 3, 3, 3, 3, 3, 3, 1 };

            Assert.AreEqual(true, ArrayProgram.HasDuplicates(nums));
        }
    }
}
