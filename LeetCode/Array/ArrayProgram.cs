using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ArrayProgram
    {
        public static void Main(string[] args)
        {

        }

        #region Solutions

        public static void MoveZeroes(int[] nums)
        {
            ////SOLUTION 1: Concat != 0 and 0 using LINQ
            //// Works when passing by ref
            //int[] zeroes = nums.Where(x => x == 0).ToArray();
            //int[] numbers = nums.Where(x => x != 0).ToArray();

            //nums = numbers.Concat(zeroes).ToArray();

            //SOLUTION 2: In-place modification
            throw new NotImplementedException();
        }

        public static int[] PlusOne(int[] num)
        {
            num[num.Length - 1]++;
            List<int> parsedNum = new List<int>();
            int index = num.Length-1;
            int acc = 0;
            int number;

            while (index >= 0)
            {
                number = num[index] + acc;
                parsedNum.Insert(0, number % 10);
                acc = (int)Math.Floor((double)number / 10);
                index--;
            }

            if (acc != 0)
                parsedNum.Insert(0, acc);

            return parsedNum.ToArray();
        }

        public static int FindSingle(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() == 1).Single().Key;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            List<int> temp = new List<int>();
            int i = 0;
            int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if(nums1[i] == nums2[j])
                {
                    temp.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if(nums1[i]<nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return temp.ToArray();
        }

        public static bool HasDuplicates(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() > 1).Count() > 0;
        }

        public static void RotateArray(ref int[] nums, int k)
        {
            if (nums == null)
                return;

            if (k <= 0 || nums.Length == 0 || k>=nums.Length)
                return;

            var segment1 = new ArraySegment<int>(nums, 0, k);
            var segment2 = new ArraySegment<int>(nums, k, nums.Length-k);

            
            nums = segment2.Concat(segment1).ToArray();
        }

        #endregion
    }
}
