using System.Text;

namespace Tiq.Easy.Strings
{
    public class StringToInteger
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            str = str.TrimStart();

            var sb = new StringBuilder();
            var i = 0;

            if (str[i] == '+' || str[i] == '-')
            {
                sb.Append(str[i++]);
            }

            while (i < str.Length && str[i] == '0')
            {
                i++;
            }

            var digitCount = 0;

            while (i < str.Length && char.IsDigit(str[i]))
            {
                sb.Append(str[i++]);
                digitCount++;
            }

            if (digitCount > int.MinValue.ToString().Length - 1 ||
                digitCount > int.MaxValue.ToString().Length)
            {
                return sb[0] == '-' ? int.MinValue : int.MaxValue;
            }

            if (long.TryParse(sb.ToString(), out var result))
            {
                return
                    result > int.MaxValue ? int.MaxValue :
                    result < int.MinValue ? int.MinValue :
                    (int)result;
            }

            return 0;
        }
    }
}
