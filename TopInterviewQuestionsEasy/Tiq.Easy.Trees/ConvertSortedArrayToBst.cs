namespace Tiq.Easy.Trees
{
    public class ConvertSortedArrayToBst
    {
        public TreeNode SortedArrayToBST(int[] nums) => Distribute(nums, 0, nums.Length - 1);

        private TreeNode Distribute(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            var middle = (start + end) / 2;

            var node = new TreeNode(nums[middle])
            {
                left = Distribute(nums, start, middle - 1),
                right = Distribute(nums, middle + 1, end)
            };

            return node;
        }
    }
}
