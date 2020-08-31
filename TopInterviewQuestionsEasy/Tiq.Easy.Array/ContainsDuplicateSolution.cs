using System.Linq;

namespace Tiq.Easy.Array
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums != null && nums.ToHashSet().Count != nums.Length;
        }
    }
}
