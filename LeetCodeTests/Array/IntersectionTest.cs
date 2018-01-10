using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class IntersectionTest
    {
        [TestMethod]
        public void SimpleArraysTest()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };

            CollectionAssert.AreEquivalent(new int[] { 2, 2 }, ArrayProgram.Intersection(nums1, nums2));
        }

        [TestMethod]
        public void ComplexArraysTest()
        {
            int[] nums1 = new int[] { 1, 2, 2, 1,3,4,5,6,2,3,4,1,2,3,5,3 };
            int[] nums2 = new int[] { 2, 2 ,2,3,3,3,3,1,1,4,5,6};

            CollectionAssert.AreEquivalent(new int[] { 1,1,2, 2,2,3,3,3,3,4,5,6 }, ArrayProgram.Intersection(nums1, nums2));
        }
    }
}
