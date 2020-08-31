using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Array
{
    public class IntersectionOfTwoArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1 is null || nums2 is null)
            {
                return System.Array.Empty<int>();
            }

            var small = nums1.Length < nums2.Length ? nums1 : nums2;
            var large = nums1.Length < nums2.Length ? nums2 : nums1;

            return GetIntersection(large, GetIndex(small)).ToArray();
        }

        private Dictionary<int, int> GetIndex(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            foreach (var val in arr)
            {
                if (dic.ContainsKey(val))
                {
                    dic[val]++;
                }
                else
                {
                    dic[val] = 1;
                }
            }

            return dic;
        }

        private IEnumerable<int> GetIntersection(int[] arr, Dictionary<int, int> dic)
        {
            foreach (var val in arr)
            {
                if (dic.ContainsKey(val) && dic[val] > 0)
                {
                    yield return val;
                    dic[val]--;
                }
            }
        }
    }
}
