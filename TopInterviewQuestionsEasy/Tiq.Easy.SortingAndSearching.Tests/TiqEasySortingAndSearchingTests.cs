using System;
using System.Linq;
using Xunit;

namespace Tiq.Easy.SortingAndSearching.Tests
{
    public class TiqEasySortingAndSearchingTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 4, 5, 6 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new int[] { 1, 3, 5, 0, 0, 0 }, 3, new int[] { 2, 4, 6 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void MergeTest(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            new MergeSortedArray().Merge(nums1, m, nums2, n);
            Assert.True(nums1.SequenceEqual(expected));
        }

        [Theory]
        [InlineData(8, 4)]
        public void FirstBadVersionTest(int n, int expected)
        {
            var actual = new FirstBadVersionSolution(expected).FirstBadVersion(n);
            Assert.Equal(expected, actual);
        }
    }
}
