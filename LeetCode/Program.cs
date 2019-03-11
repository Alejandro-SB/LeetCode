using LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MinMoves(new int[] { 1, 2147483647 });
        }

        public static int MinMoves(int[] nums)
        {
            int moves = 0;

            if(nums.Length == 2)
            {
                return nums.Max() - nums.Min();
            }

            while(AreDistinct(nums))
            {
                IncrementValues(nums);
                ++moves;
            }

            return moves;
        }

        public static bool AreDistinct(int[] nums)
        {
            int first = nums.First();

            return nums.Any(x => x != first);
        }

        public static void IncrementValues(int[] nums)
        {
            int maxValue = nums.Max();

            int maxIndex = System.Array.IndexOf(nums, maxValue);

            for(int i = 0; i<nums.Length; ++i)
            {
                if(i != maxIndex)
                {
                    nums[i]++;
                }
            }
        }
    }
}
