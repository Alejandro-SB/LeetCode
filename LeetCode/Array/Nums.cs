using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public static class Nums
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int newLength = nums.Length,
                tail = newLength - 1,
                head = 0,
                testVal = 0;


            bool found = false;

            while(head <= newLength && tail>=0 && head < nums.Length)
            {
                if(found)
                {
                    if(nums[tail] != val)
                    {
                        nums[head] = nums[tail];
                        found = false;
                    }
                    else
                    {
                        if(head==tail)
                        {
                            --newLength;
                            return newLength;
                        }
                    }

                    --newLength;
                    --tail;
                }
                else
                {
                    testVal = nums[head];

                    if (testVal == val)
                    {
                        found = true;
                    }
                    else
                    {
                        ++head;
                    }
                }
            }

            return newLength;
        }
    }
}
