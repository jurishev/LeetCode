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
    }
}
