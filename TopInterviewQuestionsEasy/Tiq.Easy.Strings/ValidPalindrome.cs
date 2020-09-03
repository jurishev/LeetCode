using System.Text;

namespace Tiq.Easy.Strings
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }

            var sb = new StringBuilder();

            foreach (var c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(char.ToLowerInvariant(c));
                }
            }

            for (int i = 0; i < sb.Length / 2; i++)
            {
                if (sb[i] != sb[^(i + 1)])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
