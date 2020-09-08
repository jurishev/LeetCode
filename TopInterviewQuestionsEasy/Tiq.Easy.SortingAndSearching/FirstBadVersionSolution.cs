namespace Tiq.Easy.SortingAndSearching
{
    public class FirstBadVersionSolution : VersionControl
    {
        public FirstBadVersionSolution(int firstBad) : base(firstBad) { }

        public int FirstBadVersion(int n)
        {
            int min = 1, max = n;

            while (min < max)
            {
                var v = min + (max - min) / 2;

                if (IsBadVersion(v))
                {
                    max = v;
                }
                else
                {
                    min = v + 1;
                }
            }

            return min;
        }
    }
}
