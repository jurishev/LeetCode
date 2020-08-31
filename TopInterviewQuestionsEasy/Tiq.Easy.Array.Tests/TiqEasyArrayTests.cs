using Xunit;

namespace Tiq.Easy.Array.Tests
{
    public class TiqEasyArrayTests
    {
        [Theory]
        [InlineData(null, 0, null)]
        [InlineData(new int[] { }, 0, new int[] { })]
        [InlineData(new int[] { 3 }, 1, new int[] { 3 })]
        [InlineData(new int[] { 2, 2, 2 }, 1, new int[] { 2 })]
        [InlineData(new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2 }, 3, new int[] { 0, 1, 2 })]
        [InlineData(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3 })]
        public void RemoveDuplicatesTest(int[] nums, int expectedLength, int[] expectedSet)
        {
            var sln = new RemoveDuplicatesFromSortedArray();
            var actualLength = sln.RemoveDuplicates(nums);

            Assert.Equal(expectedLength, actualLength);

            if (nums != null)
            {
                for (int i = 0; i < expectedSet.Length; i++)
                {
                    Assert.Equal(expectedSet[i], nums[i]);
                }
            }
        }

        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 2, 2, 2, 2, 2 }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        public void MaxProfitTest(int[] prices, int expected)
        {
            var sln = new BestTimeToBuyAndSell();
            var actual = sln.MaxProfit(prices);

            Assert.Equal(expected, actual);
        }
    }
}
