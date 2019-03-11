using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class PivotIndexClass
    {
        public int PivotIndex(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return -1;
            }

            int len = nums.Length;
            int[] sums = new int[len];

            sums[0] = nums[0];

            for (int i = 1; i < len; ++i)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            if (sums[len - 1] == nums[0])
            {
                return 0;
            }

            for (int i = 1; i < len; ++i)
            {
                if (sums[i - 1] == sums[len - 1] - sums[i])
                {
                    return i;
                }
            }

            if (sums[len - 1] == nums[len - 1])
            {
                return len - 1;
            }

            return -1;
        }
    }
}
