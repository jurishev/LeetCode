using Xunit;

namespace Tiq.Easy.DynamicProgramming.Tests
{
    public class TiqEasyDynamicProgrammingTests
    {
        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] nums, int expected)
        {
            var actual = new MaximumSubarray().MaxSubArray(nums);
            Assert.Equal(expected, actual);
        }
    }
}
