namespace Tiq.Easy.Array
{
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums is null || nums.Length == 1)
            {
                return;
            }

            for (int i = 0, move = -1; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (move < 0)
                    {
                        move = i;
                    }
                }
                else if (move >= 0)
                {
                    nums[move++] = nums[i];
                    nums[i] = 0;
                }
            }
        }

        public void MoveZeroesShorter(int[] nums)
        {
            if (nums is null || nums.Length == 1)
            {
                return;
            }

            for (int i = 0, move = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var t = nums[move];
                    nums[move++] = nums[i];
                    nums[i] = t;
                }
            }
        }
    }
}
