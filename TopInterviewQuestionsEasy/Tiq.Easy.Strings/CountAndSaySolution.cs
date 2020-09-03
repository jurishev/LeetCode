using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tiq.Easy.Strings
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var sb = new StringBuilder();
            var dic = new Dictionary<char, int>();
            var output = "1";

            for (int i = 1; i < n; i++)
            {
                output = ReadSequense(output, sb, dic);
            }

            return output;
        }

        private string ReadSequense(string sequense, StringBuilder sb, Dictionary<char, int> dic)
        {
            sb.Length = 0;

            foreach (var c in sequense)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    if (dic.Count > 0)
                    {
                        AppendGroup();
                    }

                    dic[c] = 1;
                }
            }

            AppendGroup();
            return sb.ToString();

            void AppendGroup()
            {
                var item = dic.First();
                sb.Append($"{item.Value}{item.Key}");
                dic.Clear();
            }
        }
    }
}
