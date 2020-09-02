using System;
using System.Text;

namespace Tiq.Easy.Strings
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var input = (x < 0 ? x * -1 : x).ToString().ToCharArray();
            Array.Reverse(input);

            var sb = new StringBuilder();

            if (x < 0)
            {
                sb.Append('-');
            }

            sb.Append(input);
            var output = sb.ToString();

            if (int.TryParse(output, out var result))
            {
                return result;
            }

            return 0;
        }
    }
}
