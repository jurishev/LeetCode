namespace Tiq.Easy.SortingAndSearching
{
    public class VersionControl
    {
        private readonly int firstBad;

        public VersionControl(int firstBad) => this.firstBad = firstBad;

        public bool IsBadVersion(int version) => version >= firstBad;
    }
}
