namespace Tiq.Easy.Strings
{
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack is null || needle is null || haystack.Length < needle.Length)
            {
                return -1;
            }

            return haystack.IndexOf(needle);
        }
    }
}
