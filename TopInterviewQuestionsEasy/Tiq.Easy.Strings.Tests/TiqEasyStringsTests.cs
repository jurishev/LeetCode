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

        [Theory]
        [InlineData("hello", "ll", 2)]
        [InlineData("aaaaa", "bba", -1)]
        public void StrStrTest(string haystack, string needle, int expected)
        {
            var actual = new ImplementStrStr().StrStr(haystack, needle);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(10, "13211311123113112211")]
        public void CountAndSayTest(int n, string expected)
        {
            var actual = new CountAndSaySolution().CountAndSay(n);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefixTest(string[] strs, string expected)
        {
            var actual = new LongestCommonPrefixSolution().LongestCommonPrefix(strs);
            Assert.Equal(expected, actual);
        }
    }
}
