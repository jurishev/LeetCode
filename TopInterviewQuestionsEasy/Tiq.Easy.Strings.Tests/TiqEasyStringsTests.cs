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

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void IsAnagramTest(string s, string t, bool expected)
        {
            var actual = new ValidAnagram().IsAnagram(s, t);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void IsAnagramDictionaryTest(string s, string t, bool expected)
        {
            var actual = new ValidAnagram().IsAnagramDictionary(s, t);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData("Madam, I'm Adam", true)]
        [InlineData("T. Eliot, top bard, notes putrid tang emanating, is sad; I'd assign it a name: gnat dirt upset on drab pot toilet.", true)]
        public void IsPalindromeTest(string s, bool expected)
        {
            var actual = new ValidPalindrome().IsPalindrome(s);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("42", 42)]
        [InlineData("    -42", -42)]
        [InlineData("  +4193 with words", 4193)]
        [InlineData("words and 987", 0)]
        [InlineData("-91283472332", int.MinValue)]
        [InlineData("9867473887654", int.MaxValue)]
        [InlineData("20000000000000000000", int.MaxValue)]
        [InlineData("   -20000000000000000000", int.MinValue)]
        [InlineData("  0000000000012345678", 12345678)]
        [InlineData("2147483648", int.MaxValue)]
        public void MyAtoiTest(string str, int expected)
        {
            var actual = new StringToInteger().MyAtoi(str);
            Assert.Equal(expected, actual);
        }
    }
}
