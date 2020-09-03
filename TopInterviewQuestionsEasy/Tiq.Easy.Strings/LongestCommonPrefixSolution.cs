using System.Text;
using System.Linq;

namespace Tiq.Easy.Strings
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            var len = strs.Min(s => s.Length);
            var i = -1;

            while (++i < len)
            {
                var currentChar = strs[0][i];

                if (strs.Select(s => s[i]).All(c => c == currentChar))
                {
                    sb.Append(currentChar);
                }
                else
                {
                    break;
                }
            }

            return sb.ToString();
        }
    }
}
