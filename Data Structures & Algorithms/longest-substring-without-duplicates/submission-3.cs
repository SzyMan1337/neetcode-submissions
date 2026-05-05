public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> characters = new HashSet<char>();

        if (s.Length <= 1) return s.Length;

        int l = 0, r = 1, n = s.Length;
        characters.Add(s[0]);
        int longestSubstring = 0;

        while (r < n)
        {
            if (characters.Contains(s[r]))
            {
                while (s[l] != s[r])
                {
                    characters.Remove(s[l]);
                    l++;
                }
                l++;
            }
            else
            {
                characters.Add(s[r]);
            }

            longestSubstring = Math.Max(longestSubstring, r - l+1);
            r++;
        }

        return longestSubstring;
    }
}
