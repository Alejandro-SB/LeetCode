using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Lists
{
    public static class MergeTwoLists
    {
        public static ListNode Merge(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);

            if (l1 == null)
            {
                return l2;
            }

            if(l2 == null)
            {
                return l1;
            }

            ListNode current = new ListNode(0);
            head.next = current;

            while(l1 != null || l2 != null)
            {
                ListNode temp;

                if(l1 != null)
                {
                    int val1 = l1.val;
                    int val2;

                    if (l2 != null)
                    {
                        val2 = l2.val;

                        if(val1<= val2)
                        {
                            temp = new ListNode(val1);
                            current.next = temp;
                            current = temp;
                            l1 = l1.next;
                        }
                        else
                        {
                            temp = new ListNode(val2);
                            current.next = temp;
                            current = temp;
                            l2 = l2.next;
                        }
                    }
                    else
                    {
                        temp = new ListNode(val1);
                        current.next = temp;
                        current = temp;
                        l1 = l1.next;
                    }
                }
                else
                {
                    temp = new ListNode(l2.val);
                    current.next = temp;
                    current = temp;
                    l2 = l2.next;
                }
            }

            return head.next.next;
        }

        public static List<int> ToList(this ListNode ln)
        {
            var nums = new List<int>();

            while(ln != null)
            {
                nums.Add(ln.val);

                ln = ln.next;
            }

            return nums;
        }

        public static ListNode ToListNode(this IEnumerable<int> numbers)
        {
            bool isFirst = true;
            ListNode first = null;
            ListNode current = null;
            ListNode previous = null;

            foreach (int i in numbers)
            {
                current = new ListNode(i);

                if(previous != null)
                {
                    previous.next = current;
                }

                if(isFirst)
                {
                    first = current;
                    isFirst = false;
                }

                previous = current;
            }

            return first;
        }
    }
}
