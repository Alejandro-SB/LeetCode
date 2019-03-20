using System;
using System.Collections.Generic;
using LeetCode.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Lists
{
    [TestClass]
    public class MergeSortedListsTests
    {
        [TestMethod]
        public void MergesListsTest()
        {
            ListNode l1 = CreateListNode(1, 2, 4);
            ListNode l2 = CreateListNode(1, 3, 4);

            var mergedList = MergeTwoLists.Merge(l1, l2).ToList();

            var expected = new List<int>()
            {
                1,1,2,3,4,4
            };

            CollectionAssert.AreEqual(expected, mergedList);
        }


        private ListNode CreateListNode(params int[] numbers)
        {
            ListNode previous = null;
            ListNode ln = null;

            for (int i = numbers.Length - 1; i >= 0; --i)
            {
                ln = new ListNode(numbers[i]);

                if (previous != null)
                {
                    ln.next = previous;
                }

                previous = ln;
            }

            return ln;
        }
    }
}
