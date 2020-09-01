using System.Collections.Generic;
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

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 6, new int[] { 3, 4, 1, 2 })]
        [InlineData(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 2, 3 }, 5, new int[] { 2, 3, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 2, new int[] { 5, 6, 1, 2, 3, 4 })]
        public void RotateTest(int[] nums, int k, int[] expected)
        {
            var sln = new RotateArray();
            sln.Rotate(nums, k);

            for (int i = 0; i < nums.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData(new int[] { }, false)]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void ContainsDuplicateTest(int[] nums, bool expected)
        {
            var actual = new ContainsDuplicateSolution().ContainsDuplicate(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 2, 3, 4, 2, 4 }, 3)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 3, 2, 1, 2, 3 }, 1)]
        public void SingleNumberTest(int[] nums, int expected)
        {
            var actual = new SingleNumberSolution().SingleNumber(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 2, 3, 4, 2, 4 }, 3)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 3, 2, 1, 2, 3 }, 1)]
        public void SingleNumberDictionaryTest(int[] nums, int expected)
        {
            var actual = new SingleNumberSolution().SingleNumberDictionary(nums);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, new int[] { })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 2, 2, 1 }, new int[] { 2, 2, 1 }, new int[] { 2, 2, 1 })]
        [InlineData(new int[] { 1, 3, 3, 3, 2, 4 }, new int[] { 3, 3, 3 }, new int[] { 3, 3, 3 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 3, 4, 5, 8, 9 }, new int[] { 3, 4, 5 })]
        public void IntersectTest(int[] nums1, int[] nums2, int[] expected)
        {
            var actual = new IntersectionOfTwoArrays().Intersect(nums1, nums2);

            var expDic = new Dictionary<int, int>();

            foreach (var val in expected)
            {
                if (expDic.ContainsKey(val))
                {
                    expDic[val]++;
                }
                else
                {
                    expDic[val] = 1;
                }
            }

            var actDic = new Dictionary<int, int>();

            foreach (var val in actual)
            {
                if (actDic.ContainsKey(val))
                {
                    actDic[val]++;
                }
                else
                {
                    actDic[val] = 1;
                }
            }

            Assert.Equal(expDic.Count, actDic.Count);

            foreach (var key in expDic.Keys)
            {
                Assert.Equal(expDic[key], actDic[key]);
            }
        }

        [Theory]
        [InlineData(new int[] { 0 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 1, 2, 9 }, new int[] { 1, 3, 0 })]
        [InlineData(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
        public void PlusOneTest(int[] digits, int[] expected)
        {
            var actual = new PlusOneSolution().PlusOne(digits);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1, 2, 0, 0 }, new int[] { 1, 2, 0, 0 })]
        [InlineData(new int[] { -1, 0, 2, 0, -3 }, new int[] { -1, 2, -3, 0, 0 })]
        public void MoveZeroesTest(int[] nums, int[] expected)
        {
            new MoveZeroesSolution().MoveZeroes(nums);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], nums[i]);
            }
        }

        [Theory]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, 7, new int[] { 2, 3 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var actual = new TwoSumSolution().TwoSum(nums, target);

            Assert.Equal(expected.Length, actual.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
