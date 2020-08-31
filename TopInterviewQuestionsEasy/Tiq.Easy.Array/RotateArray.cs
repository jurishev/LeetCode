using System.Linq;

namespace Tiq.Easy.Array
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            if ((k %= nums.Length) == 0)
            {
                return;
            }

            var left = nums.Length - k;
            nums.Skip(left).Concat(nums.Take(left)).ToArray().CopyTo(nums, 0);
        }
    }
}
