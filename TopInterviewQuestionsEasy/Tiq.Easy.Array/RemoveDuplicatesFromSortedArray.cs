namespace Tiq.Easy.Array
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums) =>
            nums is null || nums.Length == 0 ? 0 :
            RemoveDuplicatesInPlace(nums);

        private int RemoveDuplicatesInPlace(int[] nums)
        {
            var max = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[max])
                {
                    nums[++max] = nums[i];
                }
            }

            return max + 1;
        }
    }
}
