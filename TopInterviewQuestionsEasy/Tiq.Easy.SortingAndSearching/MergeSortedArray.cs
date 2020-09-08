namespace Tiq.Easy.SortingAndSearching
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = nums1.Length;

            m--;
            n--;

            while (--i >= 0)
            {
                nums1[i] =
                    m < 0 ? nums2[n--] :
                    n < 0 ? nums1[m--] :
                    nums1[m] >= nums2[n] ? nums1[m--] : nums2[n--];
            }
        }
    }
}
