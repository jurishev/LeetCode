using Xunit;

namespace Tiq.Easy.Strings.Tests
{
    public class TiqEasyStringsTests
    {
        [Theory]
        [InlineData(new char[] { }, new char[] { })]
        [InlineData(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
        [InlineData(new char[] { '1', '2', '3' }, new char[] { '3', '2', '1' })]
        public void ReverseStringTest(char[] s, char[] expected)
        {
            new ReverseStringSolution().ReverseString(s);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], s[i]);
            }
        }

        [Theory]
        [InlineData(int.MinValue, 0)]
        [InlineData(int.MaxValue, 0)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(120, 21)]
        [InlineData(-120, -21)]
        public void ReverseIntegerTest(int x, int expected)
        {
            var actual = new ReverseInteger().Reverse(x);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("aabbcdefg", 4)]
        [InlineData("aabbccdd", -1)]
        [InlineData("leetcode", 0)]
        [InlineData("loveleetcode", 2)]
        public void FirstUniqCharTest(string s, int expected)
        {
            var actual = new FirstUniqueCharacter().FirstUniqChar(s);
            Assert.Equal(expected, actual);
        }
    }
}
