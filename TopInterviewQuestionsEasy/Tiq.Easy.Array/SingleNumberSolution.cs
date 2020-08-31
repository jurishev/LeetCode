using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Array
{
    public class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            System.Array.Sort(nums);

            for (int i = 1; i < nums.Length; i += 2)
            {
                if (nums[i] != nums[i - 1])
                {
                    return nums[i - 1];
                }
            }

            return nums[^1];
        }

        public int SingleNumberDictionary(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            foreach (var value in nums)
            {
                if (dic.ContainsKey(value))
                {
                    dic[value] += 1;
                }
                else
                {
                    dic[value] = 1;
                }
            }

            return dic.Where(i => i.Value == 1).Select(i => i.Key).First();
        }
    }
}
