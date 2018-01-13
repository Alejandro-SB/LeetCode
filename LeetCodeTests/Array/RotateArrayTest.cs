using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class RotateArrayTest
    {
        public void RotateEmptyArray()
        {
            int[] nums = new int[] { };

            ArrayProgram.RotateArray(ref nums, 3);

            CollectionAssert.AreEqual(new int[] { }, nums);
        }

        [TestMethod]
        public void RotateSimpleArrayTest()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            ArrayProgram.RotateArray(ref nums, 3);

            CollectionAssert.AreEqual(new int[] { 4, 5, 1, 2, 3 }, nums);
        }

        [TestMethod]
        public void RotateSmallArrayTest()
        {
            int[] nums = new int[] { 1, 2 };

            ArrayProgram.RotateArray(ref nums, 1);

            CollectionAssert.AreEqual(new int[] { 2, 1 }, nums);
        }
    }
}
