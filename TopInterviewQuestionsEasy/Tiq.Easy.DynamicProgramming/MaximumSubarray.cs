using System;

namespace Tiq.Easy.DynamicProgramming
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue, cur = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                cur = Math.Max(nums[i], cur + nums[i]);
                max = Math.Max(max, cur);
            }

            return max;
        }
    }
}
