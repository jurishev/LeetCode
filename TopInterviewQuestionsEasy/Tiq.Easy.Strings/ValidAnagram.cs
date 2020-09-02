using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiq.Easy.Strings
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s == t)
            {
                return true;
            }

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            {
                return false;
            }

            var first = string.Join(string.Empty, s.OrderBy(c => c));
            var second = string.Join(string.Empty, t.OrderBy(c => c));

            return first.Equals(second, StringComparison.OrdinalIgnoreCase);
        }

        public bool IsAnagramDictionary(string s, string t)
        {
            if (s == t)
            {
                return true;
            }

            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
            {
                return false;
            }

            var dic = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            foreach (var c in t)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]--;
                }
                else
                {
                    return false;
                }
            }

            return !dic.Where(d => d.Value != 0).Any();
        }
    }
}
