using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class PlusOneTest
    {
        [TestMethod]
        public void SimpleNumberTest()
        {
            int[] num = new int[] { 0 };

            CollectionAssert.AreEqual(new int[] { 1 }, ArrayProgram.PlusOne(num));
        }

        [TestMethod]
        public void SimpleCarryTest()
        {
            int[] num = new int[] { 9 };

            CollectionAssert.AreEqual(new int[] { 1,0 }, ArrayProgram.PlusOne(num));
        }

        [TestMethod]
        public void ComplexNumberTest()
        {
            int[] num = new int[] { 9,9,9 };

            CollectionAssert.AreEqual(new int[] { 1, 0, 0, 0 }, ArrayProgram.PlusOne(num));
        }
    }
}
