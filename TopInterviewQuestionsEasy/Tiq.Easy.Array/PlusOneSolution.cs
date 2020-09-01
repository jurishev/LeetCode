using System.Collections.Generic;

namespace Tiq.Easy.Array
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            var list = new List<int>(digits);
            var more = false;

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((++list[i]) < 10)
                {
                    more = false;
                    break;
                }

                more = true;
                list[i] = 0;
            }

            if (more)
            {
                list.Insert(0, 1);
            }

            return list.ToArray();
        }
    }
}
