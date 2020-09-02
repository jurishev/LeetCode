using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Strings
{
    public class FirstUniqueCharacter
    {
        public int FirstUniqChar(string s)
        {
            if (s is null)
            {
                return -1;
            }

            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var key = s[i];

                dic[key] = dic.ContainsKey(key) ? -1 : i;
            }

            var query = dic.Select(d => d.Value).Where(v => v > -1);

            return query.Any() ? query.Min() : -1;
        }
    }
}
